using Aroma.BusinessLogic.Core;
using Aroma.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aroma.Domain.Entities.Product;
using Aroma.Domain.Entities.Product.DBModel;


namespace Aroma.BusinessLogic.MainBL
{
    public class ProductBL : UserApi, IProduct

    {
        // Здесь вы можете подключить ваш DAL для работы с базой данных.

        public List<Product> GetAllProducts()
        {
            return ProductActionGetToList();
        }

        public Product GetProductById(int productId)
        {
            // Реализация получения продукта по идентификатору из базы данных
        }

        public void AddProduct(Product product)
        {
            // Реализация добавления нового продукта в базу данных
        }

        public void UpdateProduct(Product product)
        {
            // Реализация обновления существующего продукта в базе данных
        }

        public void DeleteProduct(int productId)
        {
            // Реализация удаления продукта из базы данных
        }

        // Реализации дополнительных методов, если они были объявлены в интерфейсе
    }
}
