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
        public AcousticsStatus(JObject json) {
            try {
                currentSong = new AcousticsSong(
                    (String)json["now_playing"]["title"],
                    (String)json["now_playing"]["artist"],
                    (String)json["now_playing"]["album"]);
                
                time = (int)json["now_playing"]["now"];
                start_time = (int)json["player"]["song_start"];
                length = (int)json["now_playing"]["length"];
            } catch {
                /* Nothing is playing */
                currentSong = null;
            }
            try {
                volume = (int)json["player"]["volume"];
            } catch {
                volume = 50;
            }
        }
    }
}
