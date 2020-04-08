using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays

            int[] arrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Console.WriteLine(arrayOfInts[0]);
            // Console.WriteLine(arrayOfInts[1]);
            // Console.WriteLine(arrayOfInts[2]);
            // Console.WriteLine(arrayOfInts[3]);
            // Console.WriteLine(arrayOfInts[4]);
            // Console.WriteLine(arrayOfInts[5]);
            // Console.WriteLine(arrayOfInts[6]);
            // Console.WriteLine(arrayOfInts[7]);
            // Console.WriteLine(arrayOfInts[8]);
            // Console.WriteLine(arrayOfInts[9]);

            string[] arrayOfNames = { "Tim", "Martin", "Nikki", "Sara" };
            // Console.WriteLine(arrayOfNames[0]);
            // Console.WriteLine(arrayOfNames[1]);
            // Console.WriteLine(arrayOfNames[2]);
            // Console.WriteLine(arrayOfNames[3]);

            bool[] boolArray = new bool[10];
            bool odd = true;
            bool even = false;
            for (int idx = 0; idx < boolArray.Length; idx++)
            {
                if (idx % 2 == 0)
                {
                    Console.WriteLine(odd);
                }
                else
                {
                    Console.WriteLine(even);
                }
            }

            // List of Flavors

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Cookies 'n Creme");
            flavors.Add("Pistachio");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // User Info Dictionary

            Random rand = new Random();
            Dictionary<string, string> person = new Dictionary<string, string>();
            person.Add(arrayOfNames[0], flavors[0]);
            person.Add(arrayOfNames[1], flavors[1]);
            person.Add(arrayOfNames[2], flavors[2]);
            person.Add(arrayOfNames[3], flavors[3]);
            Console.WriteLine(arrayOfNames[0] + " likes " + person[arrayOfNames[0]]);
            Console.WriteLine(arrayOfNames[1] + " likes " + person[arrayOfNames[1]]);
            Console.WriteLine(arrayOfNames[2] + " likes " + person[arrayOfNames[2]]);
            Console.WriteLine(arrayOfNames[3] + " likes " + person[arrayOfNames[3]]);

        }
    }
}
