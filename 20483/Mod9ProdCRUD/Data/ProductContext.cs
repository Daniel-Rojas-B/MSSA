using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9ProdCRUD.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
    }
}
