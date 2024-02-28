﻿
namespace Encapsulation_Polymorphism_Abstraction.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return Name + "-" + Author;
        }
    }
}
