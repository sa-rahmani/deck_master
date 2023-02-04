using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSec3_IPN.Data;

using WebSec3_IPN.Repositories;
using WebSec3_IPN.ViewModels;

namespace WebSec3_IPN.Controllers
{

    public class RoleController : Controller
    {
        ApplicationDbContext _context;

        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Role
        public ActionResult Index()
        {
            RoleRepo roleRepo = new RoleRepo(_context);
            return View(roleRepo.GetAllRoles());
        }
        // GET: Role/Create
        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost] // POST: Role/Create
        public IActionResult Create([Bind("Id,RoleName")] RoleVM roleVM)
        {


            RoleRepo roleRepo = new RoleRepo(_context);
            bool created = false;
        

            if (ModelState.IsValid)
            {
                created = roleRepo.CreateRole(roleVM.RoleName);
                if (created)
                {
                    return RedirectToAction("Index", "Role");
                }
            }
           
           

            return View(roleVM);
        }

    }

}
