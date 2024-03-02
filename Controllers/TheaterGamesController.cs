using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheaterReservationPage.Data;
using TheaterReservationPage.Models;

namespace TheaterReservationPage.Controllers
{
    public class TheaterGamesController : Controller
    {
        private TheaterReservationPageContext db = new TheaterReservationPageContext();

        // GET: TheaterGames
        public ActionResult Index()
        {
            return View(db.TheaterGames.ToList());
        }

        // GET: TheaterGames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheaterGames theaterGames = db.TheaterGames.Find(id);
            if (theaterGames == null)
            {
                return HttpNotFound();
            }
            return View(theaterGames);
        }

        // GET: TheaterGames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TheaterGames/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TheaterId,Plays,Title,Price")] TheaterGames theaterGames)
        {
            if (ModelState.IsValid)
            {
                db.TheaterGames.Add(theaterGames);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(theaterGames);
        }

        // GET: TheaterGames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheaterGames theaterGames = db.TheaterGames.Find(id);
            if (theaterGames == null)
            {
                return HttpNotFound();
            }
            return View(theaterGames);
        }

        // POST: TheaterGames/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TheaterId,Plays,Title,Price")] TheaterGames theaterGames)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theaterGames).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theaterGames);
        }

        // GET: TheaterGames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheaterGames theaterGames = db.TheaterGames.Find(id);
            if (theaterGames == null)
            {
                return HttpNotFound();
            }
            return View(theaterGames);
        }

        // POST: TheaterGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TheaterGames theaterGames = db.TheaterGames.Find(id);
            db.TheaterGames.Remove(theaterGames);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
