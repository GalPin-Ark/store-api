using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookStore.Domain.Models;

namespace BookStore.Infrastructure.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(hk => hk.Id);

            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar(150)");

            /* 1 : N => Category : Books */
            builder.HasMany(b => b.Books).WithOne(b => b.Category).HasForeignKey(b => b.CategoryId);

            builder.ToTable("Categories");
        }
    }
}
