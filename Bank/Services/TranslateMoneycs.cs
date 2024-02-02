using Bank.Models;

namespace Bank.Services
{
    public class TranslateMoneycs
    {
        public User userMabda { get; set; }
        public User userMaghsad{ get; set; }
        
        public void Claculatedarai(double bank1, double bank2)
        {
            userMabda.TotalCredit = bank1 + bank2;
        }
        public void kasrazHesab(double  mablagh, long nmada, long nmaghsad)
        {
            Data.Data.init();
            var bankfe = userMabda.BankAccounts.Where(u => u.NumberAccount == nmada).FirstOrDefault();
            if (bankfe.Cerdit > mablagh)
            {
                bankfe.Cerdit -= mablagh;
                userMabda.TotalCredit -= mablagh;
                var bankge= userMaghsad.BankAccounts.Where(u => u.NumberAccount == nmaghsad).FirstOrDefault();
                bankge.Cerdit += mablagh;
                userMaghsad.TotalCredit += mablagh;
            }
        }
    }
}
