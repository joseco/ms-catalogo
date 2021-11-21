using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence.EntityConfiguration
{
    public class ArticuloConfig : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("articuloId");

            builder.Property(x => x.Codigo)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("codigo");

            builder.Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("descripcion");


            builder.Property(x => x.Precio)
                .IsRequired()
                .HasPrecision(10,2)
                .HasColumnName("precio");
        }
    }
}
