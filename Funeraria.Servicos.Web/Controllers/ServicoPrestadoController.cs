using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Funeraria.Servico.Data.Entity.Context;
using Funeraria.Servico.Dominio;

namespace Funeraria.Servicos.Web.Controllers
{
    public class ServicoPrestadoController : Controller
    {
        private FunerariaDbContext db = new FunerariaDbContext();

        // GET: ServicoPrestado
        public ActionResult Index()
        {
            return View(db.servicos.ToList());
        }

        // GET: ServicoPrestado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicoPrestado servicoPrestado = db.servicos.Find(id);
            if (servicoPrestado == null)
            {
                return HttpNotFound();
            }
            return View(servicoPrestado);
        }

        // GET: ServicoPrestado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicoPrestado/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Data,Valor,Desc")] ServicoPrestado servicoPrestado)
        {
            if (ModelState.IsValid)
            {
                db.servicos.Add(servicoPrestado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicoPrestado);
        }

        // GET: ServicoPrestado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicoPrestado servicoPrestado = db.servicos.Find(id);
            if (servicoPrestado == null)
            {
                return HttpNotFound();
            }
            return View(servicoPrestado);
        }

        // POST: ServicoPrestado/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Data,Valor,Desc")] ServicoPrestado servicoPrestado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicoPrestado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicoPrestado);
        }

        // GET: ServicoPrestado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicoPrestado servicoPrestado = db.servicos.Find(id);
            if (servicoPrestado == null)
            {
                return HttpNotFound();
            }
            return View(servicoPrestado);
        }

        // POST: ServicoPrestado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicoPrestado servicoPrestado = db.servicos.Find(id);
            db.servicos.Remove(servicoPrestado);
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
