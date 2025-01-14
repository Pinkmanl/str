using System;
namespace Tekshirish
{
    class Program
    {
        static void Main()
        {
            int x = 15;
            int y = 20;
            string result = (x > y)
             ? "x is greater then y"
             : (x < y)
               ? "x is less then y"
               : (x == y)
                 ? "x is equal to y"
                 : "x and y are not comparable";
            if (x > y)
            {
                result = "x is greater then y";
                 }
            else if (x < y)
            {
                result = "x is less then y";
            }
            else if (x == y)
            {
                result = "x is equal to y";
            }
            else 
            {
         result ="x and y are not comparable";
            }
            Console.WriteLine(result);
        }
    }
}