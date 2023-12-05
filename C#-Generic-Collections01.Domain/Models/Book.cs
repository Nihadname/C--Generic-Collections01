using C__Generic_Collections01.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Generic_Collections01.Domain.Models
{
    public class Book:product
    {
        public Book(string name, int Price,string authorName,int pageCount) : base(name, Price)
        {
            AuthorName = authorName;
               PageCount=pageCount;
        }

        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public override void sell(int Amount)
        {
            if (count >=Amount)
            {
                count -= Amount;
                TotalPrice += Amount * price;
                Console.WriteLine($"Qazanc ne qederdir {TotalPrice} satilan sayi {Amount}");
            }
            else
            {
                Console.WriteLine(ProductCountIsZeroException.productCountIsZeroException);
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {count} {price} {TotalPrice} {AuthorName} {PageCount}");
        }
    }
}
