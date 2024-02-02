using Bank.Models;
using Bank.Models.DTOs;
using Bank.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bank.Controllers
{
    public class HomeController : Controller
    {
        /*        public static BankAccount Account1 = new BankAccount(1, "melat", 123456789, 100, 12);
                public static BankAccount Account2 = new BankAccount(1, "meli", 987654321, 200, 13);
                public static User u1 = new User(1, "vahid", 300);
                public static BankAccount Account3 = new BankAccount(1, "melat", 456789123, 300, 14);
                public static BankAccount Account4 = new BankAccount(1, "meli", 123789456, 400, 15);
                public static User u2 = new User(2, "ali", 700);


                public static List<User> Users = new List<User>()
                {
                    u1,
                    u2
                };*/
        public static TranslateMoneycs obj = new TranslateMoneycs();
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
            Data.Data.init();
            return View(Data.Data.Users);
        }
        [HttpPost]
        public IActionResult Login(int id)
        {
            Data.Data.init();
            return RedirectToAction("SelectTranslate");
        }
        [HttpGet]
        public IActionResult SelectTranslate(int id)
        {
            Data.Data.init();
            var user1= Data.Data.Users.Where(u=>u.Id==id).FirstOrDefault();
            obj.userMabda = user1;
            return View();
        }
        [HttpPost]
        public IActionResult SelectTranslate(long NumberOfCardMaghsad, double money, long NumberOfCardMabda)
        {
            Data.Data.init();
            for (int i = 0; i < Data.Data.Users.Count; i++)
            {
                var hastyanist1 = Data.Data.Users[i].BankAccounts.Any(u => u.NumberAccount == NumberOfCardMaghsad);
                if (hastyanist1 == true)
                {
                    obj.userMaghsad = Data.Data.Users[i];
                    break;
                }
            }
            obj.kasrazHesab(money, NumberOfCardMabda, NumberOfCardMaghsad);
            return View();
        }
        public IActionResult Shopping()
        {

            return View();
        }




















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}