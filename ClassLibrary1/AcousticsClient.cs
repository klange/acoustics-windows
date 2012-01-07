using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Security;
using System.Drawing;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Acoustics {
    public class AcousticsClient {
        public WebClient webClient;
        public String source;
        private CookieContainer cookies;
        private NetworkCredential creds;
        public AcousticsStatus currentStatus;

        public AcousticsClient(String source) {
            this.source = source;
            this.cookies = new CookieContainer();
        }

        public string sendRequest(String path) {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(source + path);
            req.CookieContainer = cookies;
            req.Credentials = creds;
            req.Method = "GET";
            WebResponse res = req.GetResponse();
            Stream stream = res.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            String _out = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            res.Close();
            return _out;
        }

        public void login(String uname, String password) {
            SecureString pass = new SecureString();
            foreach (char c in password.ToCharArray()) {
                pass.AppendChar(c);
            }
            creds = new NetworkCredential(uname, pass);
            sendRequest("www-data/auth/");
        }

        public String getResponse(String args) {
            return sendRequest("json.pl?" + args);
        }

        public JObject responseObject(String args) {
            String s = getResponse(args);
            return JObject.Parse(s);
        }

        public AcousticsStatus getStatus() {
            currentStatus = new AcousticsStatus(responseObject("mode=status"));
            return currentStatus;
        }

        public String encode(String str) {
            str = str.Replace("/", "%2f");
            str = HttpUtility.UrlEncode(str);
            
            return str;
        }

        public String albumArtUrl(AcousticsSong song) {
            return source + "json.pl?mode=art;title=" + encode(song.title) +
                    ";artist=" + encode(song.artist) + ";album=" + encode(song.album) + ";size=512";
        }

        public Image getAlbumArt(AcousticsSong song) {
            Image tmpImg = null;
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(albumArtUrl(song));
                WebResponse res = req.GetResponse();
                Stream stream = res.GetResponseStream();
                tmpImg = Image.FromStream(stream);
                stream.Close();
                res.Close();
                return tmpImg;
            } catch (Exception e) {
                return null;
            }
        }

        public void stop() {
            getResponse("mode=stop");
        }
        public void playPause() {
            getResponse("mode=start");
        }
        public void skip() {
            getResponse("mode=skip");
        }
        public void volume(int difference) {
            currentStatus.volume += difference * 10;
            getResponse("mode=volume;value=" + (currentStatus.volume).ToString());
        }
    }
}
