using System;
using System.Collections.Generic;

namespace Assignments
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }

    class V_Pratheek_Assignment5
    {
        static List<Movie> movies = new List<Movie>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Movie Database Menu ---");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Remove Movie");
                Console.WriteLine("3. Find Movie");
                Console.WriteLine("4. Update Movie");
                Console.WriteLine("5. Display All Movies");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option (1-6): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMovie();
                        break;
                    case "2":
                        RemoveMovie();
                        break;
                    case "3":
                        FindMovie();
                        break;
                    case "4":
                        UpdateMovie();
                        break;
                    case "5":
                        DisplayMovies();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select from 1 to 6.");
                        break;
                }
            }

            Console.WriteLine("Exiting Movie Database App.");
        }

        static void AddMovie()
        {
            Console.Write("Enter movie title: ");
            string title = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter release year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid year.");
                return;
            }

            movies.Add(new Movie { Id = nextId++, Title = title, Genre = genre, Year = year });
            Console.WriteLine("Movie added successfully.");
        }

        static void RemoveMovie()
        {
            Console.Write("Enter movie ID to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var movie = movies.Find(m => m.Id == id);
            if (movie != null)
            {
                movies.Remove(movie);
                Console.WriteLine("Movie removed successfully.");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }

        static void FindMovie()
        {
            Console.Write("Enter movie title to search: ");
            string title = Console.ReadLine();

            var foundMovies = movies.FindAll(m => m.Title.ToLower().Contains(title.ToLower()));
            if (foundMovies.Count > 0)
            {
                Console.WriteLine("\nFound Movies:");
                foreach (var movie in foundMovies)
                {
                    Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}, Genre: {movie.Genre}, Year: {movie.Year}");
                }
            }
            else
            {
                Console.WriteLine("No movies found with that title.");
            }
        }

        static void UpdateMovie()
        {
            Console.Write("Enter movie ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var movie = movies.Find(m => m.Id == id);
            if (movie != null)
            {
                Console.Write("Enter new title (leave blank to keep current): ");
                string newTitle = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newTitle))
                    movie.Title = newTitle;

                Console.Write("Enter new genre (leave blank to keep current): ");
                string newGenre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newGenre))
                    movie.Genre = newGenre;

                Console.Write("Enter new year (leave blank to keep current): ");
                string newYearInput = Console.ReadLine();
                if (int.TryParse(newYearInput, out int newYear))
                    movie.Year = newYear;

                Console.WriteLine("Movie updated successfully.");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }

        static void DisplayMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies in the database.");
                return;
            }

            Console.WriteLine("\n--- Movie List ---");
            foreach (var movie in movies)
            {
                Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}, Genre: {movie.Genre}, Year: {movie.Year}");
            }
        }
    }
}

