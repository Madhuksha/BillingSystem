using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillingSystem.Models;
using BillingSystem.Repository;

namespace BillingSystem.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        public ActionResult Index()
        {
            Data data = new Data();
            var list =data.GetAllDetails();
            return View(list);
        }

        public ActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Create(BillDetail details)
        {
            Data data = new Data();
            data.SaveBillDetails(details);
            ModelState.Clear();
            return View();
        }

        public ActionResult CreateItem(Items item)
        {
            return PartialView("_CreateItem", item);
        }

        public ActionResult ViewBill(int Id)
        {
            Data data =new Data();
            var details = data.GetDetail(Id);
            return View(details);
        }
    }
}