using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD5
{
    internal class WatashiNoYusaa
    {
        private int id ;

        private List<WatashiNoBideo> uploadedVideos ;

        private string Username ;

        public WatashiNoYusaa(String username)
        {

            Random random = new Random() ;

            this.id = random.Next(10000, 99999) ;

            this.uploadedVideos = new List<WatashiNoBideo>() ;

            this.Username = username ;

        }

        public int GetTotalVideoSaiseikaisu()
        {

            int total = 0 ;

            for (int i = 0; i < uploadedVideos.Count; i++)

                total = total + uploadedVideos[i].getSaiseikaisu() ;

            return total ;

        }

        public void AddVideo(WatashiNoBideo a)
        {

            uploadedVideos.Add(a) ;

        }

        public void PrintAllVideoSaiseikaisu()
        {

            Console.WriteLine();

            Console.WriteLine(" Yusa : " + this.Username);

            for (int i = 0; i < uploadedVideos.Count; i++)

                Console.WriteLine("\n Bideo " + (i + 1) + " Taitoru: " + uploadedVideos[i].gettaitoru()) ;

                Console.WriteLine() ;

                Console.WriteLine(" Total of all Saiseikaisu : " + GetTotalVideoSaiseikaisu()) ;

        }
    }
}