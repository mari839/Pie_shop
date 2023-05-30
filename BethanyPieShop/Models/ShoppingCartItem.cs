namespace BethanyPieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pie Pie { get; set; } = default!;
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; } //GUID, when I come to the site i will get a new shoppingCartId, so when i store items in the shopping cart,
                                                    //im just going to store in the database shoppingcartitems all associated with that given shoppingcartid
    }
}
