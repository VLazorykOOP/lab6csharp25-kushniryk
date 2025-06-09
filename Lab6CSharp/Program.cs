using LR5;
using LR6;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

void Task1()
{
    Exam exam = new Exam("Mathematics", 100, "2024-05-15", 60);
    GraduationExam graduationExam = new GraduationExam("Physics", 100, "2024-06-15", 120);
    Trial trial = new Trial("Chemistry", 50, "Practical", 30);

    exam.ConductTest();
    graduationExam.ConductTest();
    trial.ConductTest();
}
void Task2()
{
    Product[] products = new Product[]
        {
            new Toy("М'яч", 150.50, "ToyCorp", "Гума", 3),
            new Book("Програмування C#", 350.75, "Джон Доу", "TechBooks", 16),
            new SportsEquipment("Гантелі", 450.00, "SportMaster", 14),
            new Toy("Лялька", 250.25, "PlayFun", "Пластик", 4),
            new Book("Фізика", 280.00, "Джейн Сміт", "SciencePub", 12)
        };

    Console.WriteLine("Всі товари в базі:");
    Console.WriteLine();
    foreach (Product product in products)
    {
        product.DisplayInfo();
    }

    Console.WriteLine("\nПошук товарів за типом (toy, book, sports)");
    Console.Write("Введіть тип товару: ");
    string searchType = Console.ReadLine();

    Console.WriteLine($"\nЗнайдені товари типу '{searchType}':");
    Console.WriteLine();
    bool found = false;

    foreach (Product product in products)
    {
        if (product.IsType(searchType))
        {
            product.DisplayInfo();
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine("Товарів цього типу не знайдено!");
    }
}

void Task3()
{
    List<Product> products = new List<Product>();

    try
    {
        products.Add(new Toy("Машинка", 150, "Hasbro", "Пластик", 3));
        products.Add(new Book("Harry Potter", 300, "J.K. Rowling", "Bloomsbury", 12));
        
        products.Add(new SportsEquipment("М'яч", 200, "Adidas", -6));
        products.Add(new Toy("Робот", -100, "Lego", "Метал", 5));
    }
    catch (InvalidPriceException ex)
    {
        Console.WriteLine("Помилка ціни: " + ex.Message);
    }
    catch (InvalidAgeException ex)
    {
        Console.WriteLine("Помилка віку: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Загальна помилка: " + ex.Message);
    }

    Console.WriteLine("\nВсі продукти:");
    foreach (var p in products)
    {
        p.DisplayInfo();
    }

    //Приклад переповнення стека
    try
    {
        Toy toy = new Toy("М'яч", 100, "Lego", "Пластик", 3);

        Console.WriteLine(toy.RecursiveToy);
    }
    //Не перехопить
    catch (StackOverflowException ex)
    {
        Console.WriteLine("StackOverflow error: " + ex.Message);
    }
}

void Task4()
{
    Exam exam = new Exam("History", 80, "2024-04-20", 60);
    GraduationExam graduationExam = new GraduationExam("Biology", 90, "2024-07-10", 120);
    Trial trial = new Trial("Physics", 60, "Theoretical", 30);

    exam.ConductTest();
    graduationExam.ConductTest();
    trial.ConductTest();
}

Task3();