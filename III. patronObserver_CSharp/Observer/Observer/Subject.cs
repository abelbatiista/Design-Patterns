using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string message;
        private Random random = new Random();
        public int Variable { get; set; }

        public void Subscribe(IObserver subcribed)
        {
            observers.Add(subcribed);
        }

        public void Unsubscribe(IObserver unsubscribed)
        {
            observers.Remove(unsubscribed);
        }

        private void Notify()
        {
            foreach(IObserver obs in observers)
            {
                obs.UpdatePush(message);
            }
        }

        public void Work()
        {
            Variable = random.Next(10);

            if(Variable%2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--Valid new state--");
                message = string.Format($"The new value is {Variable}");
                Notify();
            }
        }

    }
}
