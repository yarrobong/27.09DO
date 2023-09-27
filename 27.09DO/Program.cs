using System;

namespace doo
{

    class reshenie
    {
        static void Main()
        {

            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                int sqrtN = (int)Math.Sqrt(n);

                if (sqrtN * sqrtN == n)
                {
                    Console.WriteLine("Это квадратное число");
                }
                else
                {
                    Console.WriteLine("Это неквадратное число");
                }

                string result = (sqrtN * sqrtN == n) ? "True" : "False";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Введите положительное число");
            }
        }
    }
}
