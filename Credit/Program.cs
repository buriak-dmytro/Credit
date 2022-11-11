using System;

namespace Credit
{
    class Program
    {
        static Random randGenLocal = new Random();
        static string charsAvailable = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        static string GenerateRandomString(int length)
        {
            char[] stringChars = new char[length];
            
            for (int i = 0; i < length; i++)
            {
                stringChars[i] = charsAvailable[randGenLocal.Next(charsAvailable.Length)];
            }

            return new string(stringChars);
        }

        static void Main()
        {
            Student[] students = new Student[10];

            Console.WriteLine("Average:");
            for (int index = 1; index <= 5; index++)
            {
                students[index - 1] = new Average(GenerateRandomString(20), randGenLocal.Next(21));
                Console.WriteLine(students[index - 1]);
            }

            Console.WriteLine("Clever:");
            for (int index = 6; index <= 9; index++)
            {
                students[index - 1] = new Clever(GenerateRandomString(20), randGenLocal.Next(21));
                Console.WriteLine(students[index - 1]);
            }

            Console.WriteLine("Genious:");
            for (int index = 10; index <= 10; index++)
            {
                students[index - 1] = new Genious(GenerateRandomString(20), randGenLocal.Next(21));
                Console.WriteLine(students[index - 1]);
            }

            Console.ReadLine();
        }
    }
}
