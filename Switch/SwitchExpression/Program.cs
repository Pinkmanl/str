using System;
namespace switchExpression
{
    class switchExpression
    {
        static void Main()
        {
            Console.WriteLine("Hafta kunlarini ingliz tiliga o'giruvchi dastur");
            Console.WriteLine("ingliz tiliga ogirmoqchi bo'lgan hafta kunini kiriting");
            string week = Console.ReadLine() ?? "";

            string result = week.ToLower() switch
            {
                "dushanba" => "monday",
                "seshanba" => "tuesday",
                "chorshanba" => "wednesday",
                "payshanba" => "thursday",
                "juma" => "friday",
                "shanba" => "saturday",
                "yakshanba" => "sunday",
                _ => "Operation not found"
            };
            Console.WriteLine(result);

        }
    }
}

