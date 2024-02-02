using Bank.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Bank.Data
{
    public static  class Data
    {
        public static BankAccount Account1 = new BankAccount(1, "melat", 123456789, 100, 12);
        public static BankAccount Account2 = new BankAccount(1, "meli", 987654321, 200, 13);
        public static User u1 = new User(1, "vahid", 300);
        public static BankAccount Account3 = new BankAccount(1, "melat", 456789123, 300, 14);
        public static BankAccount Account4 = new BankAccount(1, "meli", 123789456, 400, 15);
        public static User u2 = new User(1, "ali", 700);
        public static List<User> Users;

        public static void init()
        {
            u1.BankAccounts = new List<BankAccount>();
            u1.BankAccounts.Add(Account1);
            u1.BankAccounts.Add(Account2);
            u2.BankAccounts = new List<BankAccount>();
            u2.BankAccounts.Add(Account3);
            u2.BankAccounts.Add(Account4);

        Users= new List<User>()
        {
            u1,
            u2
        };
    }


    }
}
