using LibrarySystem;
using MovieLibrary.DAL;
using MovieLibrary.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Controll
{
    class DirectorList : IListor<Director>, IService
    {
        private List<Director> m_directorList;

        public event EventHandler Updated;

        public DirectorList()
        {
			m_directorList = new List<Director>();
            try
            {
                if (File.Exists("DirectorLista.DAT"))
                {
                    m_directorList = BinarySerialization<List<Director>>.BinaryDeSerialize("DirectorLista.DAT");
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

        public void Add(Director item)
        {
            item.ID = NextID();
            m_directorList.Add(item);
            OnUpdated();
        }

        public void Remove(Director item)
        {
            throw new NotImplementedException();
        }

        public Director Get(int index)
        {
            return m_directorList.ElementAt(index);
        }

        public int Count()
        {
            return m_directorList.Count();
        }

        public Director Find(string strFind)
        {
			var me = (from director in m_directorList
					  where director.ID.ToString() == strFind
					  select director).First();

			return me;
        }

        public int NextID()
        {
            return m_directorList.Count() + 1;
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
                BinarySerialization<List<Director>>.FileName = "DirectorLista.DAT";
                BinarySerialization<List<Director>>.BinarySerialize(m_directorList);
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
                m_directorList = dal.ReadDirectorFromDatabase();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }
        }
    }
}
