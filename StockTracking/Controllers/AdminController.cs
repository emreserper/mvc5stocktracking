﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockTracking.Models.Entity;
namespace StockTracking.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DbStockTrackingEntities db = new DbStockTrackingEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NewAdmin()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult NewAdmin(Admin p)
        {
            db.Admin.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}