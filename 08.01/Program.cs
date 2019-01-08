using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeighbors = new List<Neighbor>();
            floorNeighbors.Add(new Neighbor() { FullName = "Pupkin", FlatNumber = 33, PhoneNumbers = 2221020 });
            floorNeighbors.Add(new Neighbor() { FullName = "Ivanov", FlatNumber = 34, PhoneNumbers = 2222020 });
            floorNeighbors.Add(new Neighbor() { FullName = "Sidorov", FlatNumber = 35, PhoneNumbers = 2225247 });
            floorNeighbors.Add(new Neighbor() { FullName = "Petrov", FlatNumber = 36, PhoneNumbers = 2857984 });
            floorNeighbors.Add(new Neighbor() { FullName = "Sobolev", FlatNumber = 37, PhoneNumbers = 3587698 });

            Console.WriteLine("Add number flat: ");

            var number = Convert.ToInt32(Console.ReadLine());

            foreach (Neighbor flats in floorNeighbors)
            {
                switch (number)
                {
                    case 33:
                        Console.WriteLine($"FullName =Pupkin, PhoneNumbers = 2221020");
                        break;
                    case 34:
                        Console.WriteLine($"FullName =Ivanov, PhoneNumbers = 2222020");
                        break;

                    case 35:
                        Console.WriteLine($"FullName =Sidorov, PhoneNumbers = 2225247");
                        break;

                    case 36:
                        Console.WriteLine($"FullName =Petrov, PhoneNumbers = 2857984");
                        break;

                    case 37:
                        Console.WriteLine($"FullName =Sobolev, PhoneNumbers = 3587698");
                        break;
                    default:
                        Console.WriteLine("Your's number isn't correct");
                        break;
                }
                break;
            }
            Console.ReadKey();
        }
    }

    class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public int PhoneNumbers { get; set; }
    }
}
