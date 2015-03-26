using MovieGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary.Controll;
using MovieLibrary.Service;
using System.IO;
using MovieLibrary.DAL;

namespace MovieLibrary.Controll
{
    class MovieList : IListor<Movie>, IService
    {
        private List<Movie> m_movieList;

        public event EventHandler Updated;


        public MovieList()
        {
            m_movieList = new List<Movie>();
			try
			{
				if (File.Exists("MovieLista.DAT"))
				{
					m_movieList = BinarySerialization<List<Movie>>.BinaryDeSerialize("MovieLista.DAT");
				}
				else
				{
                    ReadFromDatabase();
				}
			}
			catch (Exception ex)
			{
				throw new CustomException(ex.Message);
			}
        }


        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public void Add(Movie item)
        {
            item.setId(NextID());
            m_movieList.Add(item);
			OnUpdated();
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
            var me = (from movie in m_movieList
                      where movie.getId().ToString() == strFind
                      select movie).First();

            return me;
        }

        public int NextID()
        {
            return m_movieList.Count() + 1;
        }

		public bool BinarySerialize()
		{
			try
			{
				BinarySerialization<List<Movie>>.FileName = "MovieLista.DAT";
				BinarySerialization<List<Movie>>.BinarySerialize(m_movieList);
			}
			catch (Exception ex)
			{
				throw new CustomException(ex.Message);
			}

			return true;
		}

        public void ReadFromDatabase()
        {
            try
            {
                DataAccessLayerDBA dal = new DataAccessLayerDBA();
                m_movieList = dal.ReadFromDatabaseMovies();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }
        }

       
    }
}
