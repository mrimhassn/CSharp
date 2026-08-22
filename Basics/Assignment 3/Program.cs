using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;

namespace CS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*(((Question 01)))
             
             * (a) Explain why this code is inefficient. Reference what happens in memory.
             * its string class which is immutable once creat never change so when you add new
             * product it create new object ,new memory and using GC alot .
             
            (b) Rewrite this code using StringBuilder to be more efficient.*/
            var productList = new StringBuilder();
            for (int i = 1; i <= 5000; i++)
            {
                productList.Append("PROD-").Append(i).Append(",");
            }
            string result = productList.ToString();

            /*(c) Add timing code (using Stopwatch) to both versions and report
            the time difference.*/

            int counter = 5000;

            //String class
            Stopwatch sw1 = Stopwatch.StartNew();

            string productListv1 = "";
            for (int i = 1; i <= counter; i++)
            {
                productListv1 += "PROD-" + i + ",";
            }

            sw1.Stop();
            Console.WriteLine($"String Time: {sw1.Elapsed.TotalMilliseconds} ms");

            //stringbuilder
            Stopwatch sw2 = Stopwatch.StartNew();

            var productListv2 = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                productListv2.Append("PROD-").Append(i).Append(",");
            }
            string resultv2 = productListv2.ToString();

            sw2.Stop();
            Console.WriteLine($"Stringbuilder Time :{sw2.Elapsed.TotalMilliseconds} ms");

            double diff = sw1.Elapsed.TotalMilliseconds - sw2.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Difference between them is {diff}");

            Console.WriteLine("-----------------------------------------------------------");

            //(((Question 02)))
            // Ticket Pricing System

            Console.Write("Enter age: ");
            String? input = Console.ReadLine();
            int age;

            while (!(int.TryParse(input, out age)))
            {
                Console.WriteLine("Invalid input try again");
                Console.WriteLine("Enter age: ");
                input = Console.ReadLine();
            }

            Console.Write("Enter day of week (1-7, where 6=Fri, 7=Sat): ");
            string? input2 = Console.ReadLine();
            int dayofweek;
            bool dayParsed = int.TryParse(input2, out dayofweek);

            while (!dayParsed || dayofweek < 1 || dayofweek > 7)
            {
                Console.WriteLine("Invalid input try again");
                Console.WriteLine("Enter day again: ");
                input2 = Console.ReadLine();
                dayParsed = int.TryParse(input2, out dayofweek);
            }

            Console.Write("Are you a student? (yes/no): ");
            string? studentInput = Console.ReadLine()!.ToLower();
            bool isStudent = (studentInput == "yes");

            decimal price = 0m;

            if (age < 5)
                price = 0m;
            else if (age >= 5 && age <= 12)
            {
                price = 30m;
            }

            else if (age >= 13 && age <= 59)
            {
                price = 50m;
            }

            else if (age >= 60)
            {
                price = 25m;
            }

            Console.WriteLine("TICKET RECEIPT");
            Console.WriteLine($"Ticket Price :{price} LE");

            decimal totalPrice = price;
            if (price > 0m)
            {
                if (dayofweek == 6 || dayofweek == 7)
                {
                    totalPrice += 10m;
                    Console.WriteLine($"After weekend surcharge :{totalPrice} LE");
                }
                if (isStudent)
                {
                    totalPrice *= 0.8m;
                    Console.WriteLine($"After student discount: {totalPrice} LE");
                }
            }


            Console.WriteLine("===============================");
            Console.WriteLine($"Final Total:{totalPrice} EGP");

            Console.WriteLine("-----------------------------------------------------------");

            //Question 03: Convert the following if-else chain to:
            //(a) A traditional switch statement

            string fileExtension = ".pdf";
            string fileType;

            switch (fileExtension)
            {
                case ".pdf":
                    fileType = "PDF Document";
                    break;

                case ".docx":
                case ".doc":
                    fileType = "Word Document";
                    break;

                case ".xlsx":
                case ".xls":
                    fileType = "Excel Spreadsheet";
                    break;

                case ".jpg":
                case ".png":
                case ".gif":
                    fileType = "Image File";
                    break;

                default:
                    fileType = "Unknown File Type";
                    break;
            }
            Console.WriteLine($"File Type is : {fileType}");

            //(b) A switch expression

            string fileExtension2 = ".xls";
            string fileType2 = fileExtension2 switch
            {
                ".pdf" => "PDF Document",
                ".docx" or ".doc" => "Word Document",
                ".xlsx" or ".xls" => "Excel Spreadsheet",
                ".jpg" or ".png" or ".gif" => "Image File",
                _ => "Unknown File Type"
            };
            Console.WriteLine($"File Type is : {fileType2}");

            Console.WriteLine("-----------------------------------------------------------");

            //(((Question 04))) : Ternary Operator

            int temperature = 35;
            string weatherAdvice = temperature < 0 ? "Freeing! Stay indoors." :
                                    temperature < 15 ? "Cold. Wear a jacket." :
                                    temperature < 25 ? "Pleasant weather." :
                                    temperature < 35 ? "Warm. Stay hydrated." :
                                    "Hot! Avoid sun exposure.";

            Console.WriteLine($"Advice is : {weatherAdvice}");

            // no it's not readable , when its just simple if else i can choose ternary 
            // but it's more hard to read when nested if 

            Console.WriteLine("-----------------------------------------------------------");

            //(((Question 05))) : Ternary Operator
            int counter2 = 0;
            bool isValid = false;

            do
            {
                Console.WriteLine("Enter YOUR Password");
                string? password = Console.ReadLine();

                bool hasUpper = false, hasDigit = false,
                        hasSpace = false;

                foreach (char c in password!)
                {
                    if (char.IsUpper(c))
                        hasUpper = true;

                    if (char.IsDigit(c))
                        hasDigit = true;

                    if (char.IsWhiteSpace(c))
                        hasSpace = true;
                }

                isValid = true;
                if (password.Length < 8)
                {
                    isValid = false;
                    Console.WriteLine("Password must be at least 8 characters.");
                }

                if (!hasUpper)
                {
                    isValid = false;
                    Console.WriteLine("Password must contain at least one uppercase letter.");
                }

                if (!hasDigit)
                {
                    isValid = false;
                    Console.WriteLine("Password must contain at least one digit.");
                }

                if (hasSpace)
                {
                    isValid = false;
                    Console.WriteLine("Password must not contain Spaces");
                }

                if (isValid)
                {
                    Console.WriteLine("Password accepted!");
                    break;
                }

                counter2++;
            }
            while (counter2 < 5);

            if (!isValid)
            {
                Console.WriteLine("Account locked");
            }

            Console.WriteLine("-----------------------------------------------------------");

            //(((Question 06))) : Array Processing

            int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            //(a) Find and display all failing scores (below 50)
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 50)
                    Console.WriteLine(scores[i]);
            }

            //(b)Find the first score above 90 and stop searching immediately
            foreach (var i in scores)
            {
                if (i > 90)
                {
                    Console.WriteLine($"{i} is bigger than 90");
                    break;
                }
            }

            //(c) Calculate the class average, excluding any scores below 40
            int avr = 0;
            foreach (var i in scores)
            {
                if (i > 40)
                {
                    avr += i;
                }
            }
            Console.WriteLine($"Average is {avr}");

            //(d) Count how many students scored in each grade range:
            int A = 0, B = 0, C = 0, D = 0, F = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 90)
                    A++;
                else if (scores[i] >= 80 && scores[i] < 90)
                    B++;
                else if (scores[i] >= 70 && scores[i] < 80)
                    C++;
                else if (scores[i] >= 60 && scores[i] < 70)
                    D++;
                else
                    F++;
            }
            Console.WriteLine($"{A} has A \n{B} has B \n{C} has C \n{D} has D \n{F} has F ");
        }
    }
}
