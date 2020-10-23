using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{   //Se implementa la interface para Patos (La interfaz que el cliente espera ver) a los Pavos.
    class TurkeyAdapter : IDuck
    {
        ITurkey turkey;
        //Se crea una referencia al objeto que estamos adaptando, esto por medio de un constructor.
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }
        //Ahora implementamos los metodos de la interface para Patos.
        public void Quack()
        {
            turkey.Gobble();
        }
        /*Para traducir los metodos de la interfaz de patos a los de pavos, se llama a los metodos de 
        Pavo tanto en Quack y en Fly utilizando el constructor como referencia.
        
        El Pavo disfrazado aun dice Gobble Gobble y a su vez debe volar varias veces para recorrer la
        misma distancia que vuela un pato a la vez.*/
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}
