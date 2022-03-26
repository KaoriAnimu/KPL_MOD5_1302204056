using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD5
{
    internal class WatashiNoBideo
    {
        private int id ;

        private String taitoru ;

        private int Saiseikaisu ;

        public WatashiNoBideo(String taitoru)
        {

            Random random = new Random() ;

            this.id = random.Next(10000, 99999) ;

            if (taitoru == "")

                throw new NullReferenceException(" Null is not allowed for tittle ") ;

            if (taitoru.Length > 200)

                throw new Exception(" The maximum length of the text is 100 Characters ") ;

            this.taitoru = taitoru ;


            this.Saiseikaisu = 0 ;

        }

        public void IncreaseSaiseikaisu(int x)
        {
            if (x == -1 && x > 25000000)

                throw new NullReferenceException(" Null is not allowed for tittle ") ;

            this.Saiseikaisu = x ;

        }

        public int getSaiseikaisu()
        {

            return this.Saiseikaisu ;

        }

        public String gettaitoru()
        {

            return this.taitoru ;

        }

        public void PrintVideoDetails()
        {
            for (int x = 0; x < Saiseikaisu; x++)
            {

                Console.WriteLine(" Bideo ID : " + this.id) ;

                Console.WriteLine();

                Console.WriteLine(" Bideo taitoru : " + this.taitoru) ;

                Console.WriteLine();

                Console.WriteLine(" Bideo Saiseikaisu : " + (x+1)) ;

                Console.WriteLine() ;

            }


        }

    }
}
