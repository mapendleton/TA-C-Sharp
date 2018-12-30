using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Chain
    {
        public Chain(string title) : this(title, 0)
        {
        }
        public Chain(string title,int year)
        {
            Title = title;
            Year = year;
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("The title: {0} and the year: {1}",Title,Year);
        }
    }
}
