using System;

namespace oop_lab_1
{
    internal class Program
    {
        static void Main()
        {
            Video_games[] games = new Video_games[10];
            int gameCount = 0;
            int doChoice;

            do
            {
                Console.WriteLine("\nМЕНЮ");
                Console.WriteLine("1 - Додати гру");
                Console.WriteLine("2 - Переглянути ігри");
                Console.WriteLine("3 - Вийти");
                Console.Write("Ваш вибір: ");

                if (!int.TryParse(Console.ReadLine(), out doChoice))
                {
                    Console.WriteLine("Потрібно ввести число!");
                    continue;
                }

                switch (doChoice)
                {
                    case 1:
                        if (gameCount < games.Length)
                        {
                            Video_games game = AddGame();

                            if (game != null)
                            {
                                games[gameCount] = game;
                                gameCount++;

                                Console.WriteLine("Гру успішно додано!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Масив ігор заповнений!");
                        }

                        break;

                    case 2:
                        if (gameCount == 0)
                        {
                            Console.WriteLine("Ігор ще немає.");
                            break;
                        }

                        Console.WriteLine("\n========== СПИСОК ІГОР ==========");

                        for (int i = 0; i < gameCount; i++)
                        {
                            Console.WriteLine($"{i + 1} - {games[i].Name}");
                        }

                        Console.WriteLine("0 - Повернутися до меню");
                        Console.Write("Оберіть гру: ");

                        if (!int.TryParse(Console.ReadLine(), out int gameChoice))
                        {
                            Console.WriteLine("Потрібно ввести число!");
                            break;
                        }

                        if (gameChoice == 0)
                        {
                            break;
                        }

                        if (gameChoice >= 1 && gameChoice <= gameCount)
                        {
                            games[gameChoice - 1].ShowInfo();
                        }
                        else
                        {
                            Console.WriteLine("Некоректний номер гри!");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Програму завершено.");
                        break;

                    default:
                        Console.WriteLine("Некоректний вибір!");
                        break;
                }

            } while (doChoice != 3);
        }

        static Video_games AddGame()
        {
            Console.Write("Введіть назву гри: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Назва гри не може бути порожньою!");
                return null;
            }

            Console.WriteLine("\nОберіть жанр гри:");
            Console.WriteLine("1 - Action");
            Console.WriteLine("2 - Adventure");
            Console.WriteLine("3 - RPG");
            Console.WriteLine("4 - Strategy");
            Console.WriteLine("5 - Sport");
            Console.WriteLine("6 - Horror");
            Console.WriteLine("7 - Simulator");

            Console.Write("Ваш вибір: ");

            if (!int.TryParse(Console.ReadLine(), out int genreChoice))
            {
                Console.WriteLine("Потрібно ввести число!");
                return null;
            }

            Game_genre genre;

            switch (genreChoice)
            {
                case 1:
                    genre = Game_genre.Action;
                    break;

                case 2:
                    genre = Game_genre.Adventure;
                    break;

                case 3:
                    genre = Game_genre.RPG;
                    break;

                case 4:
                    genre = Game_genre.Strategy;
                    break;

                case 5:
                    genre = Game_genre.Sport;
                    break;

                case 6:
                    genre = Game_genre.Horror;
                    break;

                case 7:
                    genre = Game_genre.Simulator;
                    break;

                default:
                    Console.WriteLine("Некоректний вибір жанру!");
                    return null;
            }

            Console.Write("Введіть рейтинг гри від 0 до 5: ");

            if (!double.TryParse(Console.ReadLine(), out double rating))
            {
                Console.WriteLine("Потрібно ввести число!");
                return null;
            }

            if (rating < 0 || rating > 5)
            {
                Console.WriteLine("Рейтинг повинен бути від 0 до 5!");
                return null;
            }

            Console.Write("Введіть дату релізу (рррр-мм-дд): ");

            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly releaseYear))
            {
                Console.WriteLine("Некоректна дата!");
                return null;
            }

            Console.Write("Введіть ціну гри: ");

            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Потрібно ввести число!");
                return null;
            }

            if (price <= 0)
            {
                Console.WriteLine("Ціна повинна бути більше 0!");
                return null;
            }

            Video_games game = new Video_games(
                name,
                genre,
                rating,
                releaseYear,
                price
            );

            return game;
        }
    }
}