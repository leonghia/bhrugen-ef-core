using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess.FluentConfig;

public class FluentBookConfig : IEntityTypeConfiguration<Fluent_Book>
{
    public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
    {
        modelBuilder.HasKey(b => b.Book_Id);
        modelBuilder.Property(b => b.ISBN).IsRequired().HasMaxLength(15);
        modelBuilder.Property(b => b.Title).IsRequired();
        modelBuilder.Property(b => b.Price).IsRequired();
        modelBuilder.HasOne(b => b.BookDetail).WithOne(b => b.Book).HasForeignKey<Fluent_Book>("BookDetail_Id");
        modelBuilder.HasOne(b => b.Publisher).WithMany(b => b.Books).HasForeignKey(b => b.Publisher_Id);
    }
}
