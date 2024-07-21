using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Hesap Makinesi");
                Console.WriteLine("------------------");

                Console.Write("Birinci sayıyı giriniz: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bir işlem seçin");
                Console.WriteLine("\t+ : Toplama");
                Console.WriteLine("\t- : Çıkarma");
                Console.WriteLine("\t* : Çarpma");
                Console.WriteLine("\t/ : Bölme");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Cevabınız: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Cevabınız: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Cevabınız: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Cevabınız: {num1} / {num2} = " + result);
                        break;
                        Console.WriteLine("Geçersiz işlem");
                }

                Console.WriteLine("Tekrar hesaplama yapmak ister misiniz? (E/H)");
            } while (Console.ReadLine().ToUpper() == "E");

            Console.WriteLine("Teşekkürler");
        }
    }
}