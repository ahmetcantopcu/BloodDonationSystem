using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=AHMETCAN;database=CoreBloodDb;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<EvaluationLegibility> EvaluationLegibilities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
