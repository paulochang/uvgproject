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
    public class CursoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cursoes
        public ActionResult Index()
        {
            return View(db.Cursos.ToList());
        }// GET: Admin
        public ActionResult Admin()
        {
            return View(db.Cursos.ToList());
        }

        // GET: Cursoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            CoursesSingleViewModel model = new CoursesSingleViewModel()
            {
                CursoActual = curso,
                Cursos = db.Cursos.ToList(),
                SelectedID = id
            };
            return View(model);
        }// GET: Cursoes/Details/5
        public ActionResult Articulos(int? id)
        {
            CoursesSingleViewModel model;
            if (id != null)
            {
                Curso curso = db.Cursos.Find(id);
                if (curso == null)
                {
                    return HttpNotFound();
                }

                model = new CoursesSingleViewModel()
                {
                    CursoActual = curso,
                    Cursos = db.Cursos.ToList(),
                    SelectedID = id
                };
            }
            else
            {
                model = new CoursesSingleViewModel()
                {
                    CursoActual = null,
                    Cursos = db.Cursos.ToList(),
                    SelectedID = null
                };
            }
            return View(model);
        }

        public ActionResult Videos(int? id)
        {
            CoursesSingleViewModel model;
            if (id != null)
            {
                Curso curso = db.Cursos.Find(id);
                if (curso == null)
                {
                    return HttpNotFound();
                }

                model = new CoursesSingleViewModel()
                {
                    CursoActual = curso,
                    Cursos = db.Cursos.ToList(),
                    SelectedID = id
                };
            }
            else
            {
                model = new CoursesSingleViewModel()
                {
                    CursoActual = null,
                    Cursos = db.Cursos.ToList(),
                    SelectedID = null
                };
            }
            return View(model);
        }

        // GET: Cursoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cursoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Codigo,Descripcion")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                db.Cursos.Add(curso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        // GET: Cursoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Cursoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Codigo,Descripcion")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curso);
        }

        // GET: Cursoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Cursoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Curso curso = db.Cursos.Find(id);
            db.Cursos.Remove(curso);
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
