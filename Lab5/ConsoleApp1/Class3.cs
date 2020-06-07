using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Volleyball : Sportsman
    {
        public string team;
        public int number;
        public Volleyball(string n, string s, int a, int w, int h, string male, string country_name, string team_name, int team_number) : base(n, s, a, w, h, male, country_name)
        {
            team = team_name;
            number = team_number;
        }
        public override void Change()
        {
            Console.WriteLine("Enter the name of new team:");
            string nname = Console.ReadLine();
            team = nname;
            Console.WriteLine("Enter the sportsman's number in new team:");
            string nnnumber = Console.ReadLine();
            int nnumber = Convert.ToInt32(nnnumber);
            number=nnumber;
        }
        public override void Write()
        {
            if (gender == "male")
            {
                Console.WriteLine($"He is voleyball player. He is {injury}. He is from {team} team. He plays under number {number}.\n");
            }
            else
            {
                Console.WriteLine($"She is voleyball player. She is {injury}. She is from {team} team. She plays under number {number}.\n");
            }
        }

    }
}
