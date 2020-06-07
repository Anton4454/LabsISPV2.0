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
            public string name_horse;
            public int age_horse;
        }
        public Horse horse;
        public Riding(string n, string s, int a, int w, int h, string male, string country_name, string horse_name, int horse_age) : base(n, s, a, w, h, male, country_name)
        {
            horse.name_horse = horse_name;
            horse.age_horse = horse_age;
        }
        public override void Change()
        {
            Console.WriteLine("Enter the name of new horse:");
            string nname = Console.ReadLine();
            Console.WriteLine("Enter the age of new horse:");
            string nnage = Console.ReadLine();
            int nage = Convert.ToInt32(nnage);
            horse.name_horse = nname;
            horse.age_horse = nage;
        }
        public override void Write()
        {
            if (gender == "male")
            {
                Console.WriteLine($"He is a horse racer. His horse's name is {horse.name_horse}. It is {horse.age_horse} years old. \n");
            }
            else
            {
                Console.WriteLine($"She is a horse racer. Her horse's name is {horse.name_horse}. It is {horse.age_horse} years old. \n");
            }
        }

    }
}
