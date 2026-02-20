using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("====================");
        Console.WriteLine("\ttip");
        Console.WriteLine("====================");
        Console.WriteLine("for 10$ bill---- tip is 10%");
        Console.WriteLine("for 20$ bill---- tip is 12%");
        Console.WriteLine("for 30$ bill---- tip is 14%");
        Console.WriteLine("for 50$ bill---- tip is 15%");
        Console.WriteLine("for >50$ bill---- tip is 20%");
        Console.WriteLine("enter your bill");
        double bill = Convert.ToDouble(Console.ReadLine());
        if (bill <= 10)
        {
            Console.WriteLine("tip is " + bill * 0.1+"$");
        }
        else if (bill > 10 && bill <= 20)
        {
            bill = bill * 0.12;
            Console.WriteLine("tip is " + bill+"$" );
        }
        else if (bill > 20 && bill <= 30)
        {
            Console.WriteLine("tip is " + bill * 0.14+"$");
        }
        else if (bill > 30 && bill <= 50)
        {
            Console.WriteLine("tip is " + bill * 0.15+"$");
        }
        else
        {
            Console.WriteLine("tip is " + bill * 0.2+"$");
        }
    }
}
