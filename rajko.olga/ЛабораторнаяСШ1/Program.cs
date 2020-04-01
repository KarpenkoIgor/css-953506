using System;

namespace ЛабораторнаяСШ1
{
        class Program
     {
        static void Main(string[] args)
        {          
            double a, b, c, x3,x4 , D, t1, t2, x1, x2,i,z1,z3,z4,x,y,z2;
            Console.WriteLine("Решим возвратное уравнение a * Math.Pow(x, 4) + b * Math.Pow(x, 3) + c * Math.Pow(x, 2) + b * x + a = 0 ");
            Console.Write("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Приведём уравнение к виду a*(Math.Pow(x,2)+1/Math.Pow(x,2)) + b*(x+1/x)+c=0  ");
            Console.WriteLine(" Воспользуемся заменой t = (x + 1 / x)");
            Console.WriteLine(" Получим уравнение a*Math.Pow(t,2)+b*t+c-2*a = 0 ");
            Console.WriteLine("Найдём дискриминант D = Math.Pow(b, 2) - 4 * a * c");
            D = Math.Pow(b, 2) - 4 * a * c;
            t1 = (-b + Math.Pow(D, 1 / 2)) / 2 * a;
            t2 = (-b - Math.Pow(D, 1 / 2)) / 2 * a;
            Console.WriteLine(" Вернёмся к замене и найдём  x1,x2,x3,x4");
            Console.WriteLine("Ответ:  ");
            D = Math.Pow(t1, 2) - 4;
            if (D >= 0)
            {
                x1 = (-t1 + Math.Pow(D, 1 / 2)) / 2 * a; 
                x2 = (-t1 - Math.Pow(D, 1 / 2)) / 2 * a;
                Console.Write(" x1=");
                Console.Write(x1);
                Console.Write(" / x2=");
                Console.Write(x2);
            }
            else
            {
                x1 = (-t1 + Math.Pow(D, 1 / 2)) / 2 * a;
                x = -t1 / 2 * a;
                y = Math.Pow(D, 1 / 2) / 2 * a;
                z3 = x + y;
                Console.Write("   x1=");
                Console.Write(x);
                Console.Write(" + "); 
                Console.Write(y);
                Console.Write("*i ");
                x2 = (-t1 - Math.Pow(D , 1 / 2)) / 2 * a;
                x = -t1 / 2 * a; 
                y = Math.Pow(D, 1 / 2) / 2 * a;
                z4 = x - y; 
                Console.Write(" /  x2=");
                Console.Write(x); 
                Console.Write(" - ");
                Console.Write(y); 
                Console.Write("*i ");          
            }
            D = Math.Pow(t2, 2) - 4;
            if (D >= 0)
            {
                x3 = (-t2 + Math.Pow(D, 1 / 2)) / 2 * a;
                x4 = (-t2 - Math.Pow(D, 1 / 2)) / 2 * a;
                Console.Write(" / x3=");
                Console.Write(x3);
                Console.Write( " / x4=");
                Console.WriteLine(x4);
            }
            else
            {
                i = Math.Pow(-1, 1 / 2);
                x3 = (-t2 + Math.Pow(D, 1 / 2)) / 2 * a;
                x = -t2 / 2 * a;
                y = Math.Pow(D, 1 / 2) / 2 * a;
                z1 = x + y; 
                Console.Write("  /  x3=");
                Console.Write(x); 
                Console.Write(" + ");
                Console.Write(y);
                Console.Write("*i ");
                x4 = (-t2 - Math.Pow(D, 1 / 2)) / 2 * a;
                x = -t2 / 2 * a;
                y = Math.Pow(D, 1 / 2) / 2 * a; 
                z2 = x - y ;
                x = -t2 / 2 * a;
                y = Math.Pow(D, 1 / 2) / 2 * a;
                Console.Write(" /  x4="); 
                Console.Write(x); 
                Console.Write(" - ");
                Console.Write(y); 
                Console.WriteLine("*i ");           
            }
            Console.Write("i-мнимая еденица");     
        }
    }
}
