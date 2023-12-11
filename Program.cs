//   Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.


using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода ");
            string input = Console.ReadLine();
      
            if (input.ToLower() == "q")
            {

                Console.WriteLine("Программа завершена");
                break;

            }

            int number;
            if (int.TryParse(input, out number))
            {
                 int sum = 0;
                
                while (number != 0)
             {
             sum += number % 10;
             number /= 10;
             }
         

                Console.WriteLine($"Сумма цифр введенного числа: {sum}");

                if (sum % 2 == 0)
                {
                    Console.WriteLine("Программа завершена");
                    break;
                }
                else
                {
                    Console.WriteLine("Сумма цифр нечетная");
                }
            }
            
        }
    }
}

