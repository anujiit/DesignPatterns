using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class BasePizza : IPizza
    {
        public int getCost()
        {
            return 100;
        }
    }
}
