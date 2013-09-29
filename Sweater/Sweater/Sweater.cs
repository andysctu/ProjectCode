using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweater
{
    public class Sweater
    {
        //Declare 5 private fields for object Sweater
        private string _style, _colours;
        private int _size;
        private double _price;
        private bool _isInStock;
                
        //Constructor that takes 5 arguments of types declared above                   
        public Sweater(string style, string colours, int size, double price, bool isInStock)
        {
            _style = style;
            _colours = colours;
            _size = size;
            _price = price;
            _isInStock = isInStock;
        }

        //Method that displays all 5 fields of a sweater object, right aligned at 12 characters
        public void DisplayToConsole()
        {
            Console.WriteLine(String.Format("{0,12}: {1}", "Style", _style));
            Console.WriteLine(String.Format("{0,12}: {1}", "Colours", _colours));
            Console.WriteLine(String.Format("{0,12}: {1}", "Size", _size));
            Console.WriteLine(String.Format("{0,12}: {1:F2}", "Price", _price));
            Console.WriteLine(String.Format("{0,12}: {1}", "In Stock", _isInStock));
            Console.WriteLine();
        }
    }
}
