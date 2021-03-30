using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("Int The End","Linkin Park", 2007, 260);
            MusicFile m2 = new MusicFile("Heavy", "Linkin Park", 2017, 270);
            MusicFile m3 = new MusicFile("Faded", "Alan Walker", 2016, 260);
            MusicFile m4 = new MusicFile("A Sky Full of Stars", "Coldplay", 2012, 266);
            MusicFile m5 = new MusicFile("Memories", "Maroon 5", 2020, 258);
            MusicFile m6 = new MusicFile("Alone", "Alan Walker", 2016, 255);
            MusicFile m7 = new MusicFile("Hold on", "Justin Beiber", 2021, 245);
            MusicFile m8 = new MusicFile("Driving License", "Linkin Park", 2021, 265);

            Radio r1 = new Radio("Radio Foorti 88.0fm");
            Radio r2 = new Radio("Radio Amar 89.40fm");
            Radio r3 = new Radio("Radio Express 91.0fm");
            Radio r4 = new Radio("Radio BD 94.5fm");



            Phone p1 = new Phone(2);
            p1.Switch(true);
            Console.WriteLine("**********************");
            
            p1.AddMusic(m1, m2, m3, m4, m5, m6, m7, m8);
            Console.WriteLine("**********************");
            Console.WriteLine("The Music files: ");
            p1.PrintMusic();
            Console.WriteLine("**********************");
            p1.play(true);
            Console.WriteLine("**********************");
            p1.playNext();
            Console.WriteLine("**********************");
            p1.playPrevious();
            Console.WriteLine("**********************");
            p1.setVolume(50);
            Console.WriteLine("**********************");


            p1.AddChannel(r1, r2, r3, r4);
            Console.WriteLine("**********************");
            p1.changeChannel(2);
            Console.WriteLine("**********************");
            p1.retune(55);
            Console.WriteLine("**********************");

        }
    }
}
