using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Gymnastics: Sportsman
    {
        public string equipment;
        public enum Things
        {
            Rope=1, Hoop, Ball, Mace, Ribbon
        }
        public Gymnastics(string n, string s, int a, int w, int h, string male, string country_name, int x) : base(n, s, a, w, h, male, country_name)
        {
            switch (x)
            {
                case (int)Things.Rope:
                    equipment = "rope";
                    break;
                case (int)Things.Hoop:
                    equipment = "hoop";
                    break;
                case (int)Things.Ball:
                    equipment = "ball";
                    break;
                case (int)Things.Mace:
                    equipment = "mace";
                    break;
                case (int)Things.Ribbon:
                    equipment = "ribbon";
                    break;
                default:
                    Console.WriteLine("ERROR. Wrong equipment.");
                    equipment = "";
                    break;
            }
        }
        public override void Change()
        {
            Console.WriteLine("Enter the name of new equipment:");
            string nname = Console.ReadLine();
            equipment = nname;
        }
        public override void Write()
        {
            if (gender == "male")
            {
                Console.WriteLine($"He's a gymnast with {equipment}. \n");
            }
            else
            {
                Console.WriteLine($"She's a gymnast with {equipment}. \n");
            }
        }

    }
}
