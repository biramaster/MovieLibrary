// ----------------------------------
// File name.........: Member.cs
// Purpose ..........: Define a member in the Domain Model
// Programmer........: André Rubira
// Date..............: 2015-01-23
// Version...........: 1.0
// Changed...........: 2015-01-26
// ------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Member
    {
        private int m_id;
        private string m_personalId;
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        

        public string PersonalID
        {
            get { return m_personalId; }
            set { m_personalId = value; }
        }
        

        public int ID
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public Member(string personalID, string name)
        {
            this.m_name = name;
            this.m_personalId = personalID;
        }
        public override string ToString()
        {
            return m_personalId + " | " + m_name;
        }

    }
}