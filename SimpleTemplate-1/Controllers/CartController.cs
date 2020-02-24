﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleTemplate_1.Models;
using SimpleTemplate_1.Infrastructure;
using System.Threading.Tasks;
using SimpleTemplate_1.Models.ViewModels;

namespace SimpleTemplate_1.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _repository;
        private Cart cart;

        public CartController(IProductRepository repository, Cart cartService)
        {
            _repository = repository;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public async Task<RedirectToActionResult> AddToCart(int productId, string returnUrl, decimal sum)
        {
            Product product = await _repository.Products
                .FirstOrDefaultAsync(p => p.ProductID == productId);
            sum = product.Price;
            if (product != null)
            {
                cart.AddItem(product, 1, sum);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public async Task<RedirectToActionResult> RemoveFromCart(int productId, string returnUrl)
        {
            Product product = await _repository.Products
                .FirstOrDefaultAsync(p => p.ProductID == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}
