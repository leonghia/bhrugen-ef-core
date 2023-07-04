using Microsoft.EntityFrameworkCore;
using WizLib_DataAccess.FluentConfig;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Book> Books { get; set; } 
    public DbSet<Author> Authors { get; set; } 
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<BookDetail> BookDetails { get; set; }
    public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
    public DbSet<Fluent_Book> Fluent_Books { get; set; }
    public DbSet<Fluent_Author> Fluent_Authors { get; set; }
    public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Categories
        modelBuilder.Entity<Category>().ToTable("tbl_Categories");
        modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");

        // Fluent_BookDetails
        // modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id);
        // modelBuilder.Entity<Fluent_BookDetail>().Property(b => b.NumberOfChapters).IsRequired();

        // Fluent_Books
        // modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Book_Id);
        // modelBuilder.Entity<Fluent_Book>().Property(b => b.ISBN).IsRequired().HasMaxLength(15);
        // modelBuilder.Entity<Fluent_Book>().Property(b => b.Title).IsRequired();
        // modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();

        // Fluent_Authors
        // modelBuilder.Entity<Fluent_Author>().HasKey(a => a.Author_Id);
        // modelBuilder.Entity<Fluent_Author>().Property(a => a.FirstName).IsRequired();
        // modelBuilder.Entity<Fluent_Author>().Property(a => a.LastName).IsRequired();
        // modelBuilder.Entity<Fluent_Author>().Ignore(a => a.FullName);

        // Fluent_Publishers
        // modelBuilder.Entity<Fluent_Publisher>().HasKey(p => p.Publisher_Id);
        // modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Name).IsRequired();
        // modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Location).IsRequired();

        // Fluent_Books - Fluent_BookDetails (1 - 1)
        // modelBuilder.Entity<Fluent_Book>().HasOne(b => b.BookDetail).WithOne(b => b.Book).HasForeignKey<Fluent_Book>("BookDetail_Id");

        // Fluent_Books - Fluent_Publishers (N - 1)
        // modelBuilder.Entity<Fluent_Book>().HasOne(b => b.Publisher).WithMany(b => b.Books).HasForeignKey(b => b.Publisher_Id);

        modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
        modelBuilder.ApplyConfiguration(new FluentBookConfig());
        modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
        modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
    } 
}
