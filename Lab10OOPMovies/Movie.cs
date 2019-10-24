using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10OOPMovies
{
    class Movie
    {
        private string name;
        private string genre;
        private bool liveAction;

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public bool LiveAction
        {
            get { return liveAction; }
            set { liveAction = value; }
        }
        #endregion

        public Movie(string _name, string _genre, bool _liveaction)
        {
            name = _name;
            genre = _genre;
            liveAction = _liveaction;
        }

        public static void PrintGenres(List<Movie> theList)
        {
            List<string> genres = new List<string>();
            foreach(Movie movie in theList)
            {
                if (!genres.Contains(movie.Genre))
                {
                    genres.Add(movie.Genre);
                    Console.WriteLine($"{genres.Count}. {movie.Genre}");
                }
            }
        }
        public static List<string> GetGenres(List<Movie> theList)
        {
            List<string> genres = new List<string>();
            foreach (Movie movie in theList)
            {
                if (!genres.Contains(movie.Genre))
                {
                    genres.Add(movie.Genre);
                }
            }
            return genres;
        }

    }
}
