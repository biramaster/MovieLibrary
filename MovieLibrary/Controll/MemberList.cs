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
	class MemberList : IListor<Member>, IService
	{
        private List<Member> m_memberList;

        public event EventHandler Updated;

        

        public MemberList()
        {
            m_memberList = new List<Member>();
            try
            {
                if (File.Exists("MemberLista.DAT"))
                {
                    m_memberList = BinarySerialization<List<Member>>.BinaryDeSerialize("MemberLista.DAT");
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
		public void Add(Member item)
		{
            item.ID = NextID();
            m_memberList.Add(item);
            OnUpdated();
		}

		public void Remove(Member item)
		{
			throw new NotImplementedException();
		}

		public Member Get(int index)
		{
            return m_memberList.ElementAt(index);
		}

		public int Count()
		{
            return m_memberList.Count();
		}

		public Member Find(string strFind)
		{

            var me = (from member in m_memberList
                      where member.ID.ToString() == strFind
                      select member).First();

            return me;
            /*
            for (int i = 0; i < m_memberList.Count(); i++)
            {
                if (m_memberList[i].ID.ToString() == strFind)
                {
                    return m_memberList[i];
                }
            }
            
            return null;*/
		}



        public int NextID()
        {
            return m_memberList.Count() + 1;
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
                BinarySerialization<List<Member>>.FileName = "MemberLista.DAT";
                BinarySerialization<List<Member>>.BinarySerialize(m_memberList);
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }

            return true;
        }
    }
}
