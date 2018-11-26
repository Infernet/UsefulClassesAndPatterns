using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulClassesAndPatterns.Patterns.Strategy.Example
{
    class Car
    {
        protected int passengers; //пассажиры
        protected string model; //модель автомобиля
        public IMovable Movable {private get; set; }

        public Car(int num,string model,IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
