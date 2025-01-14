using System;
namespace Tekshirish
{
    class Tekshirish
    {
        static void Main()
        {
            string str = "qwErTy";
            int s = str.Length;
            Console.WriteLine("strni  uzunligi = " + s);

            Console.WriteLine("sonni kiriting");
            int n = Convert.ToInt32(Console.ReadLine());

            if (s < n)
            {
               Console.WriteLine($"katta harflarga o'girildi: { str.ToUpper()}");
               
            }
            else
            {
               Console.WriteLine($"kichik harflarga o'girildi: { str.ToLower()}");  
            }










        }
    }
}
