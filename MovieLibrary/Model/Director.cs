// ----------------------------------
// File name.........: Director.cs
// Purpose ..........: Define a director in the Domain Model
// Programmer........: André Rubira
// Date..............: 2013-05-16
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
    [Serializable]
    public class Director
    {
        private int _Id;
        private string _Name;

        public Director(string name)
        {
            Name = name;
        }

        public Director(string p1, string p2)
        {
            // TODO: Complete member initialization
            this._Id = Convert.ToInt32(p1);
            this.Name = p2;
        }

        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        public override string ToString()
        {
            return _Name;
        }
    }
}