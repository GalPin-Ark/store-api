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
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(150)");

            builder.Property(x => x.Author).IsRequired().HasColumnType("varchar(150)");

            builder.Property(x => x.Description).IsRequired(false).HasColumnType("varchar(350)");

            builder.Property(x => x.Value).IsRequired();

            builder.Property(x => x.PublishDate).IsRequired();

            builder.Property(x => x.CategoryId).IsRequired();

            builder.ToTable("Books");

        }
    }
}
