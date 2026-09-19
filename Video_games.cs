using System;

namespace oop_lab_1
{
    internal class Video_games
    {
        public string Name;
        public Game_genre Genre;
        public double Rating;
        public DateOnly Release_year;
        public double Price;
        private int Count_players;

        public Video_games(string name, Game_genre genre, double rating, DateOnly release_year, double price)
        {
            Name = name;
            Genre = genre;
            Rating = rating;
            Release_year = release_year;
            Price = price;
            Count_players = 0;
        }
        public int GetPlayersCount()
        {
            return Count_players;
        }
        public void StartGame()
        {
            Count_players++;
        }

        public bool ExitGame()
        {
            if (Count_players > 0)
            {
                Count_players--;
                return true; 
            }
            return false;
        }

    }
}