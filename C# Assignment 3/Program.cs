using System.ComponentModel.DataAnnotations;

namespace C__Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Console.WriteLine("Enter number");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No"); 
            #endregion

            #region Q2
            //Console.WriteLine("Enter number");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //} 
            #endregion

            #region Q3
            //Console.WriteLine("Enter numbers");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //int.TryParse(Console.ReadLine(), out int num3);
            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));
            //Console.WriteLine($"max element = {max}"); 
            //Console.WriteLine($"max element = {min}"); 
            #endregion

            #region Q4 
            //Console.WriteLine("Enter number:");
            //int.TryParse(Console.ReadLine(), out int n);
            //if (n % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("odd"); 
            #endregion

            #region Q5 
            //int[] L = { 'a', 'e', 'i', 'o', 'u' };
            //Console.Write("Enter your char : ");
            //char.TryParse(Console.ReadLine(), out char c);

            //if (L.Contains(c)){
            //    Console.WriteLine("Vowel");
            // }
            //else
            //    Console.WriteLine("Consonant");
            #endregion

            #region Q6
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    } 
            #endregion

            #region Q7
            Console.Write("Enter number : ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i < n; i++)
            {
                Console.Write(n * n);
            } 
            #endregion

        }
    }
}
