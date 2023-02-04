using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSec3_IPN.Data;
using WebSec3_IPN.Models;

namespace WebSec3_IPN.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DbSet<Product> products = _context.Products;

            return View(products);
        }
    }
}
