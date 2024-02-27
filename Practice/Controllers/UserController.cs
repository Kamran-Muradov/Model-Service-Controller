
using Practice.Services;

namespace Practice.Controllers
{
    internal class UserController
    {
        private readonly UserService userService;

        public UserController()
        {
            userService = new UserService();
        }

        public void GetAll()
        {
            var users = userService.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.id} Fullname: {user.fullName} Age: {user.age}");
            }
        }

        public void GetById(int id)
        {
            var user = userService.GetById(userService.GetAll(), id);

            Console.WriteLine(user != null ? $"Id: {user.id} Fullname: {user.fullName} Age: {user.age}" : "User does not exist");
        }
    }
}
