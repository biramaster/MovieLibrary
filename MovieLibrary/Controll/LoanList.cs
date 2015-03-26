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
    class LoanList : IListor<Loan>, IService
    {

        private List<Loan> m_loanList;

        public event EventHandler Updated;

		public LoanList()
		{
			m_loanList = new List<Loan>();
			try
			{
				if (File.Exists("LoanLista.DAT"))
				{
					m_loanList = BinarySerialization<List<Loan>>.BinaryDeSerialize("LoanLista.DAT");
				}
				else
				{
					
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
			var me = (from loan in m_loanList
					  where loan.CopyFilmId.ToString() == strFind
					  select loan).First();

			return me;
		}

		public int NextID()
		{
			return m_loanList.Count() + 1;
		}

		public bool BinarySerialize()
		{
			try
			{
				BinarySerialization<List<Loan>>.FileName = "LoanLista.DAT";
				BinarySerialization<List<Loan>>.BinarySerialize(m_loanList);
			}
			catch (Exception ex)
			{
				throw new CustomException(ex.Message);
			}

			return true;
		}

        public Loan isOnLoan(string movieCopyID)
        {
            var movie = (from loan in m_loanList
                         where loan.ID.ToString() == movieCopyID &&
                               loan.TimeOfReturn != null
                      select loan).First();

            return movie;
        }
    }
}
