using System;

namespace Book_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = Convert.ToInt32(Console.ReadLine());

            Book[] kitab = new Book[lenght];
            for (int i = 0; i < kitab.Length; i++)
            {
                Console.Write("Name:");
                string Name = Console.ReadLine();

                Console.Write("No:");
                int No = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price:");
                int Price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Genre:");
                string Genre = Console.ReadLine();
                kitab[i] = new Book(Name,No ,Price, Genre);


            }
            Console.WriteLine("1.Filter");
            Console.WriteLine("2.Patron of books");
            Console.WriteLine("0.Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    int minPrice = Convert.ToInt32(Console.ReadLine());
                    int maxPrice = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < minPrice; i++)
                    {
                        if (kitab[i].Price > minPrice && kitab[i].Price <= maxPrice )
                        {
                            Console.WriteLine(kitab[i].Name);
                            Console.WriteLine(kitab[i].No);
                            Console.WriteLine(kitab[i].Price);
                            Console.WriteLine(kitab[i].Genre);
                        }

                    }
                    break;

                case 2:

                    for (int i = 0; i < kitab.Length; i++)
                    {

                        {
                            Console.WriteLine(kitab[i].Name);
                            Console.WriteLine(kitab[i].No);
                            Console.WriteLine(kitab[i].Price);
                            Console.WriteLine(kitab[i].Genre);

                        }

                    }
                    break;

            }

        }
    }
}
