using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classified ad1 = new Classified("Used Cars", 50);
            Classified ad2 = new Classified("Real Estate", 100);
            Console.WriteLine("Category of first ad: " + ad1.getCategory());
            Console.WriteLine();

            // Update the number of words for the second object
            ad2.setNumberWords(120);

            // Use the display method to display the values of the fields for each object
            ad1.DisplayAd();
            ad2.DisplayAd();

            Console.ReadLine();


        }
    }
}
