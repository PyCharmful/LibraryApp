using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinFormsApp.Data
{
    public class BookExchange
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }

        public Book Book { get; set; }

        [ForeignKey(nameof(Stuff))]
        public int StuffId { get; set; }
        public Stuff Stuff { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateOperation { get; set; }
    }
}
