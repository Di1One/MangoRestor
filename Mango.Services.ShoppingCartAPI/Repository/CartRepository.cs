using Mango.Services.ShoppingCartAPI.Models.Dto;

namespace Mango.Services.ShoppingCartAPI.Repository
{
    public class CartRepository : ICartRepository
    {
        public async Task<bool> ClearCartAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<CartDto> CreateUpdateCartAsync(CartDto cartDto)
        {
            throw new NotImplementedException();
        }

        public async Task<CartDto> GetCartByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveFromCartAsync(int cartDetaitlsId)
        {
            throw new NotImplementedException();
        }
    }
}
