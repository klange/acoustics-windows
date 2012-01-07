using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acoustics {
    public class AcousticsSong {
        public String title;
        public String artist;
        public String album;

        public AcousticsSong(String title, String artist, String album) {
            this.title = title;
            this.artist = artist;
            this.album = album;
        }
    }
}
