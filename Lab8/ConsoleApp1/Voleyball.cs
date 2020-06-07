using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Volleyball : Sportsman
    {
        public string Team { get; set; }
        public int Number { get; set; }
        public Volleyball(string n, string s, int a, int w, int h, string male, string country_name, string team_name, int team_number) : base(n, s, a, w, h, male, country_name)
        {
            Team = team_name;
            Number = team_number;
        }
        public override void Change()
        {
            Console.WriteLine("Enter the Name of new Team:");
            string nname = Console.ReadLine();
            Team = nname;
            Console.WriteLine("Enter the sportsman's Number in new Team:");
            string nnnumber = Console.ReadLine();
            int nnumber = Convert.ToInt32(nnnumber);
            Number=nnumber;
        }
        public override void Write()
        {
            if (Gender == "male")
            {
                Console.WriteLine($"He is voleyball player. He is {Injuryed}. He is from {Team} Team. He plays under Number {Number}.\n");
            }
            else
            {
                Console.WriteLine($"She is voleyball player. She is {Injuryed}. She is from {Team} Team. She plays under Number {Number}.\n");
            }
        }

    }
}
