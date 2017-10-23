using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockExamBoxCalcWCF;

namespace MockExamCalcConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 ConService = new Service1();
            string line = Console.ReadLine();
            string myLine = Console.ReadLine();
            
            while (!line.Trim().ToLower().Equals("stop"))
            {
                Console.WriteLine("Udregn Side, eller Volume?");
                myLine = Console.ReadLine().Trim() ?? "";
                if (myLine.ToLower().Equals("side"))
                {
                    double volume;
                    double side1;
                    double side2;

                    Console.WriteLine("angiv Volumen");
                    string tempVol = Console.ReadLine();
                    volume = Double.Parse(tempVol);

                    Console.WriteLine("angiv Side1");
                    string tempSide1 = Console.ReadLine();
                    side1 = Double.Parse(tempSide1);

                    Console.WriteLine("angiv Side2");
                    string tempSide2 = Console.ReadLine();
                    side2 = Double.Parse(tempSide2);

                    
                    Console.WriteLine("Den manglende side er: " + ConService.GetSide(volume, side1, side2));
                }

                if (myLine.ToLower().Equals("volume"))
                {
                    double side1;
                    double side2;
                    double side3;

                    Console.WriteLine("angiv Side1");
                    string tempSide1 = Console.ReadLine();
                    side1 = Double.Parse(tempSide1);

                    Console.WriteLine("angiv Side2");
                    string tempSide2 = Console.ReadLine();
                    side2 = Double.Parse(tempSide2);

                    Console.WriteLine("angiv Side3");
                    string tempSide3 = Console.ReadLine();
                    side3 = Double.Parse(tempSide3);


                    Console.WriteLine("Boxens Volumen er: " + ConService.GetVolume(side1, side2, side3));
                }
            }
        }
    }
}
