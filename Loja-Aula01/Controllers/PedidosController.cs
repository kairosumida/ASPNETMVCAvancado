﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Loja_Aula01.DAL;
using Loja_Aula01.Models;

namespace Loja_Aula01.Controllers
{
    public class PedidosController : Controller
    {
        private LojaDbContext db = new LojaDbContext();

        // GET: Pedidos
        public ActionResult Index()
        {
            var pedidos = db.Pedidos.Include(p => p.Cliente).Include(p => p.Produto);
            return View(pedidos.ToList());
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedido pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Descricao");
            return View();
        }

        // POST: Pedidos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PedidoId,Data,ClienteId,ProdutoId")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                db.Pedidos.Add(pedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome", pedido.ClienteId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedido pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome", pedido.ClienteId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PedidoId,Data,ClienteId,ProdutoId")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome", pedido.ClienteId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedido pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pedido pedido = db.Pedidos.Find(id);
            db.Pedidos.Remove(pedido);
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
