using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Exceptions
{
    public class ExceptionPrograms
    {
        public static void Exception1()
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Exception2()
        {
            try
            {
                int age = int.Parse("ABC");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Exception3()
        {
            try
            {
                int[] arr = { 10, 20, 30 };
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Exception4()
        {
            try
            {
                string n = null;
                Console.WriteLine(n.Length);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Exception5()
        {
            try
            {
                File.ReadAllText("abc.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Exception6()
        {
            try
            {
                Stack<int> stack = new Stack<int>();
                stack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
