using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinFormsApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public int InvNumber { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public string PublicationYear { get; set; }
        public string Genre { get; set; }
    }
}
