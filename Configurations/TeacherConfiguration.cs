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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.HasOne(x => x.Department)
                .WithMany(x => x.Teachers)
                .HasForeignKey(x => x.Id_Dep);
        }
    }
}
