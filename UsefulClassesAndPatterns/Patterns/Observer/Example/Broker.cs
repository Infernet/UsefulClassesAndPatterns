using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Observer.Example
{
    class Broker : IObserver
    {
        public string Name { get; set; }
        private IObservable stock;
        public Broker(string name,IObservable observable)
        {
            this.Name = name;
            this.stock = observable;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo sInfo = (StockInfo)obj;
            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары; Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары; Курс доллара: {1}", this.Name, sInfo.USD);
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
