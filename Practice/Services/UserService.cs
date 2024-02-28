using Encapsulation_Polymorphism_Abstraction.Models;

namespace Encapsulation_Polymorphism_Abstraction.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new User
                {
                id = 1,
                fullName = "Fatime Qayxanova",
                age = 22,
                email = "fatime@code.edu.az",
                password = "fatime123"
                },
                new User
                {
                id = 2,
                fullName = "Fexriyye Tagizade",
                age = 21,
                email = "fexriyye@code.edu.az",
                password = "fexriyye123"
                },
                new User
                {
                id = 3,
                fullName = "Emirastan Miriyev",
                age = 33,
                email = "emirastan@code.edu.az",
                password = "emirastan123"
                }

            };
        }

        public User GetById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);
        }
    }
}
