using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _9_LINQ.Models;
using PagedList;

namespace _9_LINQ.Controllers
{
    public class ProductsController : Controller
    {
        private WineStoreDB db = new WineStoreDB();

		// GET: Products
		public ActionResult Index(string SortOrder, string SearchString, string CurrentFilter, int? page)
		{
			ViewBag.CurrentSort = SortOrder;
			ViewBag.XepTheoTen = string.IsNullOrEmpty(SortOrder) ? "name_desc" : "";
			ViewBag.XepTheoGia = SortOrder == "gia_asc" ? "gia_desc" : "gia_asc";
			ViewBag.XepTheoCata = SortOrder == "cata_asc" ? "cata_desc" : "cata_asc";
			var product = db.Product.Select(p => p);

			if (SearchString != null)
				page = 1;
			else
				SearchString = CurrentFilter;
			ViewBag.CurrentFilter = SearchString;

			if (!string.IsNullOrEmpty(SearchString))
				product = product.Where(p => p.ProductName.Contains(SearchString));

			switch (SortOrder)
			{
				case "name_desc":
					product = product.OrderByDescending(p => p.ProductName);
					break;
				case "gia_asc":
					product = product.OrderBy(p => p.Price);
					break;
				case "gia_desc":
					product = product.OrderByDescending(p => p.Price);
					break;
				case "cata_asc":
					product = product.OrderBy(p => p.CatalogyID);
					break;
				case "cata_desc":
					product = product.OrderByDescending(p => p.CatalogyID);
					break;
				default:
					product = product.OrderBy(p => p.ProductName);
					break;
			}

			int PageSize = 7;
			int PageNumber = (page ?? 1);
			return View(product.ToPagedList(PageNumber, PageSize));
		}

		// GET: Products/Details/5
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CatalogyID = new SelectList(db.Catalogy, "CatalogyID", "CatalogyName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CatalogyID = new SelectList(db.Catalogy, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogy, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogy, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
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
