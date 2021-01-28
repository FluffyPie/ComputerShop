using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class Cart
    {
        public List<Products> Products { get; private set; }
        public Cart() => Products = new List<Products>();
        public void Delete(int iter) => Products.RemoveAt(iter);
        public void Add(Products product) => Products.Add(product);
    }

    class User
    {
        public string Name { get; private set; }
        public int Money { get; private set; }
        public User(string name, int money)
        {
            Name = name;
            Money = money;
            Cart = new Cart();
        }

        public Cart Cart { get; set; }

    }
}
