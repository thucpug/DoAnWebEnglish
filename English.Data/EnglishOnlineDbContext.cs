namespace English.Data
{
    using English.Model.Model;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EnglishOnlineDbContext : DbContext
    {
        // Your context has been configured to use a 'EnglishOnlineDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'English.Data.EnglishOnlineDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EnglishOnlineDbContext' 
        // connection string in the application configuration file.
        public EnglishOnlineDbContext()
            : base("name=EnglishOnlineDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<ResultLesson> ResultLessons { get; set; }
        public virtual DbSet<Text> Texts { get; set; }

        public static EnglishOnlineDbContext Create()
        {
            return new EnglishOnlineDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}