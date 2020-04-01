using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Person
    {        
        protected string name;    // Имя
        protected int age;    // Возраст       

        // Реализация свойств класса:
        public string Name { set; get; }  
        //{
        //    set
        //    {
        //        name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}

        public int Age  
        {
            set
            {
                if (value < 18) Console.WriteLine("Возраст {0} не подходит. Возраст должен быть больше 18 лет", value);
                else age = value;
            }
            get
            {
                return age;
            }
        }       
    }

    public class Worker : Person
    {
        protected string speciality;  // Специальность
        protected int experience;     // Опыт работы (лет)
        protected int salary;         // Базовая з/п (без учета опыта)

        //Реализация статических св-в класса (в данном примере подсчет количества созданных экземпляров Worker)
        protected static int counter = 0;
        public Worker()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
        


        public void Filling(string name, int age, string speciality, int experience)    // полное заполнение 
        {
            this.name = name;
            this.age = age;
            this.speciality = speciality;
            this.experience = experience;
        }

        public void Filling(string speciality, int experience)  // перегруженный метод для сокр. заполнения
        {            
            this.speciality = speciality;
            this.experience = experience;
        }

        public double Payroll()
        {
            if (speciality == "dishwasher") salary = 80;        //
            else if (speciality == "waiter") salary = 100;      //  Базовая з/п различных специальностей
            else if (speciality == "cook") salary = 150;        //
            else if (speciality == "manager") salary = 200;     //
            else salary = 0;    // В иных случаях

            double coefficient = 1 + (0.2 * experience);  // Расчет коэффициента з/п согласно опыту
            return coefficient * salary;    // Возвращаем значение з/п
        }

        public void PrintInfo()
        {
            double pay = Payroll();

            if (name != null && age != 0) Console.WriteLine("Имя: {0}  \t Возраст: {1} \t", name, age.ToString());            
            Console.WriteLine("Специальность: {0} \t Базовая з/п: {1} \t Опыт: {2}", speciality, salary.ToString(), experience.ToString());            
            Console.WriteLine("З/п с учетом опыта: {0}", pay.ToString());
        }
    }
}
