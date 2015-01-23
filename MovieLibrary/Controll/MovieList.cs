using MovieGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGenerator.Controller
{
    class MovieList
    {
        private List<Movie> myMovie;

        public MovieList()
        {
            myMovie = new List<Movie>();
        }

        public void Add(Movie item)
        {
            myMovie.Add(item);
        }

        public void Remove(Movie item)
        {
            myMovie.Remove(item);
        }

        public Movie Get(int index)
        {
            return myMovie.ElementAt(index);
        }

        public int Count()
        {
            return myMovie.Count();
        }


        public Movie FindTitle(string title)
        {
            for (int i = 0; i < myMovie.Count(); i++)
            {
                if (myMovie[i].getTitle() == title)
                {
                    return myMovie[i];
                }
            }
            return null;
        }

        public int GetIndexOfTitle(string title)
        {
            for (int i = 0; i < myMovie.Count(); i++)
            {
                if (myMovie[i].getTitle() == title)
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateImagePath(Movie movie, string path)
        {
            movie.setPath(path);
            myMovie.Remove(movie);
            myMovie.Add(movie);
        }

        public object toArray()
        {

            var movies = from movie in myMovie
                         select new
                         {
                             Title = movie.getTitle(),
                             Runtime = movie.getTime(),
                             Genre = movie.getGenre(),
                             Director = movie.getDirector(),
                             Age = movie.getAge()

                         };

            return movies.ToArray();
        }
    }
}
