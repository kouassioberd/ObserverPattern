using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class NewsAgency : ISubject
    {
        private List<IObserver> _observers = [];
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        { 
            _observers.Remove(observer);
        }
        public void NotifyObservers(string news)
        {
            foreach (var observer in _observers)
            {
                observer.Update(news);
            }
        }
    }
}
