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
    public class ArchivoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Archivoes
        public ActionResult Index()
        {
            return View(db.Archivoes.ToList());
        }

        // GET: Archivoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Archivo archivo = db.Archivoes.Find(id);
            if (archivo == null)
            {
                return HttpNotFound();
            }
            return View(archivo);
        }

        // GET: Archivoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Archivoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Archivo archivo)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in db.Archivoes)
                {
                    item.Name = "kaka";
                }
                db.Archivoes.Add(archivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(archivo);
        }

        // GET: Archivoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Archivo archivo = db.Archivoes.Find(id);
            if (archivo == null)
            {
                return HttpNotFound();
            }
            return View(archivo);
        }

        // POST: Archivoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Archivo archivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(archivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(archivo);
        }

        // GET: Archivoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Archivo archivo = db.Archivoes.Find(id);
            if (archivo == null)
            {
                return HttpNotFound();
            }
            return View(archivo);
        }

        // POST: Archivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Archivo archivo = db.Archivoes.Find(id);
            db.Archivoes.Remove(archivo);
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
