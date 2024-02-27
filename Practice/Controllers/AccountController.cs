
using Practice.Services;

namespace Practice.Controllers
{
    internal class AccountController
    {
        private readonly AccountService accountService;

        public AccountController()
        {
            accountService = new AccountService();
        }

        public void Login()
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine(accountService.Login(email, password));
        }
    }
}
