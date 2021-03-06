﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entities;
using WebUI.Areas.Store.Models;
using DomainModel.Abstract;

namespace WebUI.Areas.Store.Controllers
{
    public class CartController : Controller
    {

        private IStoreRepository repository;
        public CartController(IStoreRepository repo)
        {
            repository = repo;
        }
        //public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        //{
        //    Product product = repository.Products
        //.FirstOrDefault(p => p.ProductID == productId);
        //    if (product != null)
        //    {
        //        GetCart().AddItem(product, 1);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}
        //public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        //{
        //    Product product = repository.Products
        //    .FirstOrDefault(p => p.ProductID == productId);
        //    if (product != null)
        //    {
        //        GetCart().RemoveLine(product);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}
