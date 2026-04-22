using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF01
{
    //Heart of Entity FramWork Core (EF) 
    internal class AppContext : DbContext 
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database=ReadMoreBooksDB ; Trusted_Connection=true;" +
                "TrustServerCertificate = true");
        }

        public DbSet <Models.Book> Books { get; set; }        //Table 
        public DbSet <Models.Author> Authors{ get; set; }     //Table 
        public DbSet <Models.Category>Categories{ get; set; } //Table 


    }
}
