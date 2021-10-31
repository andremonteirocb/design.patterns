using Fundamentos.Design.Patterns.Observer.Interfaces;
using System;

namespace Fundamentos.Design.Patterns.Observer
{
    public class Subscriber : IObserver
    {
        public string Name { get; private set; }
        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject)
        {
            Console.WriteLine($"Sou um usário comun e recebi a atualização do canal {(subject as YoutubeChannel).Name}.");
        }
    }
}
