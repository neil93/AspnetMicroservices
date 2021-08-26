using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        // 取得所有產品
        Task<IEnumerable<Product>> GetProducts();

        // 取得產品 - 使用編號
        Task<Product> GetProduct(string id);

        // 取得產品 - 使用名稱
        Task<IEnumerable<Product>> GetProductByName(string name);

        // 取得產品 - 使用分類名稱
        Task<IEnumerable<Product>> GetProductByCategory(string categoryName);

        // 建立產品
        Task CreateProduct(Product product);

        // 更新產品
        Task<bool> UpdateProduct(Product product);

        // 刪除產品
        Task<bool> DeleteProduct(string id);
    }
}