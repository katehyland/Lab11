using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repeat = true;
            while (repeat)
            {
                List<Movie> movieList = new List<Movie>()
            {

                {
                    new Movie("Step Brothers", "Drama")
                },
                {
                    new Movie("Totoro", "Animated")
                },
                {
                    new Movie("Lion King", "Drama")
                },
                {
                    new Movie("IT", "Horror")
                },
                {
                    new Movie("No Country For Old Men", "Horror")
                },
                {
                    new Movie("Weekend At Bernies", "Drama")
                },
                {
                    new Movie("King", "Drama")
                },
                {
                    new Movie("Interstellar", "Sci Fi")
                },
                {
                    new Movie("Inception", "Sci Fi")
                },
                {
                    new Movie("Honey I Shrank The Kids", "Sci Fi")
                },

            };
                Console.WriteLine("Enter a category: Animated, Drama, Horror, Sci Fi");
                string input = Console.ReadLine();

                foreach (Movie movie in movieList)
                {
                  
                    if (input.ToUpper() != movie.Category)
                    {
                        Console.WriteLine("Input was not recognized as one of the four categories.");
                        repeat = false;
                    }
                    if (input == movie.Category)
                    {
                        Console.WriteLine(movie.Title);
                    }

                  
                };
                Console.WriteLine("Would you like to continute? Enter yes or no.");
                string continueInput = Console.ReadLine();

                string contFormattedInput = continueInput.ToLower();

                if (contFormattedInput == "no")
                {
                    Console.WriteLine("INPUT = NO");
                    repeat = false;
                }
                if (contFormattedInput == "yes")
                {
                    Console.WriteLine("INPUT = NO");
                    repeat = false;
                }
            }
        }
    }
}
