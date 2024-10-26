using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products {set;get;}
    }
}   