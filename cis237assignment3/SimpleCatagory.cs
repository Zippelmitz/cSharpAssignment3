using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class SimpleCatagory
    {
        string _name;// >Name of the catagory.
        decimal _price;// >Price of the catagory.

        // >Properties
        //
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }


        // >Constructors
        //
        public SimpleCatagory(string catagoryName, decimal catagoryPrice)
        {
            _name = catagoryName;
            _price = catagoryPrice;
        }
    }
}
