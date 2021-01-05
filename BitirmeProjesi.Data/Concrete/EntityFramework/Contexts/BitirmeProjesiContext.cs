using BitirmeProjesi.Data.Concrete.EntityFramework.Mappings;
using BitirmeProjesi.Entities.Concrete;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Contexts
{
    public class BitirmeProjesiContext:IdentityDbContext<User,Role,int,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
    {
        public BitirmeProjesiContext(DbContextOptions<BitirmeProjesiContext> options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookComment> BookComments { get; set; }
        public DbSet<MovieComment> MovieComments { get; set; }
        public DbSet<SerieComment> SerieComments { get; set; }

        public DbSet<BookQuestion> BookQuestions { get; set; }
        public DbSet<SerieQuestion> SerieQuestions { get; set; }
        public DbSet<MovieQuestion> MovieQuestions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieMap());
            modelBuilder.ApplyConfiguration(new SerieMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new BookCommentMap());
            modelBuilder.ApplyConfiguration(new SerieCommentMap());
            modelBuilder.ApplyConfiguration(new MovieCommentMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
            modelBuilder.ApplyConfiguration(new BookQuestionMap());
            modelBuilder.ApplyConfiguration(new MovieQuestionMap());
            modelBuilder.ApplyConfiguration(new SerieQuestionMap());

        }
    }
}
