using System;

namespace Lab3Ind1
{
    //TODO: 
    //1. Add indexers.
    //2. Add methods involving speed and fuel changes.
    //3. Make a menu in Program.cs involving initialization and moving of transport.

    
    class Transport
    {
        //fields
        private string Type;
        private string Mark;
        private uint   YearMade;
        private uint   Capacity;
        private uint   Fuel = 0;
        private uint   Power;
        private uint   Consumption;
        private uint   MaxSpeed;
        private int    CurrentSpeed;



        //constructors
        public Transport(string transType, string transMark, uint year, uint transCapacity, uint transPower, uint transConsumption, uint transMax, int transCurrent)
        {
            Type = transType;
            Mark = transMark;
            YearMade = year;
            Capacity = transCapacity;
            Power = transPower;
            Consumption = transConsumption;
            MaxSpeed = transMax;
            CurrentSpeed = transCurrent;
        }

        public Transport()
        {
            Type = "NULL";
            Mark = "NULL";
            YearMade = 0;
            Power = 0;
            Consumption = 0;
            MaxSpeed = 0;
            CurrentSpeed = 0;
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

        public uint fuel
        {
            get { return Fuel; }
        }

        public uint consumption
        {
            get { return Consumption; }
            set
            {
                if (value <= Capacity)
                    Consumption = value;
                else
                    Console.WriteLine("Error. The transport's consumption is higher than it's capacity.");
            }
        }

        public uint maxspeed
        {
            get { return MaxSpeed; }
            set { MaxSpeed = value; }
        }

        public int currentspeed
        {
            get { return CurrentSpeed; }
        }



        //Methods
        public void Beep()
        {
            Console.WriteLine("BEEP!\a");
        }
    }
}
