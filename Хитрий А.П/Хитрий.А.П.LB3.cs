using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

class Human
{
    private readonly int ID;
    private static int Number = 1843650;
    private string name;
    private int age;
    private int high;
    private float weight;
    private DateTime birthdate;
    private string[] parent = new string [2];
    public Human()
    {
        ID = Number + 1;
        ++Number;
        name = "";
        age = 0;
        high = 0;
        weight = 0;
        birthdate = new DateTime(1900, 1, 1);
    }

    public Human(string name, int age, int high, float weight, DateTime birthdate,string parent0,string parent1)
    {
        ID = Number + 1;
        ++Number;
        this.name = name;
        this.age = age;
        this.high = high;
        this.weight = weight;
        this.birthdate = birthdate;
        parent[0] = parent0;
        parent[1] = parent1;
    }

    public int I_D
    {
        get => ID;
    }
    public string Name
    {
        get => name;
        set => name = value;
    }
    public int Age
    {
        get => age;
        set => age = value;
    }
    public int High
    {
        get => high;
        set => high = value;
    }
    public float Weight
    {
        get => weight;
        set => weight = value;
    }
    public DateTime Birthdate
    {
        get => birthdate;
        set => birthdate = value;
    }

    public string this[int index]
    {
        get => parent[index];
        set => parent[index] = value;
    }

    public void cout()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(high); 
        Console.WriteLine(weight);
        Console.WriteLine(birthdate);
        Console.WriteLine(parent[0]);
        Console.WriteLine(parent[1]);
    }

    public void date()
    {
        try
        {
            int day = int.Parse(ReadLine());
            int month = int.Parse(ReadLine());
            int year = int.Parse(ReadLine());
            DateTime z = new DateTime(year, month, day);
            birthdate = z;

        }
        catch(FormatException e)
        {
            MessageBox.Show(e.Message);
        }
    }

    ~Human()
    { }
}

    class Program
    {
    static Human Creat()
    {
        try
        {
            WriteLine("Введите имя");
            string name = ReadLine();
            WriteLine("Введите возраст");
            int age = int.Parse(ReadLine());
            WriteLine("Введите рост(см)");
            int high = int.Parse(ReadLine());
            WriteLine("Введите массу(кг)");
            int weight = int.Parse(ReadLine());
            WriteLine("Введите день рождения(день)");
            int day = int.Parse(ReadLine());
            WriteLine("Введите день рождения(месяц)");
            int month = int.Parse(ReadLine());
            WriteLine("Введите день рождения(год)");
            int year = int.Parse(ReadLine());
            DateTime birthdate = new DateTime(year, month, day);
            WriteLine("Введите имя папы");
            string parent0 = ReadLine();
            WriteLine("Введите имя мамы");
            string parent1 = ReadLine();
            Human you = new Human(name, age, high, weight, birthdate, parent0, parent1);
            return you;
        }
        catch (FormatException e)
        {
            MessageBox.Show(e.Message);
            Creat();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Creat();
        }
        return null;
    }
    static void Main(string[] args)
        {
        ConsoleKeyInfo key;
        WriteLine("Хотите сначала ввести данные? 1 - да,0 - нет");
        bool b = true;
        Human you = new Human() ;
        while (b == true)
        {
            key = ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D0:
                    {
                        you = new Human();
                        b = false;
                        break;
                    }
                case ConsoleKey.D1:
                    {
                       you = Creat();
                        b = false;
                        break;
                    }
            }
        }
        b = true;
        while (b == true)
        {
            Clear();
            b = true;
            WriteLine("0 - завершить работу, 1 - вывести класс, 2 - вывести построчно, 3 - изменить построчно");
            key = ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D0:
                    {
                        b = false;
                        break;
                    };
                case ConsoleKey.D1:
                    {
                        you.cout();
                        ReadKey(true);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        b = true;
                        WriteLine("Вывод: 0 - выход, 1 - имя, 2 - возраст, 3 - рост, 4 - вес, 5 - день рождения, 6 - родители, 7 - ID");
                        while (b == true)
                        {
                            key = ReadKey(true);
                            switch (key.Key)
                            {
                                case ConsoleKey.D0: { b = false; break; }
                                case ConsoleKey.D1: { WriteLine(you.Name);  break; }
                                case ConsoleKey.D2: { WriteLine(you.Age);  break; }
                                case ConsoleKey.D3: { WriteLine(you.High); break; }
                                case ConsoleKey.D4: { WriteLine(you.Weight);  break; }
                                case ConsoleKey.D5: { WriteLine(you.Birthdate);  break; }
                                case ConsoleKey.D6: { WriteLine(you[0] + ' ' + you[1]);  break; }
                                case ConsoleKey.D7: { WriteLine(you.I_D);  break; }

                            }
                        }
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        b = true;
                        WriteLine("Изменение: 0 - выход, 1 - имя, 2 - возраст, 3 - рост, 4 - вес, 5 - день рождения, 6 - родители, 7 - ID");
                        while (b == true)
                        {
                            key = ReadKey(true);
                            switch (key.Key)
                            {
                                case ConsoleKey.D0: { b = false; break; }
                                case ConsoleKey.D1: { you.Name = ReadLine(); break; }
                                case ConsoleKey.D2: { you.Age = int.Parse(ReadLine()); break; }
                                case ConsoleKey.D3: { you.High = int.Parse(ReadLine()); break; }
                                case ConsoleKey.D4: { you.Weight = int.Parse(ReadLine()); break; }
                                case ConsoleKey.D5: { you.date(); break; }
                                case ConsoleKey.D6: { you[0] = ReadLine(); break; }
                                case ConsoleKey.D7: { you[1] = ReadLine(); break; }

                            }
                        }
                        break;
                    }
            }
        }
        }
    }
