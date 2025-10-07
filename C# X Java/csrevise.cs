// How to compile and run this code from the command line:
// 1. Make sure you have the .NET SDK installed.
// 2. Open a terminal or command prompt.
// 3. Navigate to the directory where this file is saved (d:/JavaLearn).
// 4. To run the file, execute the following command: dotnet run --project . CSharpConcepts.cs
//    (This command compiles and runs the C# file directly)

using System;
using System.Linq; // We need this for easy array slicing functions like Take() and Skip().

namespace CSharpLearning
{
    class Program
    {
        // --- 1. FUNCTIONS ---
        // A function is a reusable block of code that performs a specific task.
        // This function is defined once and can be called (used) many times.
        // It takes two integers as input (parameters 'a' and 'b') and returns their sum.
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- C# Core Concepts Demonstration ---");

            // --- Using a Function ---
            Console.WriteLine("\n--- 1. Function Example ---");
            // Here we call the 'AddNumbers' function with the values 5 and 7.
            int sum = AddNumbers(5, 7);
            Console.WriteLine("Calling AddNumbers(5, 7). The result is: " + sum);


            // --- 2. ARRAYS AND SLICING ---
            Console.WriteLine("\n--- 2. Array and Slicing Example ---");
            // An array is a fixed-size collection of elements of the same type.
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            // "Slicing" means getting a portion of the array.
            // Using LINQ is a common way to do this.
            // Example A: Get the first 3 elements.
            int[] firstThree = numbers.Take(3).ToArray();
            Console.WriteLine("Slice (first 3 elements): " + string.Join(", ", firstThree));

            // Example B: Skip the first 2 elements and take the rest.
            int[] afterTwo = numbers.Skip(2).ToArray();
            Console.WriteLine("Slice (skip first 2 elements): " + string.Join(", ", afterTwo));


            // --- 3. RANDOM NUMBER GENERATOR ---
            Console.WriteLine("\n--- 3. Random Number Example ---");
            // The 'Random' class is used to create random numbers.
            Random randomGenerator = new Random();
            // .Next(min, max) generates a number from min up to (but not including) max.
            int randomNumber = randomGenerator.Next(1, 101); // Generates a random number between 1 and 100.
            Console.WriteLine("A random number between 1 and 100: " + randomNumber);


            // --- 4. CONDITIONAL STATEMENTS (IF-ELSE) ---
            Console.WriteLine("\n--- 4. Conditional (if-else) Example ---");
            // 'if-else' statements allow your program to make decisions.
            if (randomNumber > 50)
            {
                Console.WriteLine("The random number is greater than 50.");
            }
            else if (randomNumber == 50)
            {
                Console.WriteLine("The random number is exactly 50.");
            }
            else
            {
                Console.WriteLine("The random number is less than or equal to 50.");
            }


            // --- 5. FOR LOOP ---
            Console.WriteLine("\n--- 5. For Loop Example ---");
            // A 'for' loop is used when you want to repeat a block of code a specific number of times.
            // This loop will run 5 times.
            Console.WriteLine("Counting from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("This is iteration number: " + i);
            }


            // --- 6. WHILE LOOP ---
            Console.WriteLine("\n--- 6. While Loop Example ---");
            // A 'while' loop repeats a block of code as long as a condition is true.
            int counter = 0;
            Console.WriteLine("Looping while counter is less than 3:");
            while (counter < 3)
            {
                Console.WriteLine("The counter is now: " + counter);
                counter++; // IMPORTANT: You must change the variable in the condition, or the loop will run forever!
            }

            Console.WriteLine("\n--- End of Demonstration ---");
        }
    }
}
