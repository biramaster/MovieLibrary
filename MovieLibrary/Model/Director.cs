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
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}