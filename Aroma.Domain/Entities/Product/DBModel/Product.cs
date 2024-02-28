using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma.Domain.Entities.Product.DBModel
{

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        // Можно добавить другие свойства, такие как категория, изображения, отзывы и т.д.
    }
}
