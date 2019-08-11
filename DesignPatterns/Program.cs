using DesignPatterns.DecoratorPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new CheesePizza(new CapsicumPizza(new BasePizza()));
            Console.WriteLine(pizza.getCost());
        }
    }
}
