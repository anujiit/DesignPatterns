using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorPizza : IPizza
    {
        protected IPizza pizza;

        public DecoratorPizza(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual int getCost()
        {
            return pizza.getCost();
        }
    }
}
