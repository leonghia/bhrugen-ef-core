﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess;

public class FluentBookDetailConfig : IEntityTypeConfiguration<Fluent_BookDetail>
{
    public void Configure(EntityTypeBuilder<Fluent_BookDetail> modelBuilder)
    {
        modelBuilder.HasKey(b => b.BookDetail_Id);
        modelBuilder.Property(b => b.NumberOfChapters).IsRequired();
    }
}
