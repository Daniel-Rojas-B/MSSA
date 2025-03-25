using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mod9CRUD.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        private Product[] GetProducts()
        {
            return new Product[]
            {
        new Product{Id=1, Name="Laptop", Description="HP", Price=900, Units=3},
        new Product{Id=2, Name="Speaker", Description="Jabra", Price=300, Units=2},
        new Product{Id=3, Name="Monitor", Description="Dell 34 inches", Price=200, Units=1},
        new Product{Id=4, Name="Webcam", Description="HP", Price=150, Units=5}

            };
        }
    }
    
}
