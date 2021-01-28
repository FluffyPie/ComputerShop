using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Code { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }

    class Videocards : Products
    {
        public string Retailer { get; private set; }
        public Videocards(string name, int price, int code, string retailer)
        {
            Name = name;
            Price = price;
            Code = code;
            Retailer = retailer;
        }

    }
    class Processors: Products
    {
        public string Genere { get; private set; }
        public Processors(string name, int price, int code, string genere)
        {
            Name = name;
            Price = price;
            Code = code;
            Genere = genere;
        }

    }
}
