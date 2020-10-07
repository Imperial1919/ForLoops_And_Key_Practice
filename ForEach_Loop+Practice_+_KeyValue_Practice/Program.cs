using System;

namespace ForEach_Loop_Practice___KeyValue_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] websites = new string[5]
            { "Google", "Youtube", "Facebook", "Baidu", "Yahoo!" };
            Console.WriteLine("Popular Websites..");

            int rank = 1;
            // site stores the elements of the websites list.
            foreach(string site in websites)
            {
                Console.WriteLine("Position: " + rank + "\t" + site);
                rank++;
            }

            Console.WriteLine("\n");

            string[] bestcandy = new string[6]
                {"Skittles","Butterfingers", "Starbursts", "M&M's caramel", "Hershey's Chocolate Bar", "Lemon Heads"};


            int rankings = 1;
            foreach(string candy in bestcandy)
            {
                Console.WriteLine("position: " + rankings + "\t" + candy);
                rankings++;
       
            }
            Console.ReadKey();
        }
    }
}
