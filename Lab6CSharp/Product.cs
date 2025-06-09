using LR6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    interface Product
    {
        string Name { get; set; }
        double Price { get; set; }
        int Age { get; set; }

        void DisplayInfo();
        bool IsType(string type);
    }

    class Toy : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }

        private string Manufacturer { get; set; }
        private string Material { get; set; }

        //StackOverflowException
        private Toy recursiveToy;
        public Toy RecursiveToy
        {
            get { return RecursiveToy; }
            set { recursiveToy = value; }
        }

        public Toy(string name, double price, string manufacturer, string material, int age)
        {
            if (price < 0) throw new InvalidPriceException("Ціна не може бути від’ємною.");
            if (age < 0) throw new InvalidAgeException("Вік не може бути від’ємним.");

            Name = name;
            Price = price;
            Age = age;

            Manufacturer = manufacturer;
            Material = material;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Іграшка: {Name}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Виробник: {Manufacturer}");
            Console.WriteLine($"Матеріал: {Material}");
            Console.WriteLine($"Вік: {Age}+");
            Console.WriteLine();
        }

        public  bool IsType(string type)
        {
            return type.ToLower() == "toy";
        }
    }

    class Book : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }

        private string Author { get; set; }
        private string Publisher { get; set; }

        public Book(string name, double price, string author, string publisher, int age)
        {
            if (price < 0) throw new InvalidPriceException("Ціна не може бути від’ємною.");
            if (age < 0) throw new InvalidAgeException("Вік не може бути від’ємним.");

            Name = name;
            Price = price;
            Age = age;

            Author = author;
            Publisher = publisher;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Name}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Видавництво: {Publisher}");
            Console.WriteLine($"Вік: {Age}+");
            Console.WriteLine();
        }

        public bool IsType(string type)
        {
            return type.ToLower() == "book";
        }
    }

    class SportsEquipment : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }

        private string Manufacturer { get; set; }

        public SportsEquipment(string name, double price, string manufacturer, int age)
        {
            if (price < 0) throw new InvalidPriceException("Ціна не може бути від’ємною.");
            if (age < 0) throw new InvalidAgeException("Вік не може бути від’ємним.");

            Name = name;
            Price = price;
            Age = age;

            Manufacturer = manufacturer;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Спортивний інвентар: {Name}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Виробник: {Manufacturer}");
            Console.WriteLine($"Вік: {Age}+");
            Console.WriteLine();
        }

        public bool IsType(string type)
        {
            return type.ToLower() == "sports";
        }
    }
}
