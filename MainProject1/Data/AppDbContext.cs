using MainProject1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Buffers.Text;

namespace MainProject1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member_Chapter>().HasKey(am => new
            {
                am.MemberId,
                am.ChapterId
            });
            modelBuilder.Entity<Member_Chapter>().HasOne(m => m.chapter).WithMany(am => am.Member_Chapters).HasForeignKey(m => m.ChapterId);
            modelBuilder.Entity<Member_Chapter>().HasOne(m => m.member).WithMany(am => am.Member_Chapters).HasForeignKey(m => m.ChapterId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Members> members { get; set; }
        public DbSet<Chapters> chapters { get; set; }
        public DbSet<Member_Chapter> Member_Chapter { get; set; }
        public DbSet<Colleges> Colleges  { get; set; }
        public DbSet<Leaders> Leaders { get; set; }
    }
}
