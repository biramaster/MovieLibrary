﻿// ----------------------------------
// File name.........: MovieCopy.cs
// Purpose ..........: Define a movie copy in the Domain Model
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

namespace MovieLibrary.Model
{
    [Serializable]
    class MovieCopy
    {
        private int filmId;
        private int Id;

        public MovieCopy(int p)
        {
            // TODO: Complete member initialization
            this.ID = p;
        }

        public int FilmId
        {
            get { return filmId; }
            set { filmId = value; }
        }
        
        
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        
    }
}
