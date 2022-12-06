using System.CodeDom.Compiler;
using API.Entities;
using Microsoft.EntityFrameworkCore;


namespace API.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
            //Dbset call in to list form 
            //the  AppUser.cs class on the
            //Entities Folder

            //The users is the table of the database
        public DbSet<AppUser> Users {get; set;}
    }
}