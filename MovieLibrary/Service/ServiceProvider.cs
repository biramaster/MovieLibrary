// -------------------------------------------------------------------------
// File name.........: ServiceProvider.cs
// Purpose ..........: Provide a instance of a Service for each entities in 
//                     the system
// Programmer........: André Rubira
// Date..............: 2015-01-23
// Version...........: 1.0
// Changed...........: 
// --------------------------------------------------------------------------


using MovieLibrary.Controll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    class ServiceProvider
    {
        static MovieList _movieService;
        static MemberList _memberService;
        static DirectorList _directorService;

        public static MovieList GetMovieService()
        {
            if (_movieService == null)
                try
                {
                    _movieService = new MovieList();
                }
                catch (Exception)
                {
                    
                    throw;
                }
                

            return _movieService;
        }

        public static MemberList GetMemberService()
        {
			if (_memberService == null)
			{
				try
				{
					_memberService = new MemberList();
				}
				catch (Exception)
				{
					
					throw;
				}
				
			}

            return _memberService;
        }


        public static DirectorList GetDirectorService()
        {
            if (_directorService == null)
            {
                try
                {
                    _directorService = new DirectorList();
                }
                catch (Exception)
                {

                    throw;
                }

            }

            return _directorService;
        }
    }

}