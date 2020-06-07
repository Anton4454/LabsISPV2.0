using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human
    {
        public int age, Id;
        public int height, weight;
        public string name, surname, gender;
        public static int counter = 0;
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
        public string Name
        {
            set
            {
                if (value.Length > 0) name = value;
                else throw new InvalidOperationException();
            }
            get { return name; }
        }
        public string Surname
        {
            set
            {
                if (value.Length > 0) surname = value;
                else throw new InvalidOperationException();
            }
            get { return surname; }
        }
        public string Gender
        {
            set
            {
                if (value == "male") gender = "male";
                else if (value == "female") gender = "female";
                else throw new InvalidOperationException();
            }
            get { return gender; }
        }
        public int Age
        {
            set
            {
                if ((value <= 100) && (value >= 0)) age = value;
                else throw new InvalidOperationException();
            }
            get { return age; }
        }
        public int Height
        {
            set
            {
                if ((value <= 250) && (value >= 0)) height = value;
                else throw new InvalidOperationException();
            }
            get { return height; }
        }
        public int Weight
        {
            set
            {
                if ((value <= 200) && (value >= 0)) weight = value;
                else throw new InvalidOperationException();
            }
            get { return weight; }
        }
        void AddChild(Human child)
        {
            Children.Add(child);
        }
        public void AddParent(Human parent)
        {
            if (parent.gender == "male") Father = parent;
            else Mother = parent;
            parent.AddChild(this);
        }
        public virtual void Write()
        {
            if (gender == "male")
            {
                Console.WriteLine($"The Human's name is {name}. His surname is {surname}. ");
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
                Console.WriteLine($"He is {age} years old. His height is {height}. His weigth is {weight}");
                Console.WriteLine($"His ID is {Id}\n");
            }
            else
            {
                Console.WriteLine($"The Human's name is {name}. Her surname is {surname}.");
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
                Console.WriteLine($"She is {age} years old. Her height is {height}. Her weigth is {weight}");
                Console.WriteLine($"Her ID is {Id}\n");
            }
        }
    }
}
