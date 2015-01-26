using MovieGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary.Controll;

namespace MovieGenerator.Controller
{
    class MovieList : IListor<Movie>
    {
        private List<Movie> m_movieList;

        public MovieList()
        {
            m_movieList = new List<Movie>();
        }

        public void Add(Movie item)
        {
            item.setId(NextID());
            m_movieList.Add(item);
        }

        public void Remove(Movie item)
        {
            m_movieList.Remove(item);
        }

        public Movie Get(int index)
        {
            return m_movieList.ElementAt(index);
        }

        public int Count()
        {
            return m_movieList.Count();
        }


        public Movie FindTitle(string title)
        {
            for (int i = 0; i < m_movieList.Count(); i++)
            {
                if (m_movieList[i].getTitle() == title)
                {
                    return m_movieList[i];
                }
            }
            return null;
        }

        public int GetIndexOfTitle(string title)
        {
            for (int i = 0; i < m_movieList.Count(); i++)
            {
                if (m_movieList[i].getTitle() == title)
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateImagePath(Movie movie, string path)
        {
            movie.setPath(path);
            m_movieList.Remove(movie);
            m_movieList.Add(movie);
        }

        public object toArray()
        {

            var movies = from movie in m_movieList
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


        public Movie Find(string strFind)
        {
            throw new NotImplementedException();
        }

        public int NextID()
        {
            return m_movieList.Count() + 1;
        }
    }
}
