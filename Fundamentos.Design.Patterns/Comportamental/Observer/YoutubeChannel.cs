using Fundamentos.Design.Patterns.Observer.Interfaces;
using System.Collections.Generic;

namespace Fundamentos.Design.Patterns.Observer
{
    public class YoutubeChannel : ISubject
    {
        readonly List<IObserver> observers;
        public string Name { get; private set; }
        public YoutubeChannel(string name)
        {
            observers = new List<IObserver>();
            Name = name;
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(o => o.Update(this));
        }

        public void ChangeName(string newName)
        {
            Name = newName;

            Notify();
        }
    }
}
