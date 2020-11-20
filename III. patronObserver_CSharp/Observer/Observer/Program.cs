using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear el sujeto
            Subject subject = new Subject();

            //Crear observadores
            Observer observer1 = new Observer("Observer1", subject);
            Observer observer2 = new Observer("Observer2", subject);
            Observer observer3 = new Observer("Observer3", subject);

            //Implementaciones
            for (int k = 0; k < 5; k++)
            {
                subject.Work();
            }
        }
    }
}
