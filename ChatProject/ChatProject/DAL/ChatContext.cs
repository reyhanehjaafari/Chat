using ChatProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatProject.DAL
{
   
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
        }

        public DbSet<User> Courses { get; set; }
        public DbSet<History> Enrollments { get; set; }
        public DbSet<Message> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<History>().ToTable("History");
            modelBuilder.Entity<Message>().ToTable("Message");
        }
    }

}