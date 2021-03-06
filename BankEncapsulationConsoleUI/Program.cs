﻿using System;

namespace BankEncapsulationConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much $$ do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance,0:c}");
        

            PersonalInfo info = new PersonalInfo();

            Console.Write("Hello, please provide your phone number: ");
            info.NumberFormatted = Console.ReadLine();

            Console.WriteLine($"\nThis is your number correctly formatted: {info.NumberFormatted}");

         }
    }
}
