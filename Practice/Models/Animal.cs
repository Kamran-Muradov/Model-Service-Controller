
namespace Encapsulation_Polymorphism_Abstraction.Models
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public Animal()
        {

        }

        public abstract void Test();
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
