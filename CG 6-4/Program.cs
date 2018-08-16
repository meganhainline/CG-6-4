using System;

namespace CG_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date formatted MM/DD/YYYY.");  //gets first date from user
                string userValue = Console.ReadLine();
            Console.WriteLine("Please enter another date formatted MM/DD/YYYY.");  //gets second date from user
                string userValue2 = Console.ReadLine();
            DateTime value1 = DateTime.Parse(userValue);  //converts user values into date times
            DateTime value2 = DateTime.Parse(userValue2);
            TimeSpan time = value1.Subtract(value2);    //subtracts second datetime from first datetime
            Console.WriteLine(time.TotalDays);     //outputs number of days between the two dates

            Console.ReadLine();
        }
    }
}
