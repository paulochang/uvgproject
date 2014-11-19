using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UVGProject.Models;

namespace UVGProject.Controllers
{
    public class Entrada_RespuestaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Entrada_Respuesta
        public ActionResult Index()
        {
            return View(db.Entrada_Respuestas.ToList());
        }

        // GET: Entrada_Respuesta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrada_Respuesta entrada_Respuesta = db.Entrada_Respuestas.Find(id);
            if (entrada_Respuesta == null)
            {
                return HttpNotFound();
            }
            return View(entrada_Respuesta);
        }

        // GET: Entrada_Respuesta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entrada_Respuesta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] Entrada_Respuesta entrada_Respuesta)
        {
            if (ModelState.IsValid)
            {
                db.Entrada_Respuestas.Add(entrada_Respuesta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrada_Respuesta);
        }

        // GET: Entrada_Respuesta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrada_Respuesta entrada_Respuesta = db.Entrada_Respuestas.Find(id);
            if (entrada_Respuesta == null)
            {
                return HttpNotFound();
            }
            return View(entrada_Respuesta);
        }

        // POST: Entrada_Respuesta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] Entrada_Respuesta entrada_Respuesta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrada_Respuesta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrada_Respuesta);
        }

        // GET: Entrada_Respuesta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrada_Respuesta entrada_Respuesta = db.Entrada_Respuestas.Find(id);
            if (entrada_Respuesta == null)
            {
                return HttpNotFound();
            }
            return View(entrada_Respuesta);
        }

        // POST: Entrada_Respuesta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entrada_Respuesta entrada_Respuesta = db.Entrada_Respuestas.Find(id);
            db.Entrada_Respuestas.Remove(entrada_Respuesta);
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
