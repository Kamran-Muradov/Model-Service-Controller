
namespace Encapsulation_Polymorphism_Abstraction.Models
{
    internal class Bird : Animal
    {
        public string Color { get; set; }

        public override void Sound()
        {
            int a = 100;
            string b = "Resad";
            Console.WriteLine("Bird sound");
        }

        public override void Test()
        {
            Console.WriteLine("Tested");
        }
    }
}
