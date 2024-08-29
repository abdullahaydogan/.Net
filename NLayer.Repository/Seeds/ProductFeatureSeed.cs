using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id=1,
                    Color="Red",
                    Height=100,
                    Width = 200,
                    ProductId=1,
                },
                new ProductFeature
                {
                    Id = 2,
                    Color="Blue",
                    Height=200,
                    Width=300,
                    ProductId=2,
                },
                new ProductFeature
                {
                    Id=3,
                    Color="Yellow",
                    Height=300,
                    Width=400,
                    ProductId=3,
                }

                );

        }
    }
}
