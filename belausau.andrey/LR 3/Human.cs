using System;

namespace pudge
{
    class Human
    {
        //----------------Структура
        protected struct FIO
        {
            public string name, surname;
        }

        //----------------Поля
        protected int age;
        protected string _disease, _gender;
        protected bool _ill, _isDead;
        protected FIO fio;
        public static int birth_year;

        //----------------Конструкторы
        public Human()
        {
            age = 2020 - birth_year;
            _ill = false;
            _isDead = false;
        }

        public Human(string name, string surname) : this()
        {
            fio.name = name;
            fio.surname = surname;
        }

        public Human(string name, string surname, string gender) : this(name, surname)
        {
            //существует только два гендера
            if (gender == "male" || gender == "female")
                _gender = gender;
        }

        //----------------Свойства
        public string Name
        {
            get
            {
                return fio.name;
            }
            set
            {
                fio.name = value;
            }
        }

        public int Age
        {
            get
            {
                return 2020 - birth_year;
            }
        }

        public string Surname
        {
            get
            {
                return fio.surname;
            }
            set
            {
                fio.surname = value;
            }
        }

        public bool isDead
        {
            get
            {
                return _isDead;
            }
        }

        public string Disease
        {
            get
            {
                if (_ill) return _disease;
                return $"{fio.name} is not ill";
            }
            set
            {
                _ill = true;
                _disease = value;
            }
        }

        //Индексатор
        public string this[string choice]
        {
            get
            {
                switch (choice)
                {
                    case "name":return fio.name;
                    case "surname":return fio.surname;
                    default: return null;
                }
            }
            set
            {
                switch (choice)
                {
                    case "name":fio.name = value; break;
                    case "surname":fio.surname = value; break;
                }
            }
        }

        //----------------Методы
        public void ShowInfo()
        {
            Console.WriteLine($"name - {fio.name}");
            Console.WriteLine($"surname - {fio.surname}");
            Console.WriteLine($"gender - {_gender}");
            Console.WriteLine($"age - {age}");
            Console.WriteLine($"disease - {Disease}");
            if (_isDead)
                Console.WriteLine($"DEAD status - dead (use Die to resurrect)");
            else
                Console.WriteLine($"DEAD status - alive");
        }

        public void Die()
        {
            _isDead = true;
        }

        public void Resurrect()
        {
            _isDead = false;
        }

        public void ChangeGender()
        {
            _gender = (_gender == "male") ? "female" : "male";
        }

        public void Shout()
        {
            if (_isDead || _ill)
                Console.WriteLine($"{fio.name} is not currently possible for shouting. Create another object or resurrect.");
            else
                Console.WriteLine($"{fio.name} shouts : wanna pizza");
            Console.ReadKey();
        }

        //----------------Деструктор
        ~Human() { }
    }
}