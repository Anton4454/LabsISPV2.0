using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Riding: Sportsman
    {
        public struct Horse
        {
            public string NameHorse;
            public int AgeHorse;
        }
        public Horse PlayersHorse;
        public Riding(string n, string s, int a, int w, int h, string male, string country_name, string horse_name, int horse_age) : base(n, s, a, w, h, male, country_name)
        {
            PlayersHorse.NameHorse = horse_name;
            PlayersHorse.AgeHorse = horse_age;
        }
        public override void Change()
        {
            Console.WriteLine("Enter the name of new horse:");
            string nname = Console.ReadLine();
            Console.WriteLine("Enter the age of new horse:");
            string nnage = Console.ReadLine();
            int nage = Convert.ToInt32(nnage);
            PlayersHorse.NameHorse = nname;
            PlayersHorse.AgeHorse = nage;
        }
        public override void Write()
        {
            if (Gender == "male")
            {
                Console.WriteLine($"He is a horse racer. His horse's Name is {PlayersHorse.NameHorse}. It is {PlayersHorse.AgeHorse} years old. \n");
            }
            else
            {
                Console.WriteLine($"She is a horse racer. Her horse's Name is {PlayersHorse.NameHorse}. It is {PlayersHorse.AgeHorse} years old. \n");
            }
        }

    }
}
