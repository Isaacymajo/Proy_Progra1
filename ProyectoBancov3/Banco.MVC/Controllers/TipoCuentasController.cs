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
using Banco.Entities.IRepositories;

namespace Banco.MVC.Controllers
{
    public class TipoCuentasController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;

        public TipoCuentasController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: TipoCuentas
        public ActionResult Index()
        {
            return View(_UnityOfWork.TipoCuentas.GetAll());
        }

        // GET: TipoCuentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCuenta tipoCuenta = _UnityOfWork.TipoCuentas.Get(id);
            if (tipoCuenta == null)
            {
                return HttpNotFound();
            }
            return View(tipoCuenta);
        }

        // GET: TipoCuentas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCuentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoCuentaId,Descripcion")] TipoCuenta tipoCuenta)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.TipoCuentas.Add(tipoCuenta);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoCuenta);
        }

        // GET: TipoCuentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCuenta tipoCuenta = _UnityOfWork.TipoCuentas.Get(id);
            if (tipoCuenta == null)
            {
                return HttpNotFound();
            }
            return View(tipoCuenta);
        }

        // POST: TipoCuentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoCuentaId,Descripcion")] TipoCuenta tipoCuenta)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(tipoCuenta);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoCuenta);
        }

        // GET: TipoCuentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCuenta tipoCuenta = _UnityOfWork.TipoCuentas.Get(id);
            if (tipoCuenta == null)
            {
                return HttpNotFound();
            }
            return View(tipoCuenta);
        }

        // POST: TipoCuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoCuenta tipoCuenta = _UnityOfWork.TipoCuentas.Get(id);
            _UnityOfWork.TipoCuentas.Delete(tipoCuenta);
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
