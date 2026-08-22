namespace CS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1: What will this print and explain what happens ?

            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);

            // print 9 , it's explicit which you ask compiler to convert 
            // occur losing in data 

            //Q2: This code doesn’t compile. Fix it with the smallest change?

            int n = 5;
            double d2 = (double)n / 2;
            Console.WriteLine(d2);

            //Q3: You read a number from user input ..
            //Write the correct line to get age as int.

            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);     // guard only from nulls not invalid strings 
            Console.WriteLine(num);

            //Q4: What happens here and why ?

            /*string s = "12a";
            int z = int.Parse(s);
            Console.WriteLine(z);*/

            // format exception cause a not number , parse doesn't have guard like 
            // convert and try parse 

            //Q5: Complete the code from the previous question so it prints
            //Invalid if conversion into int fails, otherwise prints the number

            String input = Console.ReadLine();
            bool isparsed = int.TryParse(input, out int parsednum);

            if (isparsed)
                Console.WriteLine(parsednum);
            else
                Console.WriteLine("invalid values");


            //Q6: What will this print and explain why ?
            object o = 10;          //boxing
            int a = (int)o;         //unboxing
            Console.WriteLine(a + 1);

            // print 11 , cause can't put value type in reference type
            // object in heap (boxing ), explicit cast into int in stack (unboxing)


            //Q7: What will this print and explain why and if there is a handle it ?

            object O = 10;
            //long X = (long)O; // wrong 
            int X = (int)O;    // true
            Console.WriteLine(X);
            /* InvalidCastException cause 10 is int you must make unboxing to 
             the original datatype (int not long)*/


            //Q8: Fix this to avoid exceptions and print - 1 if conversion isn’ possible?
            /*object m = 10;
            long k = m;
            Console.WriteLine(k);*/

            //Can't implicit convert type object to long
            object m = 10;
            long k = m is int i ? i : -1;
            Console.WriteLine(k);


            //Q9: What will this print and explain why ?
            string? name = null;
            Console.WriteLine(name?.Length);
            // print blank line , cause name is null and we make (null conditional operator ?.)
            // which returns null instead of throwing NullReferenceException.


            //Q10: What will this print and explain the process?
            string? name2 = null;
            int length = name2?.Length ?? 0;
            // Null Coalescing Operator ==> if name2?.Length is not null take it else
            // make lenght = 0 ;


            //Q11: What’s wrong with this “safe” code and how can we solve it ?
            string? s = null;
            //int x2 = int.Parse(s ?? "0");
            int x2 = int.TryParse(s, out int result)
                                        ? result
                                        : 0;
            Console.WriteLine(x2);
            //int.parse is not safe so we use ?? to avoid null exception 
            // became safe for just nulls not any invalid strings .


            //Q12: What happens here and if there is a problem, handle it
            string? s2 = null;
            //Console.WriteLine(s2!.Length);
            Console.WriteLine(s2?.Length ?? 0);
            // it just forgiven operator to make compiler can't send warning 
            //but it does not prevent NullReferenceException at runtime
            //Since s2 is actually null, accessing Length throws an exception.


            //Q13: What will this print ?
            string? s3 = null;
            int x3 = Convert.ToInt32(s3);
            Console.WriteLine(x3);
            // 0 cause  Convert class has guard from nulls 
            // can not send exception but print default value of data typy 


            //Q14: Compare results and explain each result :
            //string? s = null;

            // A
            // int a = int.Parse(s);      // a => null

            // B
            //int b = Convert.ToInt32(s);  // a => 0 , default value of data type(int)

            //Console.WriteLine(b);

            // a give  exception cause parse does not have guard from nulls like convert 



            //Q15: Complete the line to print "Guest" when user is null,
            //otherwise print the user name in uppercase:
            string? user = null;
            Console.WriteLine(user?.ToUpper() ?? "Guest");

        }
    }
}
