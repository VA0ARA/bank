using Bank.Models;
using Bank.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bank.Controllers
{
    public class HomeController : Controller
    {
        public static BankAccount Account1 = new BankAccount(1, "melat", 123456789, 100, 12);
        public static BankAccount Account2 = new BankAccount(1, "meli", 987654321, 200, 13);
        public static User u1 = new User(1, "vahid", 300);
        public static BankAccount Account3 = new BankAccount(1, "melat", 456789123, 300, 14);
        public static BankAccount Account4 = new BankAccount(1, "meli", 123789456, 400, 15);
        public static User u2 = new User(2, "ali", 700);
        public static TranslateMoneycs obj = new TranslateMoneycs();

        public static List<User> Users = new List<User>()
        {
            u1,
            u2
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View(Users);
        }
        [HttpPost]
        public IActionResult Login(int id)
        {
            return RedirectToAction("SelectTranslate");
        }
        public IActionResult SelectTranslate(int id)
        {
            var user1=Users.Where(u=>u.Id==id).FirstOrDefault();
            obj.userMabda = user1;
            return View();
        }
        [HttpPost]
        public IActionResult SelectTranslate(long NumberOfCardMaghsad,double money,long NumberOfCardMabda)
        {
            for(int i = 0; i < Users.Count; i++)
            {
                var hastyanist1 = Users[i].BankAccounts.Any(u => u.NumberAccount == NumberOfCardMaghsad);
                if (hastyanist1 == true)
                {
                    obj.userMaghsad = Users[i];
                    break;
                }
            }
/*            for(int i = 0; i < obj.userMabda.BankAccounts.Count; i++)
            {
                var shomare = obj.userMabda.BankAccounts.Any(u => u.NumberAccount == NumberOfCardMabda);
            }*/
            obj.kasrazHesab(money, NumberOfCardMabda, NumberOfCardMaghsad);
                return View();
        }
        public IActionResult Shopping() {
        
        return View();  
        }




















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}