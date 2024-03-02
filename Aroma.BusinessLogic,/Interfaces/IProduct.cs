using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aroma.Domain.Entities.Product.DBModel;
namespace Aroma.BusinessLogic.Interfaces
{
    // Определение интерфейса для сервиса работы с продуктами
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);//добавить продукт 
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);

        // Методы для дополнительной функциональности, например:
        // List<Product> SearchProducts(string searchTerm);
        // List<Product> GetProductsByCategory(string category);
    }
}
