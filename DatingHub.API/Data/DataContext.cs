using DatingHub.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingHub.API.Data
{
    public class DataContext: DbContext
    {
        //Create a constructor for this class. TIP: use ctor command
        //We pass in the context of this clas into the base class (DbContext)
        public DataContext (DbContextOptions<DataContext> options) : base(options){}

        //We need to tell the entity framework about this class. We need to give this class some properties
        public DbSet<Value> Values { get; set; }
    }
}