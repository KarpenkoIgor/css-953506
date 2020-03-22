using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
    

        DateTime date1 = new DateTime(2015, 1, 20);
        DateTime date2 = new DateTime(2015, 2, 20);
        DateTime date3 = new DateTime(2015, 3, 20);
        DateTime date4 = new DateTime(2015, 4, 20);
        DateTime date5 = new DateTime(2015, 5, 20);
        DateTime date6 = new DateTime(2015, 6, 20);
        DateTime date7 = new DateTime(2015, 7, 20);
        DateTime date8 = new DateTime(2015, 8, 20);
        DateTime date9 = new DateTime(2015, 9, 20);
        DateTime date10 = new DateTime(2015, 10, 20);
        DateTime date11 = new DateTime(2015, 11, 20);
        DateTime date12 = new DateTime(2015, 12, 20);
              Console.WriteLine(date1.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date2.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date3.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date4.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date5.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date6.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date7.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date8.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date9.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date10.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date11.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine(date12.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr-FR")));
    }
}
