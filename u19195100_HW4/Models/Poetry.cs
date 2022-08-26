using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19195100_HW4.Models
{
    public class Poetry:Book
    {
        public int _Volume;
        public string _City;


        //Default Constructors 


        public Poetry() : base()
        {

        }
        public Poetry(int ID, string Name, string Description, string Author, string Image, int RealeaseDate, string BookType, int Volume, string City) : base(ID, Name, Description, Author, Image, RealeaseDate, BookType)
        {
            _Volume = Volume;
            _City = City;
        }

        //Methods

        public override string ItemAbout()
        {
            return "The Following book "+this.Name+" was released in "+this.ReleaseDate;
        }



        public override string ItemWritter()
        {
            return "The following writter " + this.Author + " book lives in the city of " + this.City;
        }

        //Properties

        public int Vol { get { return _Volume; } set { _Volume = value; } }

        public string City { get { return _City; } set { _City = value; } }
    }
}