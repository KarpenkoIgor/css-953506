using System;

namespace pudge
{
    class Program
    {
        static void Main()
        {
            char choice;
            string name = "", surname = "", gender = "";
            int birth_year = 0;
            Human human;

            Console.WriteLine("Enter name and surname");
            name = Console.ReadLine();
            surname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter gender (male/female, other - skip)");
            gender = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter birth year");
            birth_year = Convert.ToInt32(Console.ReadLine());
            if (birth_year < 1900 || birth_year > 2020)
                birth_year = 2020;
            Console.Clear();
            
            Human.birth_year = birth_year;
            human = new Human(name, surname, gender);
            
            do
            {
                Console.WriteLine("1 - Show info\n2 - Die\n3 - Change name\n4 - Change surname\n5 - Set disease\n6 - Shout\n7 - Change gender\n8 - Show name and surname\nq - Exit");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (choice)
                {
                    case '1':
                        human.ShowInfo();
                        Console.ReadKey();
                        break;
                    case '2':
                        if (human.isDead)
                            human.Resurrect();
                        else human.Die();
                        break;
                    case '3':
                        Console.Write("name - ");
                        human.Name = Console.ReadLine();
                        break;
                    case '4':
                        Console.Write("surname - ");
                        human.Surname = Console.ReadLine();
                        break;
                    case '5':
                        Console.Write("disease - ");
                        human.Disease = Console.ReadLine();
                        break;
                    case '6':
                        human.Shout();
                        break;
                    case '7':
                        human.ChangeGender();
                        break;
                    case '8':
                        Console.Clear();
                        Console.Write(human["name"] + " " + human["surname"]);
                        Console.ReadKey();
                        break;
                    case 'q':
                        return;
                }
                Console.Clear();
            } while (true);
        }
    }
}
