using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 70, rubToUah = 3, uahToUsd = 27;
            float rub;
            float usd;
            float uah;
            string userInput;
            float countCurrency;
            bool enterOrExit = true;

            Console.WriteLine("Добро пожаловать в обменник валют, у нас можно обменять рубли, доллары и гривны");

            Console.Write("Введите баланс рублей : ");
            rub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс долларов : ");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс гривен : ");
            uah = Convert.ToSingle(Console.ReadLine());

            while (enterOrExit)
            {
                Console.WriteLine("1 - обменять рубли на доллары или гривны");
                Console.WriteLine("2 - обменять гривны на рубли или доллары");
                Console.WriteLine("3 - обменять доллары на рубли или гривны");
                Console.WriteLine("4 - выход");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("1 - обменять рубли на доллары ");
                        Console.WriteLine("2 - обменять рубли на гривны");
                        userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("Обмен рублей на доллары");
                                Console.Write("Сколько вы хотите обменять? : ");
                                countCurrency = Convert.ToSingle(Console.ReadLine());

                                if (rub >= countCurrency)
                                {
                                    rub -= countCurrency;
                                    usd += countCurrency / rubToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("Не допустимое кол-во рублей");
                                }
                                break;

                            case "2":

                                Console.WriteLine("Обмен рублей на гривны");
                                Console.Write("Сколько вы хотите обменять? : ");
                                countCurrency = Convert.ToSingle(Console.ReadLine());
                                countCurrency = Convert.ToSingle(Console.ReadLine());
                                if (rub >= countCurrency)
                                {
                                    rub -= countCurrency;
                                    uah += countCurrency / rubToUah;
                                }
                                else
                                {
                                    Console.WriteLine("Не допустимое кол-во рублей");
                                }
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("1 - обменять гривен на доллары ");
                        Console.WriteLine("2 - обменять гривен на рубли");
                        userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("Обмен гривен на доллары");
                                Console.Write("Сколько вы хотите обменять? : ");

                                countCurrency = Convert.ToSingle(Console.ReadLine());

                                if (uah >= countCurrency)
                                {
                                    uah -= countCurrency;
                                    usd += countCurrency / uahToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("Не допустимое кол-во гривен");
                                }
                                break;

                            case "2":
                                Console.WriteLine("Обмен гривен на рубли");
                                Console.Write("Сколько вы хотите обменять? : ");
                                countCurrency = Convert.ToSingle(Console.ReadLine());
                                countCurrency = Convert.ToSingle(Console.ReadLine());
                                if (uah >= countCurrency)
                                {
                                    uah -= countCurrency;
                                    rub += countCurrency / rubToUah;
                                }
                                else
                                {
                                    Console.WriteLine("Не допустимое кол-во гривен");
                                }
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("1 - обменять долларов на гривны ");
                        Console.WriteLine("2 - обменять долларов на рубли");
                        userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("Обмен долларов на гривны");
                                Console.Write("Сколько вы хотите обменять? : ");
                                countCurrency = Convert.ToSingle(Console.ReadLine());
                                countCurrency = Convert.ToSingle(Console.ReadLine());
                                if (usd >= countCurrency)
                                {
                                    usd -= countCurrency;
                                    uah += countCurrency * uahToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("Не допустимое кол-во долларов");
                                }
                                break;

                            case "2":
                                Console.WriteLine("Обмен долларов на рубли");
                                Console.Write("Сколько вы хотите обменять? : ");

                                countCurrency = Convert.ToSingle(Console.ReadLine());

                                if (usd >= countCurrency)
                                {
                                    usd -= countCurrency;
                                    rub += countCurrency * rubToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("Не допустимое кол-во долларов");
                                }
                                break;
                        }
                        break;
                    case "4":
                        enterOrExit = false;
                        break;
                }
                Console.WriteLine($"Ваш баланс : {rub} рублей, {usd} долларов, {uah} гривен.");
            }
        }
    }
}
