using System;
using System.Collections.Generic;

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
                Console.WriteLine("position: " + rankings + "\t" + candy + "\n");
                rankings++;
       
            }
           


            // Start of key code portion of lesson


            Dictionary <string, string> Booklist = 
                new Dictionary<string, string>();
            Booklist.Add("Stuart Yarnold", " Arduino ");
            Booklist.Add("Nick Vandome", "Windows 10");
            Booklist.Add("Mike Mcgrath", "Java");

            Console.WriteLine("Popular Titles:");
            // This is saying for each KeyValuePair including the parameters of 'string' and 'string', to store them in a body called book, taking info to  fill book from Booklist//
            foreach(KeyValuePair<string, string> book in Booklist)
            {
                Console.WriteLine("\tValue: " + book.Value + "In easy steps");
            }
       


            Dictionary<string, string> CarList =
                new Dictionary<string, string>();
            CarList.Add("1957 Chevy", "Bel-Air Convertible");
            CarList.Add("1949 Mercury", "Sedan");

            foreach (KeyValuePair<string, string> car in CarList)
            {
                Console.WriteLine("\tWe have a " + car.Key + " " + car.Value);
            }
            Console.ReadKey();
        }
    }
}
