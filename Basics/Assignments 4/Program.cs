using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS4
{
    //Part 1: Enums
    //Q1: Day of the Week
    public enum DayOfWeek
    {
        Saturday = 1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part 1: Enums
            //Q1: Day of the Week

            /*Create an enum called DayOfWeek with values: Saturday, Sunday, Monday,
            Tuesday, Wednesday, Thursday, Friday.
            Then write a program that:
            • Asks the user to enter a day number (0–6).
            • Converts it to the enum and prints the day name.
            • Uses a switch statement to print whether it's a "Workday" or a "Weekend".*/

            Console.WriteLine("Enter a day number (1-7)");
            string? input = Console.ReadLine();


            bool isParsed = int.TryParse(input, out int day);

            while (!isParsed || day < 1 || day > 7)
            {
                Console.WriteLine("Invalid input try again");
                Console.WriteLine("Enter day again (1-7): ");
                input = Console.ReadLine();
                isParsed = int.TryParse(input, out day);
            }

            DayOfWeek dayParsed = (DayOfWeek)day;
            switch (dayParsed)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Friday:
                    Console.WriteLine($"Day is : {day}");
                    Console.WriteLine("It's The weekend");
                    break;
                default:
                    Console.WriteLine($"Day is : {day}");
                    Console.WriteLine("It's a workday");
                    break;

            }

            //=======================================================

            //Part 2: Arrays
            //Q1: Array Statistics

            /*Write a program that:
            • Asks the user for the size of an integer array.
            • Reads the elements from the user.
            • Prints: the sum, the average, the maximum value, the minimum value, and
            the array in reverse order.*/

            Console.Write("Enter array size : ");
            string? num = Console.ReadLine();
            bool isValid = int.TryParse(num, out int n);

            while (!isValid || n <= 0)
            {
                Console.WriteLine("Invalid input try again");
                Console.Write("Enter array size : ");
                num = Console.ReadLine();
                isValid = int.TryParse(num, out n);
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element[{i}] : ");
                string? element = Console.ReadLine();
                bool isElement = int.TryParse(element, out int val);

                while (!isElement)
                {
                    Console.WriteLine("Invalid input, try again");
                    Console.Write($"Enter element[{i}] : ");

                    element = Console.ReadLine();
                    isElement = int.TryParse(element, out val);

                }
                arr[i] = val;
            }

            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            foreach (int i in arr)
            {
                sum += i;
                if (max <= i)
                    max = i;
                if (min >= i)
                    min = i;

            }

            double avg = sum / (double)n;
            Console.WriteLine($"Sum      = {sum}");
            Console.WriteLine($"Average  = {avg}");
            Console.WriteLine($"Max      = {max}");
            Console.WriteLine($"Min      = {min}");
            Console.Write($"Reverse  = ");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($" {arr[i]},");
            }



            //Q2 : Student Grades Matrix

            /*You have 3 students, each with 4 subject grades. Store them in a 2D array.
            Write a program that:
            • Reads grades from the user into a [3, 4] array.
            • Prints each student's average grade.
            • Prints the overall class averal */


            int[,] matrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter student {i + 1} degrees : ");
                for (int j = 0; j < 4; j++)
                {

                    Console.Write($"Enter subject {j + 1} : ");

                    int value = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = value;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int sum1 = 0;

                for (int j = 0; j < 4; j++)
                {
                    sum1 += matrix[i, j];
                }

                double average = (double)sum1 / 4;
                Console.WriteLine($"Average of student {i + 1} = {average}");
            }

            int totalSum = 0;
            foreach (int i in matrix)
            {
                totalSum += i;
            }
            double avrAllGrades = (double)totalSum / 12;
            Console.WriteLine($"Overall class averal{avrAllGrades}");

            //=======================================================

            //Part 3: Functions (Methods)
            //Q1: Basic Calculator Functions

            /*Write four static methods: Add, Subtract, Multiply, Divide.
            Each takes two double parameters and returns a double result.
            In Main, ask the user for two numbers and an operation (+, -, *, /), then call the
            appropriate method and display the result.*/


            Console.Write("Enter first number : ");
            bool isTrue1st = double.TryParse(Console.ReadLine(), out double first);

            while (!isTrue1st)
            {
                Console.WriteLine("Invalid number");
                Console.Write("Enter first number again : ");
                isTrue1st = double.TryParse(Console.ReadLine(), out first);
            }

            Console.Write("Enter sec number   : ");
            bool isTrue2nd = double.TryParse(Console.ReadLine(), out double sec);
            while (!isTrue2nd)
            {
                Console.WriteLine("Invalid number");
                Console.Write("Enter sec number again   : ");
                isTrue2nd = double.TryParse(Console.ReadLine(), out sec);
            }

            Console.Write("Choose operation(+ ,- ,* ,/ ): ");
            string? operation = Console.ReadLine();

            bool isTrue = false;
            while (!isTrue)
            {
                isTrue = true;
                if (operation == "+")
                    Console.WriteLine(Add(first, sec));
                else if (operation == "-")
                    Console.WriteLine(Subtract(first, sec));
                else if (operation == "*")
                    Console.WriteLine(Multiply(first, sec));
                else if (operation == "/")
                    Console.WriteLine(Divide(first, sec));
                else
                {
                    Console.Write("Choose operation(+ ,- ,* ,/ ): ");
                    operation = Console.ReadLine();
                    isTrue = false;

                }
            }

            //Q2 : Circle Calculator with out

            /*Write a method CalculateCircle that takes a double radius as input and returns both
            the area and circumference using out parameters.
            Call the method from Main, then print both results*/


            double area, circumference;
            CalculateCircle(4, out area, out circumference);

            Console.WriteLine($"Area is : {area}");
            Console.WriteLine($"Circumference is : {circumference}");

            //=======================================================

        }

        /*Part 3: Functions (Methods)
        Q1 : Basic Calculator Functions
        Write four static methods: Add, Subtract, Multiply, Divide.
        Each takes two double parameters and returns a double result.*/

        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Can not divide by zero");
                return 0;
            }
            else
                return x / y;
        }

        /*Q2 : Circle Calculator with out
        Write a method CalculateCircle that takes a double radius as input and returns both
        the area and circumference using out parameters.*/
        public static void CalculateCircle(
                            double radius, out double area, out double circumference)
        {
            const double pi = 3.14;
            area = radius * radius * pi;
            circumference = 2 * radius * pi;

        }
    }
}
