using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeapApp.Models
{
    public class Car
    {
        public double Fuel { get; set; }
        
        public Car CreateCar(double fuel)
        {
            Car car = new Car(); // ссылка на класс Car
            car.Fuel = fuel; // Обращаемся к полю класса
            return car;
        }
}
}
