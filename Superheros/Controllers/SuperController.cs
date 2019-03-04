﻿using Superheros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheros.Controllers
{
    public class SuperController : Controller
    {
        ApplicationDbContext db;
        public SuperController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Super
        public ActionResult Index()
        {
            ViewBag.heroId = new SelectList(db.Heroes);
            return View();
        }

        // GET: Super/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.heroId = new SelectList(db.Heroes);
            return View();
        }

        // GET: Super/Create
        public ActionResult Create()
        {
            ViewBag.heroId = new SelectList(db.Heroes);
            return View();
        }

        // POST: Super/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Super/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Super/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Super/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Super/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
