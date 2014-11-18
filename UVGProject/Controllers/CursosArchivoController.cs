using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UVGProject.Controllers
{
    public class CursosArchivoController : Controller
    {
        // GET: CursosArchivo
        public ActionResult Index()
        {
            return View();
        }
    }
    [HttpPost]
    public ActionResult Upload(string descripcion, HttpPostedFileBase fichero)
    {
    fichero.SaveAs(Path.Combine(@"d:\temp", Path.GetFileName(fichero.FileName)));
    return View();
    }
}