using LibrarySystem;
using MovieLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Controll
{
    class LoanList : IListor<Loan>, IService
    {

        private List<Loan> m_loanList;

        public event EventHandler Updated;

        public void Add(Loan item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Loan item)
        {
            throw new NotImplementedException();
        }

        public Loan Get(int index)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Loan Find(string strFind)
        {
            throw new NotImplementedException();
        }

        public int NextID()
        {
            throw new NotImplementedException();
        }
    }
}
