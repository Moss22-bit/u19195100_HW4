using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19195100_HW4.Models
{
    public abstract class Book
    {
        public List<Drama> DramaList = new List<Drama>();
        public List<Poetry> PoetList = new List<Poetry>();
        public List<Educational> EduList = new List<Educational>();

        public int _Id;
        public string _Name;
        public string _Description;
        public string _Author;
        public string _Image;
        public int _ReleaseDate;
        public string _Booktype;

        //Default Constructors 

        public Book() //Parameterless constructor
        {

        }

        public Book(int ID, string Name, string Description, string Author, string Image, int RealeaseDate, string BookType)
        {
            _Id = ID;
            _Name = Name;
            _Description = Description;
            _Author = Author;
            _Image = Image;
            _ReleaseDate = RealeaseDate;
            _Booktype = BookType;
        }


        //Methods

        public abstract string ItemAbout();

        public abstract string ItemWritter();



        //Properties

        public int ID { get { return _Id; } set { _Id = value; } }

        public string Name { get { return _Name; } set { _Name = value; } }

        public string Description { get { return _Description; } set { _Description = value; } }

        public string Author { get { return _Author; } set { _Author = value; } }


        public string Image { get { return _Image; } set { _Image = value; } }

        public int ReleaseDate { get { return _ReleaseDate; } set { _ReleaseDate = value; } }

        public string Booktype { get { return _Booktype; } set { _Booktype = value; } } 



    }
}