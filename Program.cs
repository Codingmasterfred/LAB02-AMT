using System;

namespace LAB02_AMT
{
    public static class Program
    {
        public static decimal Balance;

        public static void Main(string[] args)
        {
            UserInterface();
        }

        static void UserInterface() 
        {
             
            for (int i = 0; i < 4; i++)
            {

            Console.WriteLine("Press 1 to see balance");
            Console.WriteLine("Press 2 to see Withdraw");
            Console.WriteLine("Press 3 to see Deposit");
            Console.WriteLine("Press 4 to exit session");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            if (input == 1)
            {
             Balance = ViewBalance(Balance);
            }
            else if (input == 2)
            {
                    if (Balance != 0)
                    {
                        Console.Write("How much would you like to withdraw: ");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());

                        if (withdraw > Balance)
                        {
                            Console.WriteLine("Insufficient funds. Cannot withdraw more than the available balance");
                        }
                        else
                        {
                            Withdraw(Balance, withdraw);
                            Console.WriteLine("Your new balance is " + Balance);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
            }
            else if(input == 3)
            {

                    Console.Write("How much would you like to deposit: ");
                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                    if (deposit > 0)
                    {
                        
                        Balance = Deposit(Balance,deposit);
                        Console.WriteLine("Your new balance is " + Balance);
                    }
                    else
                    {
                        Console.Write("Deposit has to be greater than $0");
                    }

            }
            else if(input == 4)
            {
                return;
            }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            
        }

        static decimal ViewBalance(decimal Balance)
        {
            
            Console.WriteLine("Your balance is " + Balance);
            return Balance;
        }

        static decimal Withdraw(decimal balance, decimal withdraw)
        {
            balance -= withdraw;
            Balance = balance;
            return balance;
        }

        static decimal Deposit(decimal Balance , decimal deposit )
        {
            Balance += deposit;
            return Balance;

        }
        public static decimal TestForBalance(decimal Balance)
        {
            return ViewBalance(Balance);
        }
        public static decimal TestForWithdraw(decimal DemicalBalance, decimal WithdrawAmount) 
        { 
            return  Withdraw(DemicalBalance, WithdrawAmount) ;
        }
        public static decimal TestForDeposit(decimal DemicalBalance ,decimal DemicalDepositData)
        {
            return  Deposit(DemicalBalance ,DemicalDepositData);
        }
    }
}