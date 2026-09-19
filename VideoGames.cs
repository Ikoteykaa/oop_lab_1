using System;

namespace oop_lab_1
{
    internal class VideoGames
    {
        public string Name;
        public GameGgenre Genre;
        public double Rating;
        public DateOnly ReleaseYear;
        public double Price;
        private int CountPlayers;

        public VideoGames(string name, GameGgenre genre, double rating, DateOnly release_year, double price)
        {
            Name = name;
            Genre = genre;
            Rating = rating;
            ReleaseYear = release_year;
            Price = price;
            CountPlayers = 0;
        }
        public int GetPlayersCount()
        {
            return CountPlayers;
        }
        public void StartGame()
        {
            CountPlayers++;
        }

        public bool ExitGame()
        {
            if (CountPlayers > 0)
            {
                CountPlayers--;
                return true; 
            }
            return false;
        }

    }
}