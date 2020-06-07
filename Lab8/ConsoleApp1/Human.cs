using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Id { get; set; }
        private static int counter = 0;
        public Human Mother;
        public Human Father;
        List<Human> Children = new List<Human>();
        public Human(string n, string s, int a, int w, int h, string male)
        {
            Name = n;
            Surname = s;
            Age = a;
            Weight = w;
            Height = h;
            Gender = male;
            Id = ++counter;
            Father = null;
            Mother = null;
        }
        public Human(string n, string s, int a, int w, int h, string male, Human mother, Human father)
        {
            Name = n;
            Surname = s;
            Age = a;
            Weight = w;
            Height = h;
            Gender = male;
            Id = ++counter;
            Mother = mother;
            Father = father;
            if (Mother != null) Mother.AddChild(this);
            if (Father != null) Father.AddChild(this);
        }
        void AddChild(Human child)
        {
            Children.Add(child);
        }
        public void AddParent(Human parent)
        {
            if (parent.Gender == "male") Father = parent;
            else Mother = parent;
            parent.AddChild(this);
        }
        public virtual void Write()
        {
            if (Gender == "male")
            {
                Console.WriteLine($"The Human's name is {Name}. His surname is {Surname}. ");
                if (Father != null) Console.WriteLine($"His father is {Father.Name} {Father.Surname}.");
                if (Mother != null) Console.WriteLine($"His mother is {Mother.Name} {Mother.Surname}.");
                if (Children.Count == 0) Console.WriteLine("He has no children");
                else
                {
                    Console.WriteLine("His children are:  ");
                    for (int i = 0; i < Children.Count; i++)
                    {
                        Console.WriteLine($" \t{Children[i].Name}");
                    }
                }
                Console.WriteLine($"He is {Age} years old. His height is {Height}. His weight is {Weight}");
                Console.WriteLine($"His ID is {Id}\n");
            }
            else
            {
                Console.WriteLine($"The Human's name is {Name}. Her surname is {Surname}.");
                if (Father != null) Console.WriteLine($"His father is {Father.Name} {Father.Surname}.");
                if (Mother != null) Console.WriteLine($"His mother is {Mother.Name} {Mother.Surname}.");
                if (Children.Count == 0) Console.WriteLine("She has no children\n");
                else
                {
                    Console.WriteLine("Her children are:  ");
                    for (int i = 0; i < Children.Count; i++)
                    {
                        Console.WriteLine($" \t{Children[i].Name} ");
                    }
                }
                Console.WriteLine($"She is {Age} years old. Her height is {Height}. Her weight is {Weight}");
                Console.WriteLine($"Her ID is {Id}\n");
            }
        }
    }
}
