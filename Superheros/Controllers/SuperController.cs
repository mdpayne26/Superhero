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
            List<Hero> ListofSuperheros = db.Heroes.ToList();
            return View(ListofSuperheros);
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
            //ViewBag.heroId = new SelectList(db.Heroes);
            return View();
        }

        // POST: Super/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Heroes.Add(hero);
                db.SaveChanges();
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
            ViewBag.heroId = new SelectList(db.Heroes);
            return View();
        }

        // POST: Super/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                //ViewBag.heroId = new SelectList(db.heros);
                Hero thisHero = db.Heroes.Where(h => h.Name == hero.Name).Single();
                thisHero.Name = hero.Name;
                thisHero.AlterEgo = hero.AlterEgo;
                thisHero.PrimarySuperHeroAbility = hero.PrimarySuperHeroAbility;
                thisHero.SecondarySuperHeroAbility = hero.SecondarySuperHeroAbility;
                thisHero.CatchPhrase = hero.CatchPhrase;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Super/Delete/5
        public ActionResult Delete(int id, Hero hero)
        {
            hero = db.Heroes.Where(h => h.Name == hero.Name).First();
            return View();
        }

        // POST: Super/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here
                hero = db.Heroes.Where(h => h.Name == hero.Name).First();
                db.Heroes.Remove(hero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
