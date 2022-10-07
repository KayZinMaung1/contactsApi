using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Data
{
    public class ContactsAPIDbContext: DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
