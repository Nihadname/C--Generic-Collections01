using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Generic_Collections01.Domain.Models
{
    public abstract class product
    {

        private static int IdCounter;
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
public int TotalPrice { get; protected set;}
        public product(string name, int Price)
        {
            Id = IdCounter++;
            Name = name;
            price = Price;
            TotalPrice = 0;

        }

        public abstract void sell(int Amount);
        public abstract void ShowInfo();

    }
}
