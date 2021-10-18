using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using NLog.Web;

namespace MediaLibrary
{  
    public static class View
    {

        // this class handles all output to the user

        private static ArrayList menuDisplay = new ArrayList()
        {
            "1) Add Movie" , 
            "2) Display All Movies", 
            "3) Find movie",
            "Enter to quit"
        };

        private static ArrayList promptDisplay = new ArrayList()
        {
            "Enter movie title" , 
            "Enter genre (or done to quit)", 
            "Enter movie director",
            "Enter running time (h:m:s)"
        };

        private static string searchPrompt = "Please Enter The Name Of The Movie You Would Like To Find:";


        public static void setMenuDisplay(ArrayList md)
        {
            menuDisplay = md;
        }

        public static void displaySearchPrompt()
        {
            System.Console.WriteLine(searchPrompt);
        }

        public static void displayMenu()
        {
            foreach(string line in menuDisplay)
            {
                System.Console.WriteLine(line);
            }
        }

        public static void displayMovies()
        {
            List<Movie> movies = Model.getMovies();
            foreach(Movie m in movies)
            {
                System.Console.WriteLine(m.Display());           
            }
        }

        public static void displaySelectedMovieTitles(string movieTitle, IEnumerable<string> titles)
        {
            // LINQ - Count aggregation method
            Console.WriteLine($"There are {titles.Count()} movies with \"{movieTitle.ToUpper()}\" in the title:");
            foreach(string t in titles)
            {
                Console.WriteLine($"  {t}");
            }
        }

        public static void creationPrompt(int movieAttribute)
        {
            System.Console.WriteLine(promptDisplay[movieAttribute-1]);
        }

    }
}