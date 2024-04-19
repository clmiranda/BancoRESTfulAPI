﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Apellido)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.FechaNacimiento)
                .IsRequired();

            builder.Property(c => c.Telefono)
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(100);

            builder.Property(c => c.Direccion)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.Edad);

            builder.Property(c => c.CreatedBy)
                .HasMaxLength(40);

            builder.Property(c => c.LastModifiedBy)
                .HasMaxLength(40);
        }
    }
}
