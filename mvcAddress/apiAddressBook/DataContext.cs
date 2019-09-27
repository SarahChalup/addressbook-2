

namespace apiAddressBook
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiAddressBook.Models.Book> Books { get; set; }
    }
}