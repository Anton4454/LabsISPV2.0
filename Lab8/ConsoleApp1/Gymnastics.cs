using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Gymnastics: Sportsman
    {
        public string Equipment { get; set; }
        public enum Things
        {
            Rope=1, Hoop, Ball, Mace, Ribbon
        }
        public Gymnastics(string n, string s, int a, int w, int h, string male, string country_name, int x) : base(n, s, a, w, h, male, country_name)
        {
            switch (x)
            {
                case (int)Things.Rope:
                    Equipment = "rope";
                    break;
                case (int)Things.Hoop:
                    Equipment = "hoop";
                    break;
                case (int)Things.Ball:
                    Equipment = "ball";
                    break;
                case (int)Things.Mace:
                    Equipment = "mace";
                    break;
                case (int)Things.Ribbon:
                    Equipment = "ribbon";
                    break;
                default:
                    Console.WriteLine("ERROR. Wrong equipment.");
                    Equipment = "";
                    break;
            }
        }
        public override void Change()
        {
            Console.WriteLine("Enter the name of new equipment:");
            string nname = Console.ReadLine();
            Equipment = nname;
        }
        public override void Write()
        {
            if (Gender == "male")
            {
                Console.WriteLine($"He's a gymnast with {Equipment}. \n");
            }
            else
            {
                Console.WriteLine($"She's a gymnast with {Equipment}. \n");
            }
        }

    }
}
