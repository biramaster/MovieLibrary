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
            try
            {
                if (File.Exists("MDirectorLista.DAT"))
                {
                    m_directorList = BinarySerialization<List<Director>>.BinaryDeSerialize("DirectorLista.DAT");
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
            throw new NotImplementedException();
        }

        public void Remove(Director item)
        {
            throw new NotImplementedException();
        }

        public Director Get(int index)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Director Find(string strFind)
        {
            throw new NotImplementedException();
        }

        public int NextID()
        {
            throw new NotImplementedException();
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
    }
}
