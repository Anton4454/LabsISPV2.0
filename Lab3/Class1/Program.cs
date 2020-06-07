using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static List<Human> humans = new List<Human>();
        static Human Read(int x)
        {
            Console.WriteLine("Enter the name of the human: ");
            string imya = Console.ReadLine();
            if (imya.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            Console.WriteLine("Enter the surname of the human: ");
            string familiya = Console.ReadLine();
            if (familiya.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            Console.WriteLine("Enter the age of the human: ");
            string ageCur = Console.ReadLine();
            for (int i = 0; i < ageCur.Length; i++)
                if (!(ageCur[i] >= '0' && ageCur[i] <= '9'))
                {
                    Console.WriteLine("\nERROR");
                    return null;
                }
            if (ageCur.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            int age = Convert.ToInt32(ageCur);
            Console.WriteLine("Enter the height of the human: ");
            string heightCur = Console.ReadLine();
            for (int i = 0; i < heightCur.Length; i++)
                if (!(heightCur[i] >= '0' && heightCur[i] <= '9'))
                {
                    Console.WriteLine("\nERROR");
                    return null;
                }
            if (heightCur.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            int height = Convert.ToInt32(heightCur);
            Console.WriteLine("Enter the weight of the human: ");
            string weightCur = Console.ReadLine();
            for (int i = 0; i < weightCur.Length; i++)
                if (!(weightCur[i] >= '0' && weightCur[i] <= '9'))
                {
                    Console.WriteLine("\nERROR");
                    return null;
                }
            if (weightCur.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            int weight = Convert.ToInt32(weightCur);
            Console.WriteLine("Enter gender (male/female) of the human: ");
            string gender = Console.ReadLine();
            if ((gender != "male") && (gender != "female"))
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            if (x==1) return new Human(imya, familiya, age, weight, height, gender); 
            Console.WriteLine("Enter mother Id of the human: ");
            int motherId = Convert.ToInt32(Console.ReadLine());
            Human mother;
            mother = FindHuman(motherId);
            if (mother == null)
            {
                Console.WriteLine("\nMother not found");
                return null;
            }
            else if (mother.gender == "male")
            {
                Console.WriteLine("\nThis human is a male");
                return null;
            }
            Console.WriteLine("Enter father Id  of the human: ");
            int fatherId = Convert.ToInt32(Console.ReadLine());
            Human father;
            father = FindHuman(fatherId);
            if (father == null)
            {
                Console.WriteLine("\nFather not found");
                return null;
            }
            else if (father.gender == "female")
            {
                Console.WriteLine("\nThis human is a female");
                return null;
            }
            Console.WriteLine();
            return new Human(imya, familiya, age, weight, height, gender, mother, father);
        }
        static Human FindHuman(int identifier)
        {
            for (int i = 0; i < humans.Count; i++)
            {
                if (humans[i].Id == identifier)
                {
                    return humans[i];
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter:\n" +
                                  "1. Show full list\n" +
                                  "2. Add new Human(his/her parents are not in the list)\n" +
                                  "3. Add new Human(his/her parents are in the list)\n" +
                                  "4. Find human\n" +
                                  "5. Exit.");
                int x = Convert.ToInt32(Console.ReadLine());
                Human human;
                switch (x)
                {
                    case 1:
                        if (humans.Count == 0)
                        {
                            Console.WriteLine("There are no Humans in list");
                        }
                        else
                        {
                            Console.WriteLine("The full list:\n");
                            for (int i = 0; i < humans.Count; i++)
                            {
                                humans[i].Write();
                            }
                        }
                        break;
                    case 2:
                        human = Read(1);
                        if (human == null) Console.WriteLine("ERROR");
                        else humans.Add(human);
                        break;
                    case 3:
                        human = Read(2);
                        if (human == null) Console.WriteLine("ERROR");
                        else humans.Add(human);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Id:");
                        int identifier = Convert.ToInt32(Console.ReadLine());
                        human = FindHuman(identifier);
                        if (human == null) Console.WriteLine("Human not found!");
                        else human.Write();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
