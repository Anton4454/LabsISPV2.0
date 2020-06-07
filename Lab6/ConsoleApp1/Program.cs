using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Program
        {
            static List<Human> humans = new List<Human>();
            static List<Tuple<Sportsman, Volleyball, Gymnastics, Riding>> sportsmen = new List<Tuple<Sportsman, Volleyball, Gymnastics, Riding>>();
        static Human Read_Human(int x)
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
            if (x == 1) return new Human(imya, familiya, age, weight, height, gender);
            else 
            {
                Console.WriteLine("Enter mother Id of the human: ");
                int motherId = Convert.ToInt32(Console.ReadLine());
                Human mother;
                mother = FindInfoHuman(motherId);
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
                Console.WriteLine("Enter father Id of the human: ");
                int fatherId = Convert.ToInt32(Console.ReadLine());
                Human father;
                father = FindInfoHuman(fatherId);
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
        }
        static Tuple<Sportsman,Volleyball,Gymnastics,Riding> Read_Sportsman()    
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
            Console.WriteLine("Enter the name of the country: ");
            string country = Console.ReadLine();
            if (country.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            Console.WriteLine("Enter the type of the sport: ");
            string sport = Console.ReadLine();
            if (sport.Length == 0 || ((sport != "Volleyball") && (sport != "Gymnastics") && (sport != "Riding") && (sport != "volleyball") && (sport != "gymnastics") && (sport != "riding")))
            {
                Console.WriteLine("\nERROR");
            }
            int x=0;
            Sportsman q = new Sportsman(imya, familiya, age, weight, height, gender, country);
            Volleyball a1=null;
            Gymnastics a2=null;
            Riding a3=null;
                if (sport == "volleyball")
                {
                    q["volleyball"] = "volleyball";
                    x = 1;
                }
                if (sport == "riding")
                {
                    q["riding"] = "riding";
                    x = 3;
                }
                if (sport == "gymnastics")
                {
                    q["gymnastics"] = "gymnastics";
                    x = 2;
                }
                if (x == 1)
                {
                    a1 = ReadVolleyball(imya, familiya, age, weight, height, gender, country);
                    a1.Id = q.Id;
                }
                else if (x == 2)
                {
                    a2=ReadGymnastics(imya, familiya, age, weight, height, gender, country);
                    a2.Id = q.Id;
                }
                else
                {
                    a3=ReadRiding(imya, familiya, age, weight, height, gender, country);
                    a3.Id = q.Id;
                }
            return Tuple.Create(q, a1, a2, a3);
            }


        static Volleyball ReadVolleyball(string imya, string familiya, int age, int weight, int height, string gender, string country)
        {
            Console.WriteLine("Enter the name of the team: ");
            string team = Console.ReadLine();
            if (team.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            Console.WriteLine("Enter the number of the player: ");
            string nnumber = Console.ReadLine();
            if (nnumber.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            int number = Convert.ToInt32(nnumber);
            return new Volleyball(imya, familiya, age, weight, height, gender, country, team, number);
        }


        static Gymnastics ReadGymnastics(string imya, string familiya, int age, int weight, int height, string gender, string country)
        {
            Console.WriteLine("Enter the equipment (1 - Rope, 2 - Hoop, 3 - Ball, 4 - Mace, 5 - Ribbon): ");
            int equipment = Convert.ToInt32(Console.ReadLine());
            if (equipment > 5 || equipment < 1)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            return new Gymnastics(imya, familiya, age, weight, height, gender, country, equipment);
        }

        static Riding ReadRiding(string imya, string familiya, int age, int weight, int height, string gender, string country)
        {
            Console.WriteLine("Enter the name of the horse: ");
            string horse = Console.ReadLine();
            if (horse.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            Console.WriteLine("Enter the age of the horse: ");
            string age_horse = Console.ReadLine();
            for (int i = 0; i < age_horse.Length; i++)
                if (!(age_horse[i] >= '0' && age_horse[i] <= '9'))
                {
                    Console.WriteLine("\nERROR");
                    return null;
                }
            if (age_horse.Length == 0)
            {
                Console.WriteLine("\nERROR");
                return null;
            }
            int horse_age = Convert.ToInt32(age_horse);
            return new Riding(imya, familiya, age, weight, height, gender, country, horse, horse_age);
        }


            static Human FindInfoHuman(int identifier)
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
            static Tuple<Sportsman, Volleyball, Gymnastics, Riding> FindInfoSportsman(int identifier)
            {    
                for (int i = 0; i < sportsmen.Count; i++)
                {
                    if (sportsmen[i].Item1.Id == identifier)
                    {
                        return sportsmen[i];
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
                                      "4. Add new Sportsman\n" +
                                      "5. Add new award\n"+
                                      "6. Find human\n" +
                                      "7. Add the type of the sport\n" +
                                      "8. Training of the sportsman\n" +
                                      "9. Change the team of the volleyball player\n" +
                                      "10. Change the equipment of the gymnast\n" +
                                      "11. Change the horse of the racer\n" +
                                      "12. Injuring of a sportsman\n" +
                                      "13. Healing of a sportsman\n" +
                                      "14. Competition of sportsmen\n" +
                                      "15. Exit.");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Human human;
                    switch (x)
                    {
                        case 1:
                            if (humans.Count == 0 && sportsmen.Count==0)
                            {
                                Console.WriteLine("There are no Humans in list");
                            }
                            else
                            {
                                Console.WriteLine("The full list:\n");
                                Console.WriteLine($"{humans.Count+sportsmen.Count}\n");
                                for (int i = 0; i < humans.Count; i++)
                                {
                                    humans[i].Write();
                                }
                                for (int i = 0; i < sportsmen.Count; i++)
                                {
                                    sportsmen[i].Item1.Write();
                                    if (sportsmen[i].Item2 != null) sportsmen[i].Item2.Write();
                                    if (sportsmen[i].Item3 != null) sportsmen[i].Item3.Write();
                                    if (sportsmen[i].Item4 != null) sportsmen[i].Item4.Write();
                                }
                            }
                            break;
                        case 2:
                            human = Read_Human(1);
                            if (human == null) Console.WriteLine("ERROR");
                            else humans.Add(human);
                            break;
                        case 3:
                            human = Read_Human(2);
                            if (human == null) Console.WriteLine("ERROR");
                            else humans.Add(human);
                            break;
                        case 4:
                            Tuple<Sportsman, Volleyball, Gymnastics, Riding> Hum; 
                            Hum = Read_Sportsman();
                            if (Hum == null) Console.WriteLine("ERROR");
                            else sportsmen.Add(Hum);
                            break;
                        case 5:
                            Console.WriteLine("Enter the Id of the sportsman: ");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            int f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item1.Id == ID)
                                {
                                    Console.WriteLine("Enter the award (gold/silver/bronze): ");
                                    string prize = Console.ReadLine();
                                    if (prize == "gold" || prize == "silver" || prize == "bronze") sportsmen[i].Item1.AddAward(prize);
                                    else Console.WriteLine("ERROR");
                                    f = 1;
                                }
                            }
                            if  (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 6:
                            Console.WriteLine("Enter the Id:");
                            int identifier = Convert.ToInt32(Console.ReadLine());
                            human = FindInfoHuman(identifier);
                            Tuple<Sportsman, Volleyball, Gymnastics, Riding> sportsman;
                            sportsman = FindInfoSportsman(identifier);
                            if (human == null && sportsman.Item1 == null) Console.WriteLine("Human not found!");
                            else
                            {
                                if (human != null) human.Write();
                                else
                                {
                                    sportsman.Item1.Write();
                                    if (sportsman.Item2 != null) sportsman.Item2.Write();
                                    if (sportsman.Item3 != null) sportsman.Item3.Write();
                                    if (sportsman.Item4 != null) sportsman.Item4.Write();
                                }
                            }
                            break;
                        case 7:
                            Console.WriteLine("Enter the Id of the sportsman: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the new type of sport(volleyball/gymnastics/riding): ");
                            string t = Console.ReadLine();
                            if ((t!="volleyball") && (t!="riding") && (t!="gymnastics"))
                            {
                                Console.WriteLine("ERROR");
                            }
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item1.Id == ID)
                                {
                                Sportsman a = sportsmen[i].Item1;
                                sportsmen[i].Item1[t] = t;
                                    if (t == "volleyball")
                                    {
                                        Volleyball q;
                                        q = ReadVolleyball(a.name, a.surname, a.age, a.weight, a.height, a.gender, a.country);
                                        sportsmen[i] = Tuple.Create(sportsmen[i].Item1, q, sportsmen[i].Item3, sportsmen[i].Item4);
                                    }
                                    if (t == "gymnastics")
                                    {
                                        Gymnastics q;
                                        q = ReadGymnastics(a.name, a.surname, a.age, a.weight, a.height, a.gender, a.country);
                                        sportsmen[i] = Tuple.Create(sportsmen[i].Item1, sportsmen[i].Item2, q, sportsmen[i].Item4);
                                    }
                                    if (t == "riding")
                                    {
                                        Riding q;
                                        q = ReadRiding(a.name, a.surname, a.age, a.weight, a.height, a.gender, a.country);
                                        sportsmen[i] = Tuple.Create(sportsmen[i].Item1, sportsmen[i].Item2, sportsmen[i].Item3, q);
                                    }
                                f = 1;
                                }
                            }
                            if (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 8:
                            Console.WriteLine("Enter the Id of the sportsman: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the difficulty of the training: ");
                            int diff = Convert.ToInt32(Console.ReadLine());
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item1.Id == ID)
                                {
                                    Sportsman a = sportsmen[i].Item1;
                                    sportsmen[i].Item1.Train(diff);
                                    sportsmen[i].Item1.PutStrength();
                                }
                            }
                            break;
                        case 9:
                            Console.WriteLine("Enter the Id of the volleyball player: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item2.Id == ID)
                                {
                                    sportsmen[i].Item2.Change();
                                    f = 1;
                                }
                            }
                            if (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 10:
                            Console.WriteLine("Enter the Id of the gymnast: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item3.Id == ID)
                                {
                                    sportsmen[i].Item3.Change();
                                    f = 1;
                                }
                            }
                            if (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 11:
                            Console.WriteLine("Enter the Id of the horse racer: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item4.Id == ID)
                                {
                                    sportsmen[i].Item4.Change();
                                    f = 1;
                                }
                            }
                            if (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 12:
                            Console.WriteLine("Enter the Id of the sportsman: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item1.Id == ID)
                                {
                                    sportsmen[i].Item1.Injury();
                                    f = 1;
                                }
                            }
                            if (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 13:
                            Console.WriteLine("Enter the Id of the sportsman: ");
                            ID = Convert.ToInt32(Console.ReadLine());
                            f = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item1.Id == ID)
                                {
                                    sportsmen[i].Item1.Heal();
                                    f = 1;
                                }
                            }
                            if (f == 0) Console.WriteLine("ERROR");
                            break;
                        case 14:
                            Console.WriteLine("Enter the Id of the first sportsman: ");
                            int ID1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Id of the second sportsman: ");
                            int ID2 = Convert.ToInt32(Console.ReadLine());
                            Sportsman q1=null, q2=null;
                            int f1, f2;
                            f1 = 0; f2 = 0;
                            for (int i = 0; i < sportsmen.Count; i++)
                            {
                                if (sportsmen[i].Item1.Id == ID1)
                                {
                                    q1=sportsmen[i].Item1;
                                    f1 = 1;
                                }
                                if (sportsmen[i].Item1.Id == ID2)
                                {
                                    q2 = sportsmen[i].Item1;
                                    f2 = 1;
                                }
                            }
                            if (f1 == 0 || f2 == 0) Console.WriteLine("ERROR");
                            else {
                                int a = q1.CompareTo(q2);
                                if (a == 0) Console.WriteLine("The strength of the sportsmen is equal.\n");
                                else if (a > 0) Console.WriteLine("The strength of first sportsman is higher.\n");
                                else Console.WriteLine("The strength of second sportsman is higher.\n");
                            }
                            break;
                    case 15:
                                return;
                }
                }
            }
        }
    }