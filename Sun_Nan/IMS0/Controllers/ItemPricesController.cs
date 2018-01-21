using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IMS.DAL;
using IMS.Models;

namespace IMS.Controllers
{
    public class ItemPricesController : Controller
    {
        private IMSContext db = new IMSContext();

        // GET: ItemPrices
        public ActionResult Index()
        {
            var itemPrices = db.ItemPrices.Include(i => i.Item).Include(i => i.Price);
            return View(itemPrices.ToList());
        }

        // GET: ItemPrices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemPrice itemPrice = db.ItemPrices.Find(id);
            if (itemPrice == null)
            {
                return HttpNotFound();
            }
            return View(itemPrice);
        }

        // GET: ItemPrices/Create
        public ActionResult Create()
        {
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Name");
            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name");
            return View();
        }

        // POST: ItemPrices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ItemId,PriceId,SalesPrice")] ItemPrice itemPrice)
        {
            if (ModelState.IsValid)
            {
                db.ItemPrices.Add(itemPrice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ItemId = new SelectList(db.Items, "Id", "Name", itemPrice.ItemId);
            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name", itemPrice.PriceId);
            return View(itemPrice);
        }

        // GET: ItemPrices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemPrice itemPrice = db.ItemPrices.Find(id);
            if (itemPrice == null)
            {
                return HttpNotFound();
            }
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Name", itemPrice.ItemId);
            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name", itemPrice.PriceId);
            return View(itemPrice);
        }

        // POST: ItemPrices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ItemId,PriceId,SalesPrice")] ItemPrice itemPrice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemPrice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Name", itemPrice.ItemId);
            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name", itemPrice.PriceId);
            return View(itemPrice);
        }

        // GET: ItemPrices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemPrice itemPrice = db.ItemPrices.Find(id);
            if (itemPrice == null)
            {
                return HttpNotFound();
            }
            return View(itemPrice);
        }

        // POST: ItemPrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemPrice itemPrice = db.ItemPrices.Find(id);
            db.ItemPrices.Remove(itemPrice);
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
