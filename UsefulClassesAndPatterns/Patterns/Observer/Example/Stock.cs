using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Observer.Example
{
    class Stock : IObservable
    {
        private StockInfo sInfo;
        private List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            sInfo = new StockInfo();
        }

        public void NotifyObservers()
        {
            foreach (IObserver item in observers)
                item.Update(sInfo);
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Market()
        {
            Random random = new Random();
            sInfo.USD = random.Next(20, 40);
            sInfo.Euro = random.Next(30, 50);
            NotifyObservers();
        }
    }
}
