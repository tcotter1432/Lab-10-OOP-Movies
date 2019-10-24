using System;
using System.Collections.Generic;

namespace Lab10OOPMovies
{
    class Program
    {
        public static List<Movie> theMovies = new List<Movie>();
        static void Main(string[] args)
        {
            bool keepGoing = true;
            PopulateList();

            Console.WriteLine($"We have a list of {theMovies.Count} movies here....");
            while (keepGoing)
            {
                Console.WriteLine("What would you like to know?\n 1. The Genres \n 2. What movies are of what genre.\n 3. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case ("1"):
                        Movie.PrintGenres(theMovies);
                    break;
                    case ("2"):
                        Console.WriteLine("What genre do you want list out? (Enter a number)");
                        input = Console.ReadLine();
                        HandleGenres(input);
                    break;
                    case ("3"):
                        keepGoing = false;
                        Console.WriteLine("Take care!");
                    break;
                    default:
                        Console.WriteLine("Invalid input! Try again!");
                        continue;
                }
            }
        }

        public static void HandleGenres(string input)
        {
            try
            {
                int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            int intInput = int.Parse(input)-1;
            List<string> genres = new List<string>();
            genres = Movie.GetGenres(theMovies);
            if (intInput >= genres.Count || intInput < 0)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
            Console.WriteLine($"You have selected {genres[intInput]}.");
            foreach(Movie movie in theMovies)
            {
                if (genres[intInput] == movie.Genre)
                {
                    Console.WriteLine(movie.Name);
                }
            }
        }

        public static void PopulateList()
        {
            theMovies.Add(new Movie("Apollo 13", "Historical", true));
            theMovies.Add(new Movie("Braveheart", "Medieval Action", true));
            theMovies.Add(new Movie("The Fellowship of the Ring", "Fantasy", true));
            theMovies.Add(new Movie("The Two Towers", "Fantasy", true));
            theMovies.Add(new Movie("The Return of the King", "Fantasy", true));
            theMovies.Add(new Movie("Big Hero 6", "Superhero", false));
            theMovies.Add(new Movie("Top Gun", "Modern Action", true));
            theMovies.Add(new Movie("Raiders of the Lost Arc", "Historical Fiction", true));
            theMovies.Add(new Movie("Inglorious Bastards", "Tarantino Flick", true));
            theMovies.Add(new Movie("Fight Club", "Tarantino Flick", true));
        }
    }
}