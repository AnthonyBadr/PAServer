using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PADatabase.Models;
using PADatabase.Models.SessionModel;

namespace PADatabase;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<PdfFile> PdfFiles { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseUser> CourseUsers{ get; set; }

    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<AssigmentStudent> AssigmentStudent { get; set; }


    public DbSet<PaymentUser> PaymentUsers { get; set; }

    public DbSet<Transaction> Transactions { get; set; }

    public DbSet<UserPersonalDetails> UserPersonalDetails { get; set; }

    public DbSet<Location> Location { get; set; }

    public DbSet<UserLocation> UserLocation { get; set; }

    public DbSet<PackageCodeList> PackageCodeLists { get; set; }

    public DbSet<Session> Sessions { get; set; }


}




