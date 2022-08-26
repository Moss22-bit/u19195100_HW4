using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19195100_HW4.Models
{
    public class Educational:Book
    {
        public int _Edition;


        public Educational() : base()
        {

        }

        public Educational(int ID, string Name, string Description, string Author, string Image, int RealeaseDate, string BookType, int Ed) : base(ID, Name, Description, Author, Image, RealeaseDate, BookType)
        {
            _Edition = Ed;

        }


        //Methods

        public override string ItemAbout()
        {
            return "The following" + this.Name + "is published in" + this.ReleaseDate;
        }


        public override string ItemWritter()
        {
            return "This book" + this.Name + "has" + this.Ed + "editions";
        }







        //Properties

        public int Ed { get { return _Edition; } set { _Edition = value; } }
    }
}