using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19195100_HW4.Models;

namespace u19195100_HW4.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        //AdminPassword
        private static string SiteUsername = "moss";
        private static string SitePassword = "MyNamesjeff69";

        //Declare My PS
        public static List<Drama> DramaList = new List<Drama>();
        public static List<Educational> EduList = new List<Educational>();
        public static List<Poetry> PoetList = new List<Poetry>();

        private void InitialiseStore()
        {
            if (BookDB.Count() == 0)
            {
                DramaList.Add(new Drama(1, "Romeo and Juliet", "Romeo and Juliet is a tragedy written by William Shakespeare early in his career about two young Italian star-crossed lovers whose deaths ultimately reconcile their feuding families. It was among Shakespeare's most popular plays during his lifetime and, along with Hamlet, is one of his most frequently performed plays", "William Shakespeare", "https://p.kindpng.com/picc/s/305-3059012_romeo-and-juliet-png-transparent-png.png", 1597, "Drama", "2"));
                DramaList.Add(new Drama(2, "Hamlet", "Hamlet, is a tragedy written by William Shakespeare sometime between 1599 and 1601. It is Shakespeare's longest play, with 29,551 words", "William Shakespeare", "https://kbimages1-a.akamaihd.net/5fc4252b-1c4f-40ef-9975-22982c94f12c/1200/1200/False/hamlet-prince-of-denmark-23.jpg,1604", 1599, "Drama", "1"));
                DramaList.Add(new Drama(3, "To Kill a Mockingbird", "To Kill a Mockingbird is a novel by the American author Harper Lee. It was published in 1960 and was instantly successful. In the United States, it is widely read in high schools and middle schools", "Harper Lee", "https://upload.wikimedia.org/wikipedia/commons/4/4f/To_Kill_a_Mockingbird_%28first_edition_cover%29.jpg",1960,"Drama","3"));
                DramaList.Add(new Drama(4, "A Raisin in the Sun", "A Raisin in the Sun is a play by Lorraine Hansberry that debuted on Broadway in 1959. The title comes from the poem 'Harlem' by Langston Hughes", "Lorraine Hansberry", "https://upload.wikimedia.org/wikipedia/en/c/c5/RaisinInTheSun.JPG",1959,"Drama","2"));


                EduList.Add(new Educational(1, "How To Solve It", "How to Solve It is a small volume by mathematician George Pólya describing methods of problem solving", "George Pólya", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1349052024l/192221.jpg", 1945, "Education", 3));
                EduList.Add(new Educational(2, "Relativity : the special and the general theory", "Relativity: The Special and the General Theory began as a short paper and was eventually published as a book written by Albert Einstein with the aim of explaining the theory of relativity.", "Albert Einstein", "https://kbimages1-a.akamaihd.net/299268a4-e02b-4a4b-a7e6-9b06159e1ce2/1200/1200/False/relativity-the-special-and-the-general-theory-1.jpg", 1916, "Education", 5));
                EduList.Add(new Educational(3, "How Children Succeed: Grit, Curiosity, and the Hidden Power of Character", "'How Children Succeed' introduces us to a new generation of scientists and educators who are radically changing our understanding of how children develop character, how they learn to think, and how they overcome adversity.", "Paul Tough", "https://karibaa.com/media/catalog/product/cache/6b4d3eae8253ca3bd0d222db1642f7cd/0/5/0544104404.jpg",2012,"Education",1));
                EduList.Add(new Educational(4, "What Is Mathematics?", "What Is Mathematics? is a mathematics book written by Richard Courant and Herbert Robbins, published in England by Oxford University Press. It is an introduction to mathematics, intended both for the mathematics student and for the general public.", "Herbert Robbins and Richard Courant", "https://kbimages1-a.akamaihd.net/6e6cc023-510f-4b20-a9f2-6fad9fcd8c25/1200/1200/False/what-is-mathematics-an-elementary-approach-to-ideas-and-methods.jpg",1941,"Education",1));


                PoetList.Add(new Poetry(1, "OutLander", "Outlander is a historical fantasy novel by Diana Gabaldon first published in 1991. Initially set around the time of the Second World War, it focuses on nurse Claire Beauchamp, who travels through time to 18th-century Scotland, where she finds adventure and romance with the dashing Jamie Fraser", "Diana Gabaldon", "https://kbimages1-a.akamaihd.net/326bb262-4454-4afb-9896-71b3364c1b62/1200/1200/False/outlander-11.jpg", 1991, "Poetry", 11, "Glascow"));
                PoetList.Add(new Poetry(2, "Bared To You", "Bared to You is a 2012 New York Times bestselling erotic new adult romance novel by veteran writer Sylvia Day, focusing on the complicated relationship between two twentysomething protagonists with equally abusive pasts", "Sylvia Day", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1433411511l/20448515._SY475_.jpg", 2012, "Poetry", 3, "London"));
                PoetList.Add(new Poetry(3, "The Complete Poetry", "The beauty and spirit of Maya Angelou’s words live on in this complete collection of poetry, including her inaugural poem “On the Pulse of Morning”Throughout her illustrious career in letters, Maya Angelou gifted, healed, and inspired the world with her words.", "Maya Angelou", "https://images.squarespace-cdn.com/content/v1/57e80fa215d5db790f3825f1/1587136069560-BM5H1GMKKMP5V0F1QUUX/MayaAngeloutheComplete.jpg?format=1000w", 2015, "Poetry", 1, "Washington D.C"));
                PoetList.Add(new Poetry(4, "Milk and honey", "Milk and Honey is a collection of poetry and prose by Rupi Kaur. The collection is about survival. It is divided into four sections, with each section serving a different purpose and relevance to Kaur’s experience. The sections explore the themes of violence, abuse, love, loss, and femininity", "Rupi Kaur", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1487289191l/25986827._SY475_.jpg",2014,"Poetry",1, "Bratislava"));


                
                PoetList.Add(new Poetry());
                DramaList.Add(new Drama());
                EduList.Add(new Educational());

                //Populate the Store list
                BookDB.AddRange(DramaList);
                BookDB.AddRange(PoetList);
                BookDB.AddRange(EduList);
            }
            else
            {
                BookDB.Clear();
                BookDB.AddRange(DramaList);
                BookDB.AddRange(PoetList);
                BookDB.AddRange(EduList);
                return;
            }
        }

        //Declare My Store list
        public static List<Book> BookDB = new List<Book>();

        // GET: Store
        public ActionResult Store()
        {
            InitialiseStore();

            return View(BookDB);
        }



        //All For Drama

        //Index Table
        [HttpGet]
        public ActionResult DramaIndex()
        {
            return View(DramaList);
        }

        //Create - View
        [HttpGet]
        public ActionResult AddDrama()
        {
            return View();
        }

        //Create - Action
        [HttpPost]
        public ActionResult AddDrama(Drama story)
        {
            DramaList.Add(story);
            return RedirectToAction("Store");
        }


        //Edit - View 
        [HttpGet]
        public ActionResult EditDrama(int Id)
        {
            Drama findDramaToEdit = DramaList.Where(x => x.ID == Id).FirstOrDefault();
            return View(findDramaToEdit);
        }

        //Edit - Posting Action
        [HttpPost]
        public ActionResult EditDrama(int Id, Drama editedDrama)
        {
            //Find
            Drama findDramaToEdit = DramaList.Where(x => x.ID == Id).FirstOrDefault();

            //Update
            findDramaToEdit = editedDrama;

            
            //Redirect back 
            return RedirectToAction("DramaIndex");
        }


        //Delete View
        [HttpGet]
        public ActionResult DeleteDrama(int Id)
        {
            Drama findDramaToEdit = DramaList.Where(x => x.ID == Id).FirstOrDefault();
            return View(findDramaToEdit);
        }

        //Delete - Posting Action

        [HttpDelete]
        public ActionResult DeleteDramaInList(int Id, Drama editedDrama)
        {
            Drama findDramaToEdit = DramaList.Where(x => x.ID == Id).FirstOrDefault();
            DramaList.Remove(findDramaToEdit);
            return RedirectToAction("DramaIndex");
        }











        //All For Education

        //Index Table
        [HttpGet]
        public ActionResult EduIndex()
        {
            return View(EduList);
        }

        //Create Xbox
        [HttpGet]
        public ActionResult AddEdu()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddEdu(Educational edu)
        {
            EduList.Add(edu);
            return View();
        }

        //Edit - View 
        [HttpGet]
        public ActionResult EditEdu(int Id)
        {
            Educational findEduToEdit = EduList.Where(x => x.ID == Id).FirstOrDefault();
            return View(findEduToEdit);
        }

        //Edit - Posting Action
        [HttpPost]
        public ActionResult EditEdu(int Id, Educational editedEdu)
        {
            //Find
            Educational findEduToEdit = EduList.Where(x => x.ID == Id).FirstOrDefault();

            //Update
            findEduToEdit = editedEdu;


            return RedirectToAction("EduIndex");
        }


        //Delete View
        [HttpGet]
        public ActionResult DeleteEdu(int Id)
        {
            Educational findEduToEdit = EduList.Where(x => x.ID == Id).FirstOrDefault();
            return View(findEduToEdit);
        }

        //Delete - Posting Action

        [HttpDelete]
        public ActionResult DeleteEduinList(int Id)
        {
            Educational findEduToEdit = EduList.Where(x => x.ID == Id).FirstOrDefault();
            EduList.Remove(findEduToEdit);
            return RedirectToAction("EduIndex");
        }



        //All For Poetry
        //Index Table
        [HttpGet]
        public ActionResult PoetIndex()
        {
            return View(PoetList);
        }

        //Create - View
        [HttpGet]
        public ActionResult AddPoetry()
        {
            return View();
        }

        //Create - Action
        [HttpPost]
        public ActionResult AddPoetry(Poetry poetry)
        {
            PoetList.Add(poetry);
            return RedirectToAction("Store");
        }


        //Edit - View 
        [HttpGet]
        public ActionResult EditPoetry(int Id)
        {
            Poetry findPoetryToEdit = PoetList.Where(x => x.ID == Id).FirstOrDefault();
            return View(findPoetryToEdit);
        }

        //Edit - Posting Action
        [HttpPost]
        public ActionResult EditPoetry(int Id, Poetry editedPoet)
        {
            //Find
            Poetry findPoetryToEdit = PoetList.Where(x => x.ID == Id).FirstOrDefault();

            //Update
            findPoetryToEdit = editedPoet;


            //Redirect back 
            return RedirectToAction("PoetIndex");
        }


        //Delete View
        [HttpGet]
        public ActionResult DeletePoet(int Id)
        {
            Poetry findPoetToDelete = PoetList.Where(x => x.ID == Id).FirstOrDefault();
            return View(findPoetToDelete);
        }

        //Delete - Posting Action

        [HttpDelete]
        public ActionResult DeletePoetInList(int Id)
        {
            Poetry findPoetToDelete = PoetList.Where(x => x.ID == Id).FirstOrDefault();
            PoetList.Remove(findPoetToDelete);
            return RedirectToAction("PoetIndex");
        }





        //Fake Login

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            if (Password == SitePassword && Username == SiteUsername)
            {
                return RedirectToAction("AdminDashboard");
            }
            else
            {
                ViewBag.Message = "Incorrect username or password!!";
                return View();
            }

        }

        [HttpGet]
        public ActionResult AdminDashboard()
        {
            return View();
        }
    }
}