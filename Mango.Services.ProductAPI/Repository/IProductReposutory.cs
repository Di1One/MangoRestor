using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
