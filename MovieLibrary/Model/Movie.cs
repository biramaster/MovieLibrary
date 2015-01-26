// ----------------------------------
// File name.........: Movie.cs
// Purpose ..........: Define a movie in the Domain Model
// Programmer........: André Rubira
// Date..............: 2015-01-23
// Version...........: 1.0
// Changed...........: 26-01-2015
// ------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGenerator.Model
{
	[Serializable]
    class Movie
    {
        // medlemsvariabler
        private int Id;
        private int time;
        private string title;
        private string genre;
        private string director;
        private int age;
        private string path;


        // default constructor/konstruktor
        public Movie()
        {
            this.time = 0;
            this.title = "no title";
            this.genre = "no genre";
            this.director = "no director";
            this.age = 0;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="inTitle">Film title</param>
        /// <param name="inTime">Film runtime</param>
        /// <param name="inGenre">Film genre</param>
        /// <param name="inDirector">Film director name</param>
        /// <param name="inAge">Film recomended age</param>
        public Movie(string inTitle,
                     int inTime,
                     string inGenre,
                     string inDirector,
                     int inAge)
        {
            this.title = inTitle;
            this.time = inTime;
            this.genre = inGenre;
            this.director = inDirector;
            this.age = inAge;
        }

        // metoder

        public void setId(int inId)
        {
            this.Id = inId;
        }
        public int getId()
        {
            return this.Id;
        }
        /// <summary>
        /// Return the path of a image
        /// </summary>
        /// <returns>the path of a image</returns>
        public string getPath()
        {
            return this.path;
        }

        /// <summary>
        /// Set the path of a image
        /// </summary>
        /// <param name="path">path of a image</param>
        public void setPath(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Return the movie title.
        /// </summary>
        /// <returns>Movie title</returns>
        public string getTitle()
        {
            return this.title;
        }

        /// <summary>
        /// Return the movie runtime.
        /// </summary>
        /// <returns>Movie runtime</returns>
        public int getTime()
        {
            return this.time;
        }

        /// <summary>
        /// Return the movie genre.
        /// </summary>
        /// <returns>Movie genre</returns>
        public string getGenre()
        {
            return this.genre;
        }

        /// <summary>
        /// Return the director name.
        /// </summary>
        /// <returns>Director name</returns>
        public string getDirector()
        {
            return this.director;
        }

        /// <summary>
        /// Return the recomended age.
        /// </summary>
        /// <returns>Recomended age</returns>
        public int getAge()
        {
            return this.age;
        }

        /// <summary>
        /// Set the movie title
        /// </summary>
        /// <param name="inTitle">Movie title</param>
        public void setTitle(string inTitle)
        {
            this.title = inTitle;
        }

        /// <summary>
        /// Set the movie runtime
        /// </summary>
        /// <param name="inTime">Movie runtime</param>
        public void setTime(int inTime)
        {
            this.time = inTime;
        }

        /// <summary>
        /// Set the movie genre
        /// </summary>
        /// <param name="inGenre">Movie genre</param>
        public void setGenre(string inGenre)
        {
            this.genre = inGenre;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inDirector"></param>
        public void setDirector(string inDirector)
        {
            this.director = inDirector;
        }

        public void setAge(int inAge)
        {
            this.age = inAge;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string response =
                "Id:" + this.Id + "\n" +
                "Title:" + this.title + "\n" +
                "Time:" + this.time + "\n" +
                "Genre:" + this.genre + "\n" +
                "Director:" + this.director + "\n" +
                "Age:" + this.age;
            return response;
        }

    }
}
