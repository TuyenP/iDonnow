using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Home.Models;


namespace Home.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult Index()
        {
            using (DsSach a = new DsSach())
            {
                return View(a.Sach.ToList());
            }
           
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Sach sach)
        {
            try
            {
                using (DsSach a = new DsSach())
                {
                    a.Sach.Add(sach);
                    a.SaveChanges();

                }
                return RedirectToAction("Index");
            }


            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int Id)
        {
            using (DsSach a = new DsSach())
            {
                return View(a.Sach.Where(Medol => Medol.Id == Id).FirstOrDefault());
            }
        }

        [HttpPost]

        public ActionResult Edit(int Id, Sach sach)
        {
            try
            {
                using (DsSach a = new DsSach())
                {
                    a.Entry(sach).State = EntityState.Modified;
                    a.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Id)
        {
            using (DsSach a = new DsSach())
            {
                return View(a.Sach.Where(Medol => Medol.Id == Id).FirstOrDefault());
            }
        }

        [HttpPost]

        public ActionResult Delete(int Id,FormCollection collection)
        {
            try
            {
                using (DsSach a = new DsSach())
                {
                    Sach sach = a.Sach.Where(Medol => Medol.Id == Id).FirstOrDefault();
                    a.Sach.Remove(sach);
                    a.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}