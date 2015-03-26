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
        private static MovieList _movieService;
        private static MemberList _memberService;
        private static DirectorList _directorService;
        private static MovieCopyList _movieCopyService;
        private static LoanList _loanService;

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

        public static MovieCopyList GetMovieCopyService()
        {
            if (_movieCopyService == null)
            {
                try
                {
                    _movieCopyService = new MovieCopyList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return _movieCopyService;
        }

        public static LoanList GetLoanService()
        {
            if (_loanService == null)
            {
                try
                {
                    _loanService = new LoanList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return _loanService;
        }
    }
}