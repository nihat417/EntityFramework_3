using EntityFramework_3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Id_Press)
                .IsRequired();
            builder.Property(x => x.Id_Category)
                .IsRequired();
            builder.Property(x => x.Id_Theme)
                .IsRequired();
            builder.Property(x => x.Id_Author)
                .IsRequired();
            builder.Property(x => x.Quantity)
                .HasDefaultValue(1);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(x => x.Comment)
                .IsRequired(false)
                .HasColumnType("nvarchar(30)");

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.Id_Author);

            builder.HasOne(x => x.Theme)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.Id_Theme);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.Id_Category);

            builder.HasOne(x => x.Press)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.Id_Press);
        }
    }
}
