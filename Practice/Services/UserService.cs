using Practice.Models;

namespace Practice.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                id = 1,
                fullName = "Test Testov",
                age = 23,
                email = "test@gmail.com",
                password = "test12223234"
            };
            User user2 = new()
            {
                id = 2,
                fullName = "Test2 Testzade",
                age = 30,
                email = "testzade@gmail.com",
                password = "12234556"
            };
            User user3 = new()
            {
                id = 3,
                fullName = "Test3 Testov3 ",
                age = 27,
                email = "kamran@gmail.com",
                password = "123435test"
            };
            User user4 = new()
            {
                id = 4,
                fullName = "Test4 Testzade4",
                age = 49,
                email = "test4@mail.ru",
                password = "3434535testt4"
            };

            User[] users = { user1, user2, user3, user4, };
            return users;
        }

        public User GetById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);
        }
    }
}
