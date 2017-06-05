using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Banco.Entities;
using Banco.Persistence;

namespace Banco.MVC.Controllers
{
    public class AperturasController : Controller
    {
        private BancoDbContext db = new BancoDbContext();

        // GET: Aperturas
        public ActionResult Index()
        {
            var transaccions = db.Transaccions.Include(a => a.Tarjeta);
            return View(transaccions.ToList());
        }

        // GET: Aperturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apertura apertura = db.Transaccions.Find(id);
            if (apertura == null)
            {
                return HttpNotFound();
            }
            return View(apertura);
        }

        // GET: Aperturas/Create
        public ActionResult Create()
        {
            ViewBag.TarjetaId = new SelectList(db.Tarjetas, "TarjetaId", "Contraseña");
            return View();
        }

        // POST: Aperturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TransaccionId,CodigoSeguimiento,Fecha,TarjetaId,Tasa,TipoTarjeta,Saldo,FechaEntrega")] Apertura apertura)
        {
            if (ModelState.IsValid)
            {
                db.Transaccions.Add(apertura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TarjetaId = new SelectList(db.Tarjetas, "TarjetaId", "Contraseña", apertura.TarjetaId);
            return View(apertura);
        }

        // GET: Aperturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apertura apertura = db.Transaccions.Find(id);
            if (apertura == null)
            {
                return HttpNotFound();
            }
            ViewBag.TarjetaId = new SelectList(db.Tarjetas, "TarjetaId", "Contraseña", apertura.TarjetaId);
            return View(apertura);
        }

        // POST: Aperturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TransaccionId,CodigoSeguimiento,Fecha,TarjetaId,Tasa,TipoTarjeta,Saldo,FechaEntrega")] Apertura apertura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apertura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TarjetaId = new SelectList(db.Tarjetas, "TarjetaId", "Contraseña", apertura.TarjetaId);
            return View(apertura);
        }

        // GET: Aperturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apertura apertura = db.Transaccions.Find(id);
            if (apertura == null)
            {
                return HttpNotFound();
            }
            return View(apertura);
        }

        // POST: Aperturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apertura apertura = db.Transaccions.Find(id);
            db.Transaccions.Remove(apertura);
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
