using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public class CapsicumPizza : DecoratorPizza
    {
        public CapsicumPizza(IPizza pizza) : base(pizza)
        {
        }

        public override int getCost()
        {
            return base.getCost() + 50;
        }
    }
}
