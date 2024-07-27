using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PADatabase.Models;


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

    public DbSet<SessionStudent> SessionStudents { get; set; }

   public DbSet<UserSummaries> UserSummaries { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SessionStudent>()
            .HasOne(ss => ss.Session)
            .WithMany(s => s.SessionStudents)
            .HasForeignKey(ss => ss.SessionId);

        modelBuilder.Entity<SessionStudent>()
            .HasOne(ss => ss.User)
            .WithMany()
            .HasForeignKey(ss => ss.UserId);

        modelBuilder.Entity<UserPersonalDetails>()
           .HasKey(upd => upd.UserId);

        modelBuilder.Entity<UserPersonalDetails>()
            .HasOne(upd => upd.User)
            .WithOne()
            .HasForeignKey<UserPersonalDetails>(upd => upd.UserId);

        modelBuilder.Entity<UserSummaries>()
             .HasOne(us => us.UserPersonalDetail)
             .WithMany(ud => ud.UserSummaries)
             .HasForeignKey(us => us.UserId)
             .HasPrincipalKey(ud => ud.UserId);

        modelBuilder.Entity<UserSummaries>()
     .HasOne(us => us.UserPersonalDetail)
     .WithMany(ud => ud.UserSummaries)
     .HasForeignKey(us => us.UserId)
     .HasPrincipalKey(ud => ud.UserId);

        modelBuilder.Entity<Session>()
                .HasOne(s => s.UserSummaries)
                .WithMany(us => us.Sessions)
                .HasForeignKey(s => s.UserSummariesId);

        base.OnModelCreating(modelBuilder);
    }






}




