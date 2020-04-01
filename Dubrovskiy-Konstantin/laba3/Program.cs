using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            //----------- класс ЧЕЛОВЕК -> РАБОТНИК -> работники разных специальностей ----------------------

            Worker worker1 = new Worker();           
            worker1.Filling("Ivanov Ivan", 25, "manager", 8);   //полный метод
            double pay = worker1.Payroll(); //можно получить если поставить public в методе класса
            Console.WriteLine($"{pay.ToString()}");
            worker1.PrintInfo();

            Console.WriteLine();
            
            Worker worker2 = new Worker();
            worker2.Filling("waiter", 2);   //Сокращенный перегруженный метод
            worker2.PrintInfo();

            Console.WriteLine();

            Worker worker3 = new Worker();
            worker3.Filling("dishwasher", 0);   // Сокращенный перегруженный метод
            worker3.Name = "Petrov Petr";   // + свойства
            worker3.Age = 12;
            Console.WriteLine("Имя: {0}", worker3.Name);
            worker3.PrintInfo();

            Console.WriteLine();
            Console.WriteLine("Всего работников: {0}", Worker.Counter.ToString());


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
