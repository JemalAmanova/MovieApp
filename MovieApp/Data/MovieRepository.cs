using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id=1,
                    Name="The Pursuit Of Happyness",
                    Description="<p>The Pursuit of Happyness by Chris Gardner tells the story of a struggling salesman who never gave up trying to find true happiness for himself and his son.</p>",
                    ShortDescription="The Pursuit Of Happyness",
                    ImageUrl="1.jpg",
                    CategoryId = 3
                },
                new Movie() {
                    Id=2,
                    Name="The Imitation Game: Enigma",
                    Description="<p>A During World War II, the English mathematical genius Alan Turing tries to crack the German Enigma code with help from fellow mathematicians while attempting to come to terms with his troubled private life.</p>",
                    ShortDescription="The Imitation Game: Enigma",
                    ImageUrl="2.jpg",
                    CategoryId = 4
                },
                new Movie() {
                    Id=3,
                    Name="The Intern",
                    Description="<p>The plot follows a 70-year-old widower who becomes a senior intern at a fashion website, where he forms an unlikely friendship with the company's workaholic CEO</p>",
                    ShortDescription="The Intern",
                    ImageUrl="3.jpg",
                    CategoryId = 1
                },
                new Movie() {
                    Id=4,
                    Name="Amélie",
                    Description="<p>Amélie is a fanciful comedy about a young woman who discretely orchestrates the lives of the people around her, creating a world exclusively of her own making.</p>",
                    ShortDescription="Amélie",
                    ImageUrl="4.jpg",
                    CategoryId = 2
                }
                
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }


    }
}