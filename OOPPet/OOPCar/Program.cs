using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fueltank;

            public Car(string _anme, string _modelname, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regnumber = _regNumber;
                color = _color;
                odom = 0;
                fueltank = 68;
                Console.WriteLine($"{mark} {model} {regNumber} has been created.");
            }

            public int FuelTank
            {
                get { return fueltank; }
            }

            public void Drive()
            {
                fueltank -= 5;
                odo += 100;
                Console.WriteLine("Vroom-vroom");
            }

            public void ShowCarData()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Registration number: {regNumber}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odometer: {odo}");
                Console.WriteLine($"Fuel: {fueltank}");
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", "123456", "Black");

            while(myCar.FuelTank > 0)
            {
                myCar.Drive();
            }

            myCar.ShowCarData();
        }
    }
}
