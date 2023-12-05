// See https://aka.ms/new-console-template for more information
using C__Generic_Collections01.Domain.Models;

Console.WriteLine("Hello, World!");
Book book = new("The Great Gatsb", 12, "Scott Fitzgerald ", 45);
book.count = 4;
book.sell(7);
book.ShowInfo();