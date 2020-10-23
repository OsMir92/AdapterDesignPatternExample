using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MallardDuck : IDuck
    {   //Se implementan las acciones de la interfaz para patos.
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
