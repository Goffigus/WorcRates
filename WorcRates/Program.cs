using System;
using static System.Console;

namespace WorcRates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 65, 18, 4, 0 }; //different age rates 65+, 18 to 64, 4 to 17, 0 to 3
            string[] ageRange = { "Seniors 65+", "Adults", "Spawnlings 4 to 17", "infants" };
            double[] rates = { 14, 18, 8, 0 };

            WriteLine("Enter age:");
            int custAge = Convert.ToInt32(ReadLine());
            int find = 0; // used to get position from array
            double totalCost = 0;
            int familySize = 0;

            while (custAge >= 0)
            {
                

                for (int w = 0; w < ages.Length; ++w)
                {
                    if (custAge >= ages[w])
                    {
                        find = w; //get the position of the age rate from the array
                        w = ages.Length; // exit loop
                    }
                }

                totalCost += rates[find];
                familySize++;

                WriteLine("Enter age:");
                custAge = Convert.ToInt32(ReadLine());
            }
            
            

            WriteLine("Family of {0} is going to cost {1:C}", familySize, totalCost);

        }
    }
}
