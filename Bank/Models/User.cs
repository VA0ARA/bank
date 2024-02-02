namespace Bank.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double  TotalCredit { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

        public User (int Id , string Name, double TotalCredit)
        {
            this.Id = Id;   
            this.Name = Name;
            this.TotalCredit = TotalCredit;
        }

    }
}
