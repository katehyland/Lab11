using System;
namespace Lab11
{
    public class Movie
    {
        private string title;
        private string category;

        //create a constructor that accepts a title & category as paramters


        public string Title
        {
            get { return title;  }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

       
    }
}
