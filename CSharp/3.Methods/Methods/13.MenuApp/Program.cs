using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("Pick option from the menu");
                Console.WriteLine("1. Reverse number ");
                Console.WriteLine("2. Find average of a sequence ");
                Console.WriteLine("3. Solve linear equation ");
                Console.WriteLine("0. Exit");
                
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1: //Reverse number
                        Console.Write("Write the number you want to reverse : ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("The reversed number is "+reverseNum(num));
                        break;
                    case 2: //Avrg of a sequence
                        Console.WriteLine("Enter the sequence on one line separated by spaces");
                        int[] sequence = new int[0];
                        bool error = true;
                        while (error)
                        {
                            try
                            {
                                string[] nums = Console.ReadLine().Split();
                                sequence = new int[nums.Length];
                                for (int i = 0; i < nums.Length; i++)
                                {
                                    sequence[i] = int.Parse(nums[i]);
                                }
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("You should enter a non-empty sequence of integers");
                                error = true;
                            }
                        }
                        Console.WriteLine("The average is "+calculateAverage(sequence));
                        break;
                    case 3: // Linear equation
                        double a = 0;
                        while (a == 0)
                        {
                            Console.Write("Enter a (a != 0) :");
                            a = double.Parse(Console.ReadLine());
                        }
                        Console.Write("Enter b :");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("\"x\" is equal to "+solveLinearEquation(a, b));
                        break;
                }
                Console.Write(choice != 0 ? "Press enter to return to the menu": "Thank you for using our application");
                Console.ReadLine();
            }
        }

        private static double solveLinearEquation(double a, double b)
        {
            return -(b / a);
        }

        private static double calculateAverage(int[] sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }

            return sum / sequence.Length;
        }

        private static int reverseNum(int num)
        {
            int length = num.ToString().Length;
            int newNum = 0;
            int i = 0;
            while (num > 0)
            {
                int c_digit = num % 10;
                newNum += c_digit * (int)Math.Pow(10.0, (double)length - i - 1);
                i++;
                num /= 10;
            }

            return newNum;
        }
    }
}
