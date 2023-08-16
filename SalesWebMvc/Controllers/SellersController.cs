using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        /*Notações*/
        [HttpPost] /*Indica que é uma ação de post e não de get*/
        [ValidateAntiForgeryToken] /*previne ataques crfs(autenticação)*/
        public IActionResult Create(Seller seller)
        {
             _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
