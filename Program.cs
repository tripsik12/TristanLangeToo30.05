using LINQAvarage;
using System.ComponentModel.Design;

namespace TristanLangeTöö30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //switchiga kutsuda esile average meetod
            Console.WriteLine("Tee valik numbritega");
            Console.WriteLine("1. Count LINQ");
            Console.WriteLine("2. Sum LINQ");
            Console.WriteLine("3. Pyramiid");
            string choice = Console.ReadLine();

            switch (choice)
            {  
                case "1":
                    CountLINQ();
                    break;

                case "2":
                    SumLINQ();
                    break;
                case "3":
                    Pyramiid();
                    break;
            }
        }
        public static void CountLINQ()
        {
            var totalPersons = PeopleList.people.Count();

            Console.WriteLine("Inimesi on kokku: " + totalPersons);

            var adultPerson = PeopleList.people.Count(x => x.Age >= 18);

            Console.WriteLine("Täisealisi inimesi on: " + adultPerson);
        }


        public static void SumLINQ()
        {
            //start
            var sumAge = PeopleList.people.Sum(x => x.Age);

            Console.WriteLine(sumAge);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Täisealiste isikute koondarv");

            var sumAdults = 0;

            var numAdults = PeopleList.people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {

                    return 0;
                }
            });

            Console.WriteLine("T'iskasvanud isikute koondarv " + numAdults);    
        }
        public static void FileWrite()
        {
            try
            {
                using (StreamWriter kirjuta = new StreamWriter("C:/Users/opilane/Desktop/text.txt", true))
                {
                    if (kirjuta != null)
                    {
                        Console.WriteLine("Kirjuta");
                        string input = Console.ReadLine();
                        if (input != null && input !="")
                        {
                            kirjuta.WriteLine(input);
                            Console.WriteLine("Sa sisestasid teksti '" + input + "'faili 'text.txt'");
                        }
                        else
                        {
                            Console.WriteLine("Ei sisestanud teksti");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Fail 'text.txt' on null");
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Mingi error");
                Console.WriteLine(e.Message);
            }
            }

            public static void Pyramiid()
            {
                int i, j, rows;
                int num = 0;
                Console.WriteLine("Numbri püramiid");
                Console.WriteLine("Sisesta ridade arv");

                rows = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i <= rows; i++) 
                { 
                    for (j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= i - 1; j++)
                    {
                        Console.Write("{0} ", num++);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }

