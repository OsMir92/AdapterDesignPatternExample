using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean objetos Pato y Pavo
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            //Se crea un Pavo disfrazado de Pato
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says: ");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says: ");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nThe Undercover Turkey says: ");
            testDuck(turkeyAdapter);
            Console.ReadKey();
        }

        private static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
