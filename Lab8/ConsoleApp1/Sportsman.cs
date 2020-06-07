using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sportsman : Human, ISport, IComparable<Sportsman>
    {
        public string Country { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public string Injuryed { get; set; }
        string volleyball;
        string riding;
        string gymnastics;
        public int Strength { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Draw { get; set; }
        public delegate void Info(string message);
        public event Info Rate;
        public delegate void Str(string message);
        public event Str Skill;
        public Sportsman(string n, string s, int a, int w, int h, string male, string country_name) : base(n, s, a, w, h, male)
        {
            Country = country_name;
            Gold = 0;
            Silver = 0;
            Bronze = 0;
            Injuryed = "healthy";
            volleyball = "not a volleyball";
            riding = "not a riding";
            gymnastics = "not a gymnastics";
            Strength = 0;
            Win = 0;
            Lose = 0;
            Draw = 0;
        }
        public void Train(int skill)
        {
            this.Strength += skill;
            Console.WriteLine($"The training was successful.");
            Skill?.Invoke($"Sportsman {Name} achieved {skill} points of strength.");
        }
        public void PutStrength()
        {
            Console.WriteLine($"Now sportsman {Name} has {Strength} power and skill.");
        }
        public int CompareTo(Sportsman p)
        {
            return this.Strength.CompareTo(p.Strength);
        }
        public Tuple<Sportsman, Sportsman> Compete(Sportsman p)
        {
            int a = this.CompareTo(p);

            if (a == 0)
            {
                Rate?.Invoke("The strength of the sportsmen is equal.\n");
                this.Draw++;
                p.Draw++;
            }
            else if (a > 0)
            {
                Console.WriteLine("The strength of first sportsman is higher.\n");
                this.Win++;
                p.Lose++;
            }
            else
            {
                Console.WriteLine("The strength of second sportsman is higher.\n");
                p.Win++;
                this.Lose++;
            }
            return Tuple.Create(this, p);
        }
        public void AddAward(string s)
        {
            if (s == "gold") Gold++;
            else if (s == "silver") Silver++;
            else if (s == "bronze") Bronze++;
            else Console.Write("ERROR");
        }
        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "volleyball": return "Now sportsman " + Name + " is" + volleyball + "player";
                    case "gymnastics": return "Now sportsman " + Name + " is a gymnast.";
                    case "riding": return "Now sportsman " + Name + " is a horse racer.";
                    case "not volleyball": return "Now sportsman " + Name + " isn't a volleyball player";
                    case "not gymnastics": return "Now sportsman " + Name + " isn't a gymnast.";
                    case "not riding": return "Now sportsman " + Name + " isn't a horse racer.";
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
                        volleyball = value;
                        break;
                    case "not gymnastics":
                        gymnastics = value;
                        break;
                    case "not riding":
                        riding = value;
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
            Console.WriteLine($"The player {Name} is healed.");
            Injuryed = "healthy";
        }
        public void Injury()
        {
            Console.WriteLine($"The player {Name} is injured.");
            Injuryed = "injured";
        }
        public override void Write()
        {
            if (Gender == "male")
            {
                Console.WriteLine($"The Human's name is {Name}. His surname is {Surname}. ");
                Console.WriteLine($"He is a sportsman. He is {volleyball}, {gymnastics}, {riding} player. He is {Injuryed}. He is from {Country}. He has {Gold} gold medals, {Silver} silver medals and {Bronze} bronze medals. ");
                Console.WriteLine($"He is {Age} years old. His height is {Height}. His weigth is {Weight}");
                Console.WriteLine($"His ID is {Id}");
            }
            else
            {
                Console.WriteLine($"The Human's name is {Name}. Her surname is {Surname}.");
                Console.WriteLine($"She is a sportsman. She is {volleyball}, {gymnastics}, {riding} player. She is {Injuryed}. She is from {Country}. She has {Gold} gold medals, {Silver} silver medals and {Bronze} bronze medals. "); 
                Console.WriteLine($"She is {Age} years old. Her height is {Height}. Her weigth is {Weight}");
                Console.WriteLine($"Her ID is {Id}");
            }
        }

    }
}
