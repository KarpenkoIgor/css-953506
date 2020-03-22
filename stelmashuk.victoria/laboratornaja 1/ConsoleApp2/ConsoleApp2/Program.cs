using System;


namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int sum=0;

            int sum1=0;

            //bool play = true;
            string[] str1 = { "Буба", "Крести ", "Трефы", "Пики" };

            string[] str2 = {"Туз", "6", "7","8", "9", "10","Валет", "Дама", "Король"};
            //рандом по двум строкам
            int a1 = rnd.Next(str1.Length);//масти
            int b1 = rnd.Next(str2.Length);//номера

            Console.WriteLine("Здравствуйте! Добро рожаловать в игру 21, мы играем колодой в 36 карт, и тузы принимают значение 1!");
            Console.WriteLine("Надеюсь, вы хотите сыграть, ведь игра уже началась!");
            Console.WriteLine("Тяните свою перву карту: ");
            Console.WriteLine("Ваша 1 карта: {0} - {1}", str1[a1], str2[b1]);

            if (str2[b1]=="Туз" ) str2[b1]="1";
            else if (str2[b1]=="Король" ) str2[b1]="4";
            else if (str2[b1]=="Дама" ) str2[b1]="3";
            else if (str2[b1]=="Валет" ) str2[b1]="2";
             int i = Convert.ToInt32(str2[b1]);
            sum+=i;
                //Console.WriteLine(i);
           string otvet;
           do{
             int c1 = rnd.Next(str1.Length);
             int d1 = rnd.Next(str2.Length);
                Console.WriteLine("Ваша следующая карта: {0} - {1}", str1[c1], str2[d1]);
            if (str2[d1]=="Туз" ) str2[d1]="1";
            else if (str2[d1]=="Король" ) str2[d1]="4";
            else if (str2[d1]=="Дама" ) str2[d1]="3";
            else if (str2[d1]=="Валет" ) str2[d1]="2";
           

             int j = Convert.ToInt32(str2[d1]);
                sum+=j;
                Console.WriteLine("Ваши очки на данный момент: ");
                Console.WriteLine(sum);

             Console.WriteLine("Хотите взять дополнительную карту?");
             otvet=Console.ReadLine();
            }while(otvet=="да");
            int x1 = rnd.Next(str1.Length);
            int y1 = rnd.Next(str2.Length);
            if (str2[y1]=="Туз" ) str2[y1]="1";
            else if (str2[y1]=="Король" ) str2[y1]="4";
            else if (str2[y1]=="Дама" ) str2[y1]="3";
            else if (str2[y1]=="Валет" ) str2[y1]="2";
            else ;
             int k = Convert.ToInt32(str2[y1]);
            sum1+=k;
            int l=0;
            do{
            int z1 = rnd.Next(str1.Length);
            int f1 = rnd.Next(str2.Length);
                if (str2[f1]=="Туз" ) str2[f1]="1";
                else if (str2[f1]=="Король" ) str2[f1]="4";
                else if (str2[f1]=="Дама" ) str2[f1]="3";
                else if (str2[f1]=="Валет" ) str2[f1]="2";
            
                  l = Convert.ToInt32(str2[f1]);
                sum1+=l;
            }while( (sum1+ l)<=21 && (sum1+ l)>=17 );
            Console.WriteLine("Очки противника: ");
            Console.WriteLine(sum1);
           if((sum==21 && sum1!=21) ||(sum>sum1 && sum<21) || sum<sum1 && sum<21 && sum1>21) Console.WriteLine("вы выйграли!");
           else if((sum1>sum && sum1<=21)||(sum1<sum && sum1<21 && sum>21)) Console.WriteLine("вы проиграли! Не растраивайтесь, получится в следующий раз :)");
            else if (sum==21 &&sum1==21) Console.WriteLine("вы оба выйграли! :)");
            else  if((sum>21 && sum1>21) || (sum==sum1) ) Console.WriteLine("у вас ничья! Победила дружба :)");
          
          /* string answer ="";
         Console.WriteLine("Хотите сыграть еще раз?");
                answer = Console.ReadLine();
                if (answer == "да") play = true;
                else play = false;
            } while (play);*/
        }
    }
}
               