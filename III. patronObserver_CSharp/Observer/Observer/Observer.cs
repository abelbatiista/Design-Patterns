using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Observer : IObserver
    {
        private string name;
        private Subject subject;

        public Observer(string _name, Subject _subject)
        {
            name = _name;
            subject = _subject;
            subject.Subscribe(this);
        }

        public void UpdatePush(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Push, {name}-{message}");
        }

        public void UpdatePull()
        {
            int number = subject.Variable;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Pull, {name}-{number}");
        }
    }
}
