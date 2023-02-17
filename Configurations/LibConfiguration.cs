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
    public class LibConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");
        }
    }

}
