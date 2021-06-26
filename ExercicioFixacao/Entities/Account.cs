using System;
using ExercicioFixacao.Entities.Exceptions;

namespace ExercicioFixacao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double limit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = limit;
        }

        public void Deposit(double amount)
        {
            if(amount <= 0.0)
            {
                throw new DomainException("Error on deposit: the deposit amount has to be more than zero.");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Error on withdraw: the amount exceeds withdraw limit.");
            }
            if (amount > Balance || Balance == 0.0)
            {
                throw new DomainException("Error on withdraw: not enought balance.");
            }
           
            Balance -= amount;
        }
    }
}
