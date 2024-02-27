
using Practice.Helpers;

namespace Practice.Services
{
    internal class AccountService
    {
        private readonly UserService userService;

        public AccountService()
        {
            userService = new UserService();
        }


        public string Login(string email, string password)
        {
            var users = userService.GetAll();

            if (users.Any(m => m.email == email && m.password == password))
            {
                return LoginMessages.Success;
            }
            return LoginMessages.Error;
        }
    }
}
