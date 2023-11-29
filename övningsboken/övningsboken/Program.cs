using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övningsboken
{
    internal class Program
    {
        //övning 11.1
      /*  static void Hello(string name)
        {
            Console.WriteLine("Var god skriv ditt namn:");
            name = Console.ReadLine();
            Console.WriteLine("Hallå " + name + "!");
            
        } */

        //övning 11.2

      /*  static void tvåStränger()
        {

            Console.WriteLine("Var god skriv en rad:");
            string läsText = Console.ReadLine();
            Console.WriteLine("Var god skriv en till rad:");
            string läsTextigen = Console.ReadLine();
            Console.WriteLine("Du skrev följande: " + läsText + " " + läsTextigen + ".");
        
        } */

        //övning 11.3

     /*   static void Addera()
        {
            Console.WriteLine("Skriv en siffra:");
            string strNr = Console.ReadLine();
            int nr1 = Convert.ToInt32(strNr);
            Console.WriteLine("Skriv en siffra till:");
            string strNr2 = Console.ReadLine();
            int nr2 = Convert.ToInt32(strNr2);
            int sum = nr1 + nr2;
            Console.WriteLine("Dina nummer blir: ");
            Console.WriteLine(sum);
        }*/

        //övning 11.4
   /*      static void RäknaUtMoms()
        {
            Console.WriteLine("Skriv en siffra så räknar jag ut vad momsen blir om den ligger på 25%:");
            string dittTal = Console.ReadLine();
            int nr = Convert.ToInt32(dittTal);
           // int sum = nr * 1,25;
            Console.WriteLine("Det angivna talets moms är ");
            Console.WriteLine();
            printf()
                */

        }
        static void Main(string[] args)
        {
        // RäknaUtMoms();
        //  Hello("Hallå");
        //    tvåStränger();
        //   Addera();
        int siffra1 = 10;

        int siffra2 = 20;

        Console.WriteLine("Summan av siffrorna är: " + (siffra1 + siffra2));

    }
    }
}
