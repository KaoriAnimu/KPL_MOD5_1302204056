using System;


namespace KPLMOD5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WatashiNoBideo s = new WatashiNoBideo ("\n Film Review of Fate Grand Order by Moch. Kaori Rahadian ") ;

            Console.WriteLine();

            WatashiNoBideo s1 = new WatashiNoBideo ("\n Film Review of Fate Stay Night by Moch. Kaori Rahadian ") ;

            Console.WriteLine();

            WatashiNoBideo s2 = new WatashiNoBideo("\n Film Review of Fate Zero by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s3 = new WatashiNoBideo("\n Film Review of Fate Apocrypha by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s4 = new WatashiNoBideo("\n Film Review of Fate Extra by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s5 = new WatashiNoBideo("\n Film Review of Taimanin Asagi Night by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s6 = new WatashiNoBideo("\n Film Review of Hell Knight Inggrid by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s7 = new WatashiNoBideo("\n Film Review of Pisu Hame by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s8 = new WatashiNoBideo("\n Film Review of OniChiChi by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s9 = new WatashiNoBideo("\n Film Review of Kuroinu by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoBideo s10 = new WatashiNoBideo("\n Film Review of Tokubetsu Jugyou 3 by Moch. Kaori Rahadian ");

            Console.WriteLine();

            WatashiNoYusaa ss = new WatashiNoYusaa (" Moch. Kaori Rahadian ") ;

            s.IncreaseSaiseikaisu(1) ;

            s1.IncreaseSaiseikaisu(10) ;

            ss.AddVideo(s) ;

            ss.AddVideo(s1) ;

            ss.AddVideo(s2) ;

            ss.AddVideo(s3) ;

            ss.AddVideo(s4) ;

            ss.AddVideo(s5) ;

            ss.AddVideo(s6) ;

            ss.AddVideo(s7) ; 

            ss.AddVideo(s8) ;

            ss.AddVideo(s9) ;

            ss.AddVideo(s10) ;

            s.PrintVideoDetails() ;

            ss.PrintAllVideoSaiseikaisu() ;

        }
    }
}
