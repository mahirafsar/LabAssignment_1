﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    class Account
    {
        private  static int accountNumber=10001;
        private string accountName;
        private double balance;
        private Address address;   //creating Association(HAS-A Relation)

        static int AccNumber()
        {
            return accountNumber++;
        }

        public Account(string accountName, double balance, Address address)
        {
            //accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { accountNumber = value; }
            get { return accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine(amount + " Taka Deposit Done");

            Console.WriteLine();
        }
        public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                Console.WriteLine(amount + " Taka Withdraw Done");
                //this.ShowInformation();
                Console.WriteLine();
                //return true;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
                //return false;
            }
        }

        public void Transfer(Account a, double amount)
        {

            if (this.balance >= amount)
            {
                this.balance += amount;
                a.balance -= amount;
                Console.WriteLine("Account of " + this.accountName + " becomes $ " + this.balance);
                Console.WriteLine("Account of " + a.accountName + " becomes $ " + a.balance);

            }
            else
            {
                Console.WriteLine("Transfer fails");
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nAccount Balance:{2}",AccNumber(), this.accountName, this.balance);
            this.address.PrintAddress();
        }



    }
}
