using SkillTree.Observer.Models.Abstracts;
using System.Collections.Generic;

namespace SkillTree.Observer.Models.Concretes
{
    public class Observable : IObservable
    {
        private List<IObserver> _observers = new();
        private string _message;
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_message);
            }
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SendMessage(string message)
        {
            _message = message;
            Notify();
        }
    }
}