using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IDuck
    {   //Se crea la interfaz que da a los patos sus acciones.
        void Quack();
        void Fly();
    }
}
