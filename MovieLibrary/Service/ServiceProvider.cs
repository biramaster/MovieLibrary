// -------------------------------------------------------------------------
// File name.........: ServiceProvider.cs
// Purpose ..........: Provide a instance of a Service for each entities in 
//                     the system
// Programmer........: André Rubira
// Date..............: 2015-01-23
// Version...........: 1.0
// Changed...........: 
// --------------------------------------------------------------------------


using MovieGenerator.Controller;
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
        public static MovieList GetMovieService()
        {
            if (_movieService == null)
                _movieService = new MovieList();

            return _movieService;
        }

        public static MemberList GetMemberService()
        {
            if (_memberService == null)
                _memberService = new MemberList();

            return _memberService;
        }

    }

}