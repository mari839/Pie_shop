using BethanyPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.ViewModels
{
    public class ShoppingCartViewModel //sxvanairad rato vqenit DI
    {
        public IShoppingCart ShoppingCart { get; } //amas rom gadavcemt rat gvinda model ar gvinda?
        public decimal ShoppingCartTotal { get;}

        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal) 
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
        }

    }
}
