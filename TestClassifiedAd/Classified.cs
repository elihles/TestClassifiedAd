using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    internal class Classified
    {
        private string Category;
        private int  NumberWords;
        private double price;

        public Classified(string category, int numberWords)
        {
            Category = category;
            NumberWords = numberWords;
            CalculatePrice();
        }
        public string getCategory()
        {
            return Category;
        }

        public void setCategory(string category)
        {
            this.Category = category;
        }
        public int getNumberWords()
        {
            return NumberWords;
           
        }
        public void setNumberWords(int numberWords)
        {
             this.NumberWords = numberWords;
            CalculatePrice();
        }
        public void CalculatePrice()
        {
            price = NumberWords * 0.09;
        }
      
        public void DisplayAd()
        {
            Console.WriteLine("Classified Ad:");
            Console.WriteLine("Category   :{0} ",Category);
            Console.WriteLine("Number of words :{0}",NumberWords);
            Console.WriteLine("Price     :{0:C}",price);
            Console.WriteLine();
        }

    }
}
