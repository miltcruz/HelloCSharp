using System;

namespace HelloCSharp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Order order = new Order(1, "John Doe", 100.00);
        order.ApplyDiscount(10);
        order.PrintSummary();
    }
}   