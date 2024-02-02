namespace Bank.Models
{
    public class BankAccount
    {
        public int  Id { get; set; }  
        public string Name { get; set; }    
        public long  NumberAccount { get; set; }
        public double Cerdit { get; set; }
        public int CCV { get; set; }

        public BankAccount(int id , string name,long number,double Credit, int ccv) {
        
            this.Id = id;
            this.Name = name;
            this.NumberAccount = number;
            this.Cerdit = Credit;
            this.CCV = ccv;
        }    
    }
}
