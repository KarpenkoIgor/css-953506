using System;

namespace Lab3Ind1
{
    //TODO:

    class Transport
    {
        //fields
        private double Fuel = 0;
        private string Type;
        private string Mark;
        private uint   YearMade;
        private uint   Capacity;
        private uint   Power;
        private uint   MaxSpeed;
        private int    CurrentSpeed = 0;



        //constructors
        public Transport(string transType, string transMark, uint year, uint transCapacity, uint transPower, uint transMax)
        {
            Type = transType;
            Mark = transMark;
            YearMade = year;
            Capacity = transCapacity;
            Power = transPower;
            MaxSpeed = transMax;
        }

        public Transport()
        {
            Type = "NULL";
            Mark = "NULL";
            YearMade = 0;
            Power = 0;
            MaxSpeed = 0;
            CurrentSpeed = 0;
        }

        //destructor
        ~Transport()
        {
            Console.WriteLine("PEPEG!!!");
        }


        
        //properties
        public string type
        {
            get
            { return Type; }
            set
            { Type = value; }
        }

        public string mark
        {
            get { return Mark; }
            set { Mark = value; }
        }

        public uint year
        {
            get { return YearMade; }
            set
            {
                if (value <= 2020)
                    YearMade = value;
                else
                    Console.WriteLine("Error. The year must be less than 2021.");
            }
        }

        public uint capacity
        {
            get { return Capacity; }
            set { Capacity = value; }
        }

        public uint power
        {
            get { return Power; }
            set { Power = value; }
        }

        public double fuel
        {
            get { return Fuel; }
        }

        public uint maxspeed
        {
            get { return MaxSpeed; }
            set { MaxSpeed = value; }
        }

        public int currentspeed
        {
            get { return CurrentSpeed; }
            set
            {
                if (CurrentSpeed + value < MaxSpeed)
                    CurrentSpeed = value;
                else
                    Console.WriteLine("Error. You can't speed up so much.");
            }
        }



        //Methods
        public void Beep()
        {
            Console.WriteLine("BEEP!\a");
        }

        public void Refuel(uint amount)
        {
            if (Fuel + amount <= Capacity)
                Fuel += amount;
            else
                Console.WriteLine("Error. The amount of fuel you'd like to add is above the transport's capacity.");
        }

        public double Calculate(int position)
        {
            return Fuel / position * 100;
        }

        public int Move(int position)
        {
            int total = 0;
            double cost = Calculate(position);
            double temporary = Math.Abs(Fuel - cost);

            if (Fuel < cost)
            {
                if (Fuel < temporary)
                {
                    Console.WriteLine("Error. You don't have enough fuel. You aren't able to move.");
                    return 0;
                }

                while (Fuel > 0)
                {
                    Fuel -= temporary;
                    total += CurrentSpeed;
                }

                Console.WriteLine($"Error. You don't have enough fuel. You'll be able to move only for: {total} units.");
                return total;
            }

            else
            {
                while (cost > 0)
                {
                    cost -= temporary;
                    total += CurrentSpeed;
                }
                return total;
            }

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine($"Year of production: {YearMade}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Fuel: {Fuel}");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Maximum speed: {MaxSpeed}");
            Console.WriteLine($"Current speed: {CurrentSpeed}");
        }
    }
}
