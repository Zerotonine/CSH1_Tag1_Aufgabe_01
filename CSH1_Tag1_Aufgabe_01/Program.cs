using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag1_Aufgabe_01
{
    class Program
    {
        //Teilaufgabe: a
        static int g = 10;

        static void Main(string[] args)
        {
            //Teilaufgabe: b 
            int h = 5;

            //Teilaufgabe: e
            Console.WriteLine($"g: {g} - h: {h}");
            
            //Aufruf Funktion aus Teilaufgabe c
            Hallo();

            //Teilaufgabe d
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine("Welt");
            }

            //Teilaufgabe: f
            Console.ReadKey();
        }

        //Teilaufgabe: c
        static void Hallo()
        {
            for(int i = 0; i < g; i++)
            {
                Console.WriteLine("Hallo");
            }
        }
    }
}
