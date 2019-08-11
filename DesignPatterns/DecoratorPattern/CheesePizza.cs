using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class CheesePizza : DecoratorPizza
    {
        public CheesePizza(IPizza pizza) : base(pizza)
        {
        }

        public override int getCost()
        {
            return base.getCost() + 30;
        }
    }
}
