using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id=1,
                    CategoryId=1,
                    Price=100,
                    Stock=10,
                    CreatedDate=DateTime.Now,
                    Name="Kalem1",
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Price = 200,
                    Stock = 20,
                    CreatedDate = DateTime.Now,
                    Name = "Kalem2",
                },
                  new Product
                  {
                      Id = 3,
                      CategoryId = 1,
                      Price = 300,
                      Stock = 30,
                      CreatedDate = DateTime.Now,
                      Name = "Kalem3",
                  },
                    new Product
                    {
                        Id = 4,
                        CategoryId = 2,
                        Price = 400,
                        Stock = 40,
                        CreatedDate = DateTime.Now,
                        Name = "Kitap1",
                    },
                      new Product
                      {
                          Id = 5,
                          CategoryId = 2,
                          Price = 500,
                          Stock = 50,
                          CreatedDate = DateTime.Now,
                          Name = "Kitap2",
                      },
                        new Product
                        {
                            Id = 6,
                            CategoryId = 3,
                            Price = 600,
                            Stock = 60,
                            CreatedDate = DateTime.Now,
                            Name = "Defter1",
                        }
                );

        }
    }
}
