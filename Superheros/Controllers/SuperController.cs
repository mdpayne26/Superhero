using Superheros.Models;
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
            //id = db.Heroes.Where(h => h.Name);
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
        public ActionResult Edit(int id, Hero hero)
        {
            //Employee thisEmployee = db.Employees.Where(e => e.EmployeeId == employee.EmployeeId).Single();
            ViewBag.heroId = new SelectList(db.Heroes);
            Hero thisHero = db.Heroes.Where(h => h.HeroId == hero.HeroId).single();
            thisHero.Name = hero.Name;
            thisHero.AlterEgo = hero.AlterEgo;
            thisHero.PrimarySuperHeroAbility = hero.PrimarySuperHeroAbility;
            thisHero.SecondarySuperHeroAbility = hero.SecondarySuperHeroAbility;
            thisHero.CatchPhrase = hero.CatchPhrase;
            db.SaveChanges();
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
