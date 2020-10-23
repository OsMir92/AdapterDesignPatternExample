using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
