using System;

namespace uprajneniq
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("въведете име");
            name = Console.ReadLine();
            Console.WriteLine("въведете възраст");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("непълнолетен");
            }
            else if (age > 18)
            {
                Console.WriteLine("пълнолетен");
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            string[] masiv = { "зелено", "синьо", "червено" };

            masiv[1] = "жълто";

            foreach (string color in masiv)
            {
                Console.WriteLine(color);
            }
            string[] maziv = new string[5];

            aloha();

            Console.WriteLine("въведи две числа");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("otgovra e " + sbor(num1, num2));

        }

        public static void aloha()

        {
            Console.WriteLine("аз съм функция");
        }

        public static void imezdr(string name)

        {
            Console.WriteLine("ЗДР " + name);
        }
        static int sbor(int num1, int num2)
        {
            return(num1 + num2);
        }
    }
}
