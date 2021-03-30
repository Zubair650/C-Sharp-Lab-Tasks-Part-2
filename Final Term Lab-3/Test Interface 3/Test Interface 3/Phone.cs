using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Phone : MusicPlayerInterface, RadioPlayerInterface
    {
        private MusicFile[] musicFiles;

        public void AddMusic(params MusicFile[] ms)
        {
            foreach(MusicFile m in ms )
            {
                musicFiles[musicCount++] = m;
                m.Ph = this;

            }
        }

        public void PrintMusic()
        {
            for(int i=0; i< musicCount; i++)
            {
                musicFiles[i].ShowInfo();
            }
        }

        public void Switch(bool on)
        {
            if(on == true)
            {
                Console.WriteLine("Phone Switched on");
            }
            else { Console.WriteLine("Phone Switched off"); }

        }
        int j;
        public void play(bool on)
        {
            if (on == true)
            {
                if(j < musicCount)
                {
                   Console.WriteLine("The Music playing is: ");
                   musicFiles[j].ShowInfo();
                }
                
            }
            
        }
        public void playNext()
        {
            //int k;
            Console.WriteLine("The next Music playing is: ");
            this.j = j;
            if (j < musicCount-1)
            {
                musicFiles[j + 1].ShowInfo();
            }

        }

        public void setVolume(int loudness)
        {
            //int i = 0;
            if(loudness> 100*0.7)
            {
                Console.WriteLine("Decrease the volume.The current volume is harmful for your brain and ear.");
            }
            else 
            {
                Console.WriteLine("Perfect Volume. Enjoy the music.");
            }
            
        }

       

        public void playPrevious()
        {
            Console.WriteLine("The previous Music playing is: ");
            this.j = j;

            if(j > 0)
            {
                musicFiles[j - 1].ShowInfo();
            }
           
        }

        public void retune(double frequency)
        {
            if (frequency > 100 * 0.7)
            {
                Console.WriteLine("Decrease the frequency.The current volume is harmful for your brain and ear.");
            }
            else
            {
                Console.WriteLine("Perfect frequency. Enjoy the radio.");
            }

        }
        private Radio[] radio;

        public void AddChannel(params Radio[] r )
        {
            foreach(Radio rd in r)
            {
                radio[channelCount++] = rd;
                rd.Ph1 = this;
            }
        }


        private int channelCount;

        public int ChannelCount
        {
            get { return channelCount; }
            set { channelCount = value; }
        }
        public void changeChannel(int k)
        {
            if( k < channelCount)
            {
                Console.WriteLine("The Radio channel playing is: ");
                radio[k].ShowInfo();
            }
            
        }

        private int musicCount;

        public int MusicCount
        {
            get { return musicCount; }
            set { musicCount = value; }
        }

        public Phone(int currentplayj)
        {
            this.j = currentplayj;

            //int [] MusicFile = new int[500];
            musicFiles = new MusicFile[500];
            radio = new Radio[20];
        }

    }
}
