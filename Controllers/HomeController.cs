﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebSec3_IPN.Data;
using WebSec3_IPN.Models;

namespace WebSec3_IPN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Home page shows list of items.
        // Item price is set through the ViewBag.
        public IActionResult Index()
        {
            return View("Index", "3.55|CAD");
        }

        //// Home page shows list of items.
        //// Item price is set through the ViewBag.
        //public IActionResult Transactions()
        //{
        //    DbSet<IPN> items = _context.IPNs;

        //    return View(items);
        //}

        //// This method receives and stores
        //// the Paypal transaction details.
        //[HttpPost]
        //public JsonResult PaySuccess([FromBody] IPN ipn)
        //{
        //    try
        //    {
        //        _context.IPNs.Add(ipn);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(ex.Message);
        //    }
        //    return Json(ipn);
        //}

        //// Home page shows list of items.
        //// Item price is set through the ViewBag.
        //public IActionResult Confirmation(string confirmationId)
        //{
        //    IPN transaction =
        //    _context.IPNs.FirstOrDefault(t => t.paymentID == confirmationId);

        //    return View("Confirmation", transaction);
        //}

    }
}