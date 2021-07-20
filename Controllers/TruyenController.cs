using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Doctruyenchua.Models;

namespace Doctruyenchua.Controllers
{
    public class TruyenController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Truyen
        public ActionResult Index()
        {
            return View(db.truyens.ToList());
        }

        // GET: Truyen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Truyen truyen = db.truyens.Find(id);
            if (truyen == null)
            {
                return HttpNotFound();
            }
            return View(truyen);
        }

        // GET: Truyen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Truyen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TenTruyen,AnhBia,TacGia,MoTaNgan,DateTime")] Truyen truyen)
        {
            if (ModelState.IsValid)
            {
                db.truyens.Add(truyen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(truyen);
        }

        // GET: Truyen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Truyen truyen = db.truyens.Find(id);
            if (truyen == null)
            {
                return HttpNotFound();
            }
            return View(truyen);
        }

        // POST: Truyen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TenTruyen,AnhBia,TacGia,MoTaNgan,DateTime")] Truyen truyen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truyen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(truyen);
        }

        // GET: Truyen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Truyen truyen = db.truyens.Find(id);
            if (truyen == null)
            {
                return HttpNotFound();
            }
            return View(truyen);
        }

        // POST: Truyen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Truyen truyen = db.truyens.Find(id);
            db.truyens.Remove(truyen);
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
