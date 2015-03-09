using MovieLibrary.DAL;
using MovieLibrary.Model;
using MovieLibrary.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Controll
{
    class MovieCopyList : IListor<MovieCopy>, IService
    {
        private List<MovieCopy> m_movieCopyList;

        public event EventHandler Updated;

        public MovieCopyList()
        {
            m_movieCopyList = new List<MovieCopy>();
            try
            {
                if (File.Exists("MovieCopyLista.DAT"))
                {
                    m_movieCopyList = BinarySerialization<List<MovieCopy>>.BinaryDeSerialize("MovieCopyLista.DAT");
                }
                else
                {
                    this.BinarySerialize();
                }

            }
            catch (Exception ex)
            {

                throw new CustomException(ex.Message);
            }
        }

        public void Add(MovieCopy item)
        {
            item.FilmId = NextID();
            m_movieCopyList.Add(item);
            OnUpdated();
        }

        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public void Remove(MovieCopy item)
        {
            throw new NotImplementedException();
        }

        public MovieCopy Get(int index)
        {
            return m_movieCopyList.ElementAt(index);
        }

        public int Count()
        {
            return m_movieCopyList.Count();
        }

        public MovieCopy Find(string strFind)
        {
            var me = (from movieCopy in m_movieCopyList
                      where movieCopy.ID.ToString() == strFind
                      select movieCopy).First();

            return me;
        }

        public int NextID()
        {
            return m_movieCopyList.Count() + 1;
        }

        /// <summary>
        /// BinarySerialize is a method in the MemberList class that 
        /// Serialize (save object from the program into files) using 
        /// binary serialization.
        /// </summary>
        /// <returns>true or cast an exception</returns>
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<MovieCopy>>.FileName = "MovieCopyLista.DAT";
                BinarySerialization<List<MovieCopy>>.BinarySerialize(m_movieCopyList);
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }

            return true;
        }
    }
}
