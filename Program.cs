using System;
using System.IO;

class CakeOrder
{
    private string form;
    private string razmer;
    private string vkus;
    private string glaze;
    private string decor;
    private float totalPrice;
    private DateTime ZakazTime;

    public void zakaz()
    {
        int position = 1;
        while (true)
        {
            Menu();
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                break;

            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position > 1)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position < 6)
                {
                    position++;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                break;
            }
            if (key.Key == ConsoleKey.Escape)
                break;
                if (position == 1)
            {
                CakeForma();
            }
            else if (position == 2)
            {
                CakeRazmer();
            }
            else if (position == 3)
            {
                CakeVkus();
            }
            else if (position == 4)
            {
                CakeGlaze();
            }
            else if (position == 5)
            {
                CakeDecor();
            }
            else if (position == 6)
            {
                FinishZakaz();
                break;

            }
        }
    }
    private void Menu()
    {
        Console.WriteLine("Заказ торта:");
        Console.WriteLine("  1. Форма торта: " + form);
        Console.WriteLine("  2. Размер торта: " + razmer);
        Console.WriteLine("  3. Вкус торта: " + vkus);
        Console.WriteLine("  4. Глазурь торта: " + glaze);
        Console.WriteLine("  5. Декор торта: " + decor);
        Console.WriteLine("  6. Завершить заказ и сохранить");
        Console.WriteLine("  ESC. Выход из заказа");
    }

    private void CakeForma()
    {
        Console.Clear();
        Console.WriteLine("Выберите форму торта:");
        Console.WriteLine("  1. Круг - 100рублей");
        Console.WriteLine("  2. Квадрат - 100рублей");
        Console.WriteLine("  3. Ромб - 120рублей");
        Console.WriteLine("  4. Сердечко - 150рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                form = "круг";
                totalPrice += 100;
            }
            else if (position == 2)
            {
                form = "Квадрат";
                totalPrice += 100;
            }
            else if (position == 3)
            {
                form = "Ромб";
                totalPrice += 120;
            }
            else if (position == 4)
            {
                form = "Сердечко";
                totalPrice += 150;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }

    private void CakeRazmer()
    {
        Console.Clear();
        Console.WriteLine("Выберите размер торта:");
        Console.WriteLine("  1. Маленький - 150рублей");
        Console.WriteLine("  2. Средний - 250рублей");
        Console.WriteLine("  3. Большой - 500рублей");
        Console.WriteLine("  ESC. Выход из раздела");

        int position = 1;

        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 3)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                razmer = "маленький";
                totalPrice += 150;
            }

            else if (position == 2)
            {
                razmer = "средний";
                totalPrice += 250;
            }
            else if (position == 3)
            {
                razmer = "большой";
                totalPrice += 500;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
    private void CakeVkus()
    {
        Console.Clear();
        Console.WriteLine("Выберите вкус торта:");
        Console.WriteLine("  1. Шоколадный - 220рублей");
        Console.WriteLine("  2. Ванильный - 160рублей");
        Console.WriteLine("  3. Клубничный - 200рублей");
        Console.WriteLine("  4. Малиновый - 220рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;

        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                vkus = "шоколадный";
                totalPrice += 220;
            }

            else if (position == 2)
            {
                vkus = "ванильный";
                totalPrice += 160;
            }
            else if (position == 3)
            {
                vkus = "клубничный";
                totalPrice += 200;
            }
            else if (position == 4)
            {
                vkus = "Малиновый";
                totalPrice += 220;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
    private void CakeGlaze()
    {
        Console.Clear();
        Console.WriteLine("Введите глазурь торта:");
        Console.WriteLine("  1. Шоколадка - 100рублей");
        Console.WriteLine("  2. Молочная глазурь - 80рублей");
        Console.WriteLine("  3. Бананчик - 100рублей");
        Console.WriteLine("  4. Апельсин - 150рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;

        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                glaze = "шоколадка";
                totalPrice += 100;
            }

            else if (position == 2)
            {
                glaze = "молочная глазурь";
                totalPrice += 160;
            }
            else if (position == 3)
            {
                glaze = "бананчик";
                totalPrice += 200;
            }
            else if (position == 4)
            {
                glaze = "апельсин";
                totalPrice += 220;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
    private void CakeDecor()
    {
        Console.Clear();
        Console.WriteLine("Введите декор торта:");
        Console.WriteLine("  1. Крем-брюле - 180рублей");
        Console.WriteLine("  2. Ягодки - 200рублей");
        Console.WriteLine("  3. Кокакола - 150рублей");
        Console.WriteLine("  4. Пепся - 150рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                decor = "крем-брюле";
                totalPrice += 180;
            }

            else if (position == 2)
            {
                decor = "ягодки";
                totalPrice += 200;
            }
            else if (position == 3)
            {
                decor = "кокакола";
                totalPrice += 150;
            }
            else if (position == 4)
            {
                decor = "пепся";
                totalPrice += 150;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
    private void FinishZakaz()
    {
        Console.Clear();
        Console.WriteLine("Заказ завершен!");
        Console.WriteLine("Итоговая цена: " + totalPrice + " руб.");
        ZakazTime = DateTime.Now;
        Console.WriteLine("Время заказа: " + ZakazTime);

        string filePath = "Tortik.txt";
        string txt = "1)Форма торта:" + form + "\t 2)Размер торта:" + razmer + "\t 3)Вкус торта:" + vkus + "\t 4)Глазурь торта:" + glaze + "\t 5)Декор торта:" + decor + "\t Итоговая цена:" + totalPrice + "рублей" + "\t Время заказа:" + ZakazTime;
        File.AppendAllText(filePath, txt);
        Console.WriteLine("Заказ сохранен в файле tortik.txt");
    }
}

class Program
{
    static void Main()
    {
        CakeOrder cakeOrder = new CakeOrder();
        cakeOrder.zakaz();
    }
}