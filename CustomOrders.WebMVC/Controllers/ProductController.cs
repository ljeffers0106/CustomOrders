using CustomOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomOrders.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [Authorize]
        public ActionResult Index()
        {
            var model = new ProductListItem[0];
            return View(model);
        }
    }
}