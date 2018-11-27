using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Observer.Example
{
    class Bank : IObserver
    {
        public string Name { get; set; }
        private IObservable stock;
        public Bank(string name,IObservable observable)
        {
            this.Name = name;
            this.stock = observable;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo sInfo = (StockInfo)obj;
            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро; Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро; Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}
