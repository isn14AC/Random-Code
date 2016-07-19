using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Random_APP.Models
{
    public class Class1

    {

        public string Name { get; set; }
        public string LastName { get; set; }
        [Key]
        public int NumberID { get; set; }
        public int age { get; set; }


    }

    public class ClassDBContext : DbContext
    {
        public ClassDBContext() : base("OnlineDB") { }
        public DbSet<Class1> Classes { get; set; }
    }

}