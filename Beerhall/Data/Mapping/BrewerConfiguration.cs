using BeerHall.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beerhall.Data.Mapping
{
    public class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            // Table name
            builder.ToTable("Brewer");

            // Primary Key
            builder.HasKey(b => b.BrewerId); // automatisch (<class>id)
            // samengestelde sleutel: builder.HasKey(b => new{b.OrderId, b.ProductId});

            // Properties
            builder.Property(b => b.BrewerId)
                .ValueGeneratedOnAdd();
            // .ValueGeneratedNever() .ValueGeneratedOnAddOrUpdate()

            builder.Property(b => b.Name)
                .HasColumnName("BrewerName")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(b => b.ContactEmail)
                .HasMaxLength(64);
            // others:
            // .HasDefaultValue("value")

            builder.HasMany(b => b.Beers).WithOne().IsRequired().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
