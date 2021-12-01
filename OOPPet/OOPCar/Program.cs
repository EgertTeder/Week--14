using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string name;
            string modelname;
            string registration = "123456";
            string color;
            int odometer;
            int fueltank;

            public Car(string _anme, string _modelname, string _registration, string _color)
            {
                mark = _mark;
                model = _model;
                regnumber = _regNumber;
                color = _color;
                odom = 0;
                fueltank = 68;
                Console.WriteLine($"{mark} {model} {registration} has been created");
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", "123456", "Blaxk");
        }
    }
}
