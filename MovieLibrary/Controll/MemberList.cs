using LibrarySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Controll
{ 
	class MemberList : IListor<Member>
	{
        private List<Member> m_memberList;

        public MemberList()
        {

        }
		public void Add(Member item)
		{
			throw new NotImplementedException();
		}

		public void Remove(Member item)
		{
			throw new NotImplementedException();
		}

		public Member Get(int item)
		{
			throw new NotImplementedException();
		}

		public int Count()
		{
			throw new NotImplementedException();
		}

		public Member Find(string strFind)
		{
			throw new NotImplementedException();
		}
	}
}
