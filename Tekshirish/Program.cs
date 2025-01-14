using System;
namespace Tekshirish
{
    class Tekshirish
    {
        static void Main()
        {
            string str = "teLefOn";
            int strLength = str.Length;
            try
            {
                Console.Write("Sonni kiriting");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input: x={x}, str=\"{str}\"");
                Console.WriteLine($"Output: {(strLength < x ? str.ToUpper() : str.ToLower())}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid int");
            }
        }
    }
}
