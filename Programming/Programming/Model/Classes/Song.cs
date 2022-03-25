using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string _nameSong;
        private double _durationSong;
        private int _release;

        public Song()
        {
        }

        public Song(string nameSong,
                    double durationSong,
                    int release)
        {
            NameSong = nameSong;
            DurationSong = durationSong;
            Release = release;
        }

        public string NameSong { get; set; }

        public double DurationSong
        {
            get
            {
                return _durationSong;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Продолжительность песни не может быть отрицальной!");
                }

                _durationSong = value;
            }
        }

        public int Release
        {
            get
            {
                return _release;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(message: "Дата выпуска не может быть отрицательной!");
                }

                _release = value;
            }
        }
    }
}
