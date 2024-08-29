using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           builder.HasKey(x => x.Id);
            //Id 1->1 artsın
           builder.Property(x=>x.Id).UseIdentityColumn();
            //Name boş olmasın ve max uzunluk 200 karakter olsun
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Stock).IsRequired();
            //Boş olmasın, Column type decimal ve toplamda 18 karakter virgülden sonra 2 karakter
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal (18,2)");
            //Tablo adı Products olsun
            builder.ToTable("Products");
            // Bir products'ın bir tane category olabilir. Bir categorynin birden fazla products2ı olabilir.ForeignKey=CategoryId
            builder.HasOne(x => x.Cateory).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
