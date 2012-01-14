using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Acoustics {
    public class AcousticsStatus {
        public AcousticsSong currentSong;
        public int volume;
        public int time;
        public int start_time;
        public int length;
        public String user;
        public String player;
        public AcousticsStatus(JObject json) {
            try {
                currentSong = new AcousticsSong(
                    (String)json["now_playing"]["title"],
                    (String)json["now_playing"]["artist"],
                    (String)json["now_playing"]["album"]);
                
                time = (int)json["now_playing"]["now"];
                start_time = (int)json["player"]["song_start"];
                length = (int)json["now_playing"]["length"];
                volume = (int)json["player"]["volume"];
            } catch {
                /* Nothing is playing */
                currentSong = null;
                volume = 50;
            }
            try {
                user = (String)json["who"];
                player = (String)json["selected_player"];
            } catch {
                user = "";
                player = "";
            }
        }
    }
}
