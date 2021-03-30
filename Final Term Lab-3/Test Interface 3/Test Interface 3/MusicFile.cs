using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        { }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;

        }
        private Phone phone;

        public Phone Ph
        {
            get { return phone; }
            set { phone = value; }
        }

        public void ShowInfo()
        {
            
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Artist: " + artist);
            Console.WriteLine("Year Of Release: " + yearOfRelease);
            Console.WriteLine("Duration In Seconds: "+ durationInSeconds);


        }

    }
}
