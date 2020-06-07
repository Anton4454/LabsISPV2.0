using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sportsman: Human, ISport, IComparable<Sportsman>
    {
        public string country;
        public int gold, silver, bronze;
        public string injury;
        string volleyball;
        string riding;
        string gymnastics;
        public int strength;
        public Sportsman(string n, string s, int a, int w, int h, string male, string country_name): base(n, s, a, w, h, male)
        {
            country = country_name;
            gold = 0;
            silver = 0;
            bronze = 0;
            injury = "healthy";
            volleyball = "not a volleyball";
            riding = "not a riding";
            gymnastics = "not a gymnastics";
            strength = 0;
        }
        public void Train(int skill)
        {
            this.strength += skill;
            Console.WriteLine($"The training was successful.");
        }
        public void PutStrength()
        {
            Console.WriteLine($"Now sportsman {name} has {strength} power and skill.");
        }
        public int CompareTo(Sportsman p)
        {
            return this.strength.CompareTo(p.strength);
        }
        public void AddAward(string s)
        {
            if (s == "gold") gold++;
            else if (s == "silver") silver++;
            else if (s == "bronze") bronze++;
            else Console.Write("ERROR");
        }
        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "volleyball": return "Now sportsman " + name + " is" + volleyball + "player";
                    case "gymnastics": return "Now sportsman " + name + " is a gymnast.";
                    case "riding": return "Now sportsman " + name + " is a horse racer.";
                    case "not volleyball": return "Now sportsman " + name + " isn't a volleyball player";
                    case "not gymnastics": return "Now sportsman " + name + " isn't a gymnast.";
                    case "not riding": return "Now sportsman " + name + " isn't a horse racer.";
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "volleyball":
                        volleyball = value;
                        break;
                    case "gymnastics":
                        gymnastics = value;
                        break;
                    case "riding":
                        riding = value;
                        break;
                    case "not volleyball":
                        volleyball =  value;
                        break;
                    case "not gymnastics":
                        gymnastics =  value;
                        break;
                    case "not riding":
                        riding =  value;
                        break;

                }
            }
        }
        public virtual void Change()
        {
            Console.WriteLine("Enter the new type of sport: ");
            string nsport = Console.ReadLine();
            this[nsport] = nsport;
        }
        public void Heal()
        {
            Console.WriteLine($"The player {name} is healed.");
            injury = "healthy";
        }
        public void Injury()
        {
            Console.WriteLine($"The player {name} is injured.");
            injury = "injured";
        }
        public override void Write()
        {
            if (gender == "male")
            {
                Console.WriteLine($"The Human's name is {name}. His surname is {surname}. ");
                Console.WriteLine($"He is a sportsman. He is {volleyball}, {gymnastics}, {riding} player. He is {injury}. He is from {country}. He has {gold} gold medals, {silver} silver medals and {bronze} bronze medals. ");
                Console.WriteLine($"He is {age} years old. His height is {height}. His weigth is {weight}");
                Console.WriteLine($"His ID is {Id}");
            }
            else
            {
                Console.WriteLine($"The Human's name is {name}. Her surname is {surname}.");
                Console.WriteLine($"She is a sportsman. She is {volleyball}, {gymnastics}, {riding} player. She is {injury}. She is from {country}. She has {gold} gold medals, {silver} silver medals and {bronze} bronze medals. "); 
                Console.WriteLine($"She is {age} years old. Her height is {height}. Her weigth is {weight}");
                Console.WriteLine($"Her ID is {Id}");
            }
        }

    }
}
