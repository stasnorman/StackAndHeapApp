using StackAndHeapApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            

            Console.WriteLine(pr.ConvertDataToDegree(8));
            Car car1 = new Car();
            Console.WriteLine(car1.Fuel);

            Console.ReadKey();
        }

        /// <summary>
        /// STACK
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public double ConvertDataToDegree(int degree)
        {
            Car car = new Car();
            car.Fuel = 10;
            Console.WriteLine(car.Fuel);

            return Math.Pow(2, degree);
        }



        
    }
}
