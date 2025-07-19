
using System;
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
        static void sum_sub(int num1, int num2, out int sum, out int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
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


            bool flag01, flag02;
            int num1, num2, sum, sub;
            do
            {
                Console.WriteLine("Enter first number:");
                flag01 = int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Enter second number:");
                flag02 = int.TryParse(Console.ReadLine(), out num2);
            }
            while (!(flag01 && flag02));
            sum_sub(num1, num2, out sum, out sub);
            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"sub={sub}");


            #region


            #endregion


        }
    }
}