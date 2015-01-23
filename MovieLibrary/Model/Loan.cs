// ----------------------------------
// File name.........: Loan.cs
// Purpose ..........: Define a loan in the Domain Model
// Programmer........: André Rubira
// Date..............: 2015-01-23
// Version...........: 1.0
// Changed...........: 
// ------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Loan
    {
        public int Id { get; set; }
        public int filmId { get; set; }
        public int memberId { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }

        public override string ToString()
        {
            string str="";
            

            return str;
        }
    }
}