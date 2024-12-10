using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCRUD.Models
{
   public class Book
    {
        [Key]
        public int BookId {  get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public int AuthorId {  get; set; }//foreign key
    }//? se nullable is enabled

}
