﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class WildTurkey : ITurkey
    {   //Se implementan las acciones de la interfaz para pavos.
        public void Fly()
        {
            Console.WriteLine("I'm Flying a small distance.");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble!");
        }
    }
}
