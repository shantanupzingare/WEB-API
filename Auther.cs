using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCRUD.Models
{
    public class Author
    {
        [Key]
        public int AutherId {  get; set; }  //primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }//Indicate one to many relation->
        //one author can write many books and collected in Icollection
    }
}
//var r=from rng in db.Books where rng.Bookid ==1 select rng;
//var r1=db.Books.Where<Book>(x=>x.BooksId==1).Select(data=>data );