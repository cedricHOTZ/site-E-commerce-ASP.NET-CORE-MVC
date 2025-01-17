﻿using Microsoft.AspNetCore.Mvc;
using ProjetAspCore.Models;
using ProjetAspCore.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal();
            return View(shoppingCartViewModel);
        }
    }
}
