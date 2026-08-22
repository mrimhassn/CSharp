namespace CS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions

            // region is used to organize and group code into collapsible sections,
            //  making large code files easier to navigate and maintain.

            #region declarition
            var x = 20;
            #endregion


            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            // define data type by myself 
            int num = 10;
            string word = "ahmed";


            // IMPLICIT DECLARATION 
            // compiler define data type by itself 
            // dynamic compiler define data type in first time and don't change
            var n = 55;              // compiler infers int
            var name = "mohamed";   // infers string

            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //  
            //   - Value cannot change and safty 
            // ══════════════════════════════════════════════════════════════════════


            // Constant examples
            const double Pi = 3.14159;
            const double tau = 6.28318;


            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            //     - variable declared in class out methods in class level you can use
            //     variable in all methods in class ,but unavailable out class 


            //     - variable declared in method , you can use variable just in method ,
            //     when you use it out of method it occurs error  
            //
            //  EXAMPLE IN LINE 402
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.


            //      -variable available just in block out block occur error
            //
            // ══════════════════════════════════════════════════════════════════════
            // EXAMPLE 
            {
                int z = 20;
                if (z % 2 == 0)
                    Console.WriteLine($"{z} is Even");
                else
                    Console.WriteLine($"{z} is Odd");
            }
            //Console.WriteLine(z); // error

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.

            //      - how long a variable exists in memory
            //      - local : start when declared in method
            //                end when mmethod end 
            //      - static : Lives for entire app lifetime
            //
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            //      - responsible for freeing memory from objects no longer used 
            //      (did not have reference or unreachable)
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            //      -Shadowing occurs when a variable declared in an inner scope has
            //      the same name as one in an outer scope,
            //      temporarily "hiding" the outer variable.


            //      -no , doesn't allow in the same method 
            //
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //  1- start with a letter or _
            //  2- no spaces
            //  3- avoid keyword 
            //  4- case sensitive
            //  5- can not start with number
            //
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?

            //      -camelCase for a ,PascalCase for b and PascalCase or UPPERCASE for c
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Syntax Error
            //int x = ;  missing value
            //detected by compiler - program not run rntill fixed - syntax error 

            // Runtime Error
            int j = 0;
            int res = 5 / j;
            //while program is running - can crash program - handel with try-catch

            // Logical Error
            int result = 5 + 5; // supposed to be another calculation 
                                //no compiler error no exception - run but wrong result 

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            //    - prevent program from crashing 
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════

            try
            {
                int w = int.Parse("abc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Always runs");
            }

            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            /*      1- index out of rang => in arrays example 
             *      2- argument null exception => when passsed "null" to function 
             *      3- argument exception => invalid value 
             *      4- divide by zero => try to divide by zero 
             *      5- FormatException => wrong parsing
             */
            //
            // ══════════════════════════════════════════════════════════════════════
            #endregion


            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════
            try
            {
                int c = int.Parse("abc");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error");
            }
            catch (Exception)
            {
                Console.WriteLine("General error");
            }
            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════

            /*catch (Exception ex)
            {
                throw;     // preserves stack trace 
                           // throw ex;  - loses stack trace 
            }
            */
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            /*      - stack : exist for every thread  , work in LIFO ,
             *                when main end stack bacame empty .
                              (local variables - method parameters - reference variable 
                              return address - some value type )
                    - heap : large place from memory used to save dynamic data 
                             (objects - arrays - strings - boxing objects )    */

            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════


            int v = 77;
            int b = v;

            b = 80;

            Console.WriteLine(v); // didn't effect 
            Console.WriteLine(b);

            // ══════════════════════════════════════════════════════════════════════

            string refTest = "lolo";
            string refTest2 = refTest;   // copy reference

            refTest2 = "koko";

            Console.WriteLine(refTest); // effect
            Console.WriteLine(refTest2);

            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            /*      
             *      -base type from which all other types . It is the root type of the C# type hierarchy,
             *      and every type, primitive or complex is eventually derived from object.
             *      - Methods inherited from System.Object (ToString(), Equals(), GetHashCode(),GetType() ).
            */
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

        }
    }
    class Test
    {
        int classlevel = 20;

        void Method1()
        {
            int methodlevel = 25;

            Console.WriteLine(classlevel);  // available in method
            Console.WriteLine(methodlevel);
        }

        void Method2()
        {
            Console.WriteLine(classlevel);

            // Console.WriteLine(methodlevel);   
            // occur error cause its method level scope out its method occur error
        }
    }
}
