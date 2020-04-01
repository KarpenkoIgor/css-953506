using System;
using static System.Console;

namespace _3
{
    class Vehicle
    {
        public string name ;
        public int year;
        public string model;
        public string number;
        public string color;
        public Vehicle() { name = "Peugeot"; year = 2015; model = "308"; number = "MR-2389"; color = "Black";  }
        public string GetName()
        {
            Write("Car:");
            name = ReadLine();
            return name;
        }
        public string GetName(string a)
        {
            Write("\n");
            return a;
        }
        public int GetYear()
        {
            Write("Year of release:");
            year = Convert.ToInt32(ReadLine());
            return year;
        }
        public string GetNumber()
        {
            Write("Number:");
            number = ReadLine();
            return number;
        }
        public string GetColor()
        {
            Write("Color:");
            color = ReadLine();
            return color;
        }
        public string GetModel()
        {
            Write("Model:");
            model = ReadLine();
            return model;
        }
        public void Info()
        {
            WriteLine($"Name: {name}| Year of release: {year}| The number of the car: {number}| Model:{model}| Color:{color}");
        }
    }
    class Autopark : Vehicle
    {
        Vehicle[] Park;
        public Autopark(int count) 
        {
            Park = new Vehicle[count];
        }
        public Vehicle this[int index]
        {
            get
            {
                return Park[index];
            }
            set
            {
                Park[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle();
            WriteLine("My car:");
            mycar.Info();
            int count;
            WriteLine("How many cars do you want to add?");
            count = Convert.ToInt32(ReadLine());
            Autopark car = new Autopark(count);
            for(int i = 0; i < count; i++)
            {
                WriteLine($"Car number :{i+1}");
                car[i] = new Vehicle { };
                car.name = car.GetName();
                car.name = car.GetName("");
                car.year = car.GetYear();
                car.model = car.GetModel();
                car.number = car.GetNumber();
                car.color = car.GetColor();
                car.Info();
            }
            ReadKey();
        }
    }
}
