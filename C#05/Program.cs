
using System;
using System.ComponentModel;
using System.Reflection;

namespace C305
{
    internal class Program
    {
        #region q2
        class Person
        {
            public string Name { get; set; }
        }
        #endregion

        #region q3
        //static void sum_sub(int num1, int num2, out int sum, out int sub)
        //{
        //    sum = num1 + num2;
        //    sub = num1 - num2;
        //}
        #endregion

        #region Q4
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region Q5
        //static bool IsPrime(int number)
        //{
        //    if (number < 2) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //}

        #endregion

        #region q6

        //static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    if (arr == null || arr.Length == 0)
        //        throw new ArgumentException("Array must not be null or empty.");

        //    min = arr[0];
        //    max = arr[0];

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max) max = arr[i];
        //        if (arr[i] < min) min = arr[i];
        //    }
        //}

        #endregion


        #region q7
        //static long Factorial(int number)
        //{

        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion

        #region q8
        static string ChangeChar(string input, int position, char newChar)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input string cannot be null or empty.");
            if (position < 0 || position >= input.Length)
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }

        #endregion




        static void Main(string[] args)
        {
            #region 1- Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.

            //  Explain the difference between passing value type parameters by value and by reference:
            // 1.Passing by Value:
            // When a parameter is passed by value, a copy of the variable is passed to the method.

            //  Any changes made inside the method do not affect the original variable.

            //  This is the default behavior for value types (like int, float, bool, etc.).

            //  2.Passing by Reference:
            // When a parameter is passed by reference, the method receives a reference to the original variable.

            //Any changes made inside the method do affect the original variable.

            // In C#, the ref or out keyword is used to pass by reference.

            //static void PassByValue(int number)

            //{
            //    number = 100;
            //}
            //static void PassByReference(ref int number)
            //{
            //    number = 100;
            //}

            //int a = 10;
            //int b = 10;

            //PassByValue(a);
            //Console.WriteLine("After ChangeByValue: " + a);

            //PassByReference(ref b);
            //Console.WriteLine("After ChangeByReference: " + b);


            #endregion


            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //Passing by Value sends a copy of the variable, so changes inside the method don’t affect the original.

            // Passing by Reference(ref/out) sends the actual variable, so changes inside the method affect the original value.

            //void ChangeByValue(Person p)
            //{
            //    p.Name = "Alice";  
            //    p = new Person();   
            //    p.Name = "Changed"; 
            //}

            //void ChangeByReference(ref Person p)
            //{
            //    p.Name = "Bob";         
            //    p = new Person();      
            //    p.Name = "Completely Changed";
            //}
            #endregion


            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


            //bool flag01, flag02;
            //int num1, num2, sum, sub;
            //do
            //{
            //    Console.WriteLine("Enter first number:");
            //    flag01 = int.TryParse(Console.ReadLine(), out num1);
            //    Console.WriteLine("Enter second number:");
            //    flag02 = int.TryParse(Console.ReadLine(), out num2);
            //}
            //while (!(flag01 && flag02));
            //sum_sub(num1, num2, out sum, out sub);
            //Console.WriteLine($"sum={sum}");
            //Console.WriteLine($"sub={sub}");
            #endregion




            #region  4-   Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.



            //bool flag01;
            //int num1,result;
            //do
            //{
            //    Console.WriteLine("Enter first number:");
            //    flag01 = int.TryParse(Console.ReadLine(), out num1);

            //}
            //while (!(flag01)); 
            //result = SumOfDigits(num1);


            #endregion


            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.WriteLine("Enter first number:");
            #endregion




            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


            //bool flag01;
            //int size, min = 0, max = 0;
            //do
            //{
            //    Console.WriteLine("Enter size:");
            //    flag01 = int.TryParse(Console.ReadLine(), out size);
            //}
            //while (!flag01 || size <= 0);

            //int[] numbers = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter number:");
            //        flag01 = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    }
            //    while (!flag01);
            //}
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Min={min}");
            //Console.WriteLine($"Max={max}");
            #endregion

            #region 7-Create an iterative(non - recursive) function to calculate the factorial of the number specified as parameter

            //int number;
            //long fact = 0;
            //console.WriteLine(value:"Enter a number to calculate its factorial:");
            //int.TryParse(Console.ReadLine(), out number);
            //fa = Factorial(number);
            //console.WriteLine(value:$"Factorial of {number} is {fact}");



            #endregion


            #region 8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            string s = "hello";
            string result = ChangeChar(s, 1, 'a'); // النتيجة: "hallo"
            Console.WriteLine(result);
            #endregion
        }
    }
}