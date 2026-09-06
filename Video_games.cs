using System;

namespace oop_lab_1
{
    internal class Video_games
    {
        public string Name { get; set; }
        public Game_genre Genre { get; set; }
        public double Rating { get; set; }
        public DateOnly Release_year { get; set; }
        public double Price { get; set; }
        private int Count_players { get; set; }

        public Video_games(string name, Game_genre genre, double rating, DateOnly release_year, double price)
        {
            Name = name;
            Genre = genre;
            Rating = rating;
            Release_year = release_year;
            Price = price;
            Count_players = 0;
        }

        public void StartGame()
        {
            Count_players++;
        }

        public void ExitGame()
        {
            if (Count_players > 0)
            {
                Count_players--;
            }
            else
            {
                Console.WriteLine("У грі немає активних гравців.");
            }
        }

        public void ChangeRating()
        {
            Console.WriteLine("Введіть новий рейтинг від 0 до 5:");

            double newRating = double.Parse(Console.ReadLine());

            if (newRating >= 0 && newRating <= 5)
            {
                Rating = newRating;
                Console.WriteLine("Рейтинг змінено!");
            }
            else
            {
                Console.WriteLine("Некоректний рейтинг!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Назва гри: {Name}");
            Console.WriteLine($"Жанр гри: {Genre}");
            Console.WriteLine($"Рейтинг гри: {Rating}");
            Console.WriteLine($"Дата релізу гри: {Release_year}");
            Console.WriteLine($"Ціна: {Price}");
            Console.WriteLine($"Кількість гравців: {Count_players}");
        }
    }
}