using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19195100_HW4.Models
{
    public class Drama:Book
    {
        public string _Part;



        //Default Constructors 

        public Drama() : base()
        {

        }

        public Drama(int ID, string Name, string Description, string Author, string Image, int RealeaseDate, string BookType, string part) : base(ID, Name, Description, Author, Image, RealeaseDate, BookType)
        {
            _Part = part;

        }


        //Methods

        public override string ItemAbout()
        {
            return "This " + this.Name + "book " + this.Description;
        }

        public override string ItemWritter()
        {
            return "The writer of this" + this.Name + "book is" + this.Author;
        }




        //Properties

        public string Part { get { return _Part; } set { _Part = value; } }
    }
}