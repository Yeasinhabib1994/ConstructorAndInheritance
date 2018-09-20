using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("xyz123");
        }
    }

    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle  is being initialized. {0}", _registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber)
           : base(registrationNumber) // registrationNumber is passed to the base vehicle class to initialize base class.
        {
            Console.WriteLine("car is being initialized. {0}", registrationNumber);
        }
    }
}
