using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Exceptions
{
    internal class CustomException
    {
        public static void CustomException1()
        {
            try
            {
                Console.WriteLine("Enter the age ");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible for vote");
                }
                else
                {
                    throw new InvalidAgeException("You are not eligible for vote");
                }
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CustomException2()
        {

            Console.WriteLine("=== Welcome to bank system ===");
            int balance = 1000;
            Console.WriteLine("1.deposite");
            Console.WriteLine("2.Withdraw");
            int  n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Console.WriteLine("Enter amount to deposite and You Available Balance = " + balance);
                int amount = int.Parse(Console.ReadLine());
                int deposite = amount + balance;
                Console.WriteLine("Deposite Successful..! Available Balance = " + deposite);
            }
            try
            {
                if (n == 2)
                {
                    Console.WriteLine("Enter amount to withdraw and You Available Balance = " + balance);
                    int amount = int.Parse(Console.ReadLine());
                    if (amount <= balance)
                    {
                        int withdraw = balance - amount;
                        Console.WriteLine("Withdraw Successful..! Available Balance = " + withdraw);
                    }
                    else
                    {
                        throw new InsufficientBalanceException("Insufficient Balance");
                    }
                }
            }
            catch(InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
