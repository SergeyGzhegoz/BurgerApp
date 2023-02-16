using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp
{
    public class Burger
    {
        public string TypeOfMeet { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public Burger(string typeofmeet, int count, int price)
        {
            TypeOfMeet = typeofmeet;
            Count = count;
            Price = price;
        }
    }
}
