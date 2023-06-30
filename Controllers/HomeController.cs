﻿using IsTests.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IsTests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SomeTestClass> Items = new List<SomeTestClass>();
            Items.Add(new SomeTestClass() { ID = 1, Title = "Title 1", Data1 = "Data1 1", Data2 = "Data2 1", Data3 = "Data3 1", Data4 = "Data4 1", OtherTypeValue = new SomeTestClass.OtherType() { ID = 1, Title = "Ot1" } });
            Items.Add(new SomeTestClass() { ID = 2, Title = "Title 2", Data1 = "Data1 2", Data2 = "Data2 2", Data3 = "Data3 2", Data4 = "Data4 2", OtherTypeValue = new SomeTestClass.OtherType() { ID = 2, Title = "Ot2" } });
            Items.Add(new SomeTestClass() { ID = 3, Title = "Title 3", Data1 = "Data1 3", Data2 = "Data2 3", Data3 = "Data3 3", Data4 = "Data4 3", OtherTypeValue = new SomeTestClass.OtherType() { ID = 3, Title = "Ot3" } });
            Items.Add(new SomeTestClass() { ID = 4, Title = "Title 4", Data1 = "Data1 4", Data2 = "Data2 4", Data3 = "Data3 4", Data4 = "Data4 4", OtherTypeValue = new SomeTestClass.OtherType() { ID = 4, Title = "Ot4" } });
            Items.Add(new SomeTestClass() { ID = 5, Title = "Title 5", Data1 = "Data1 5", Data2 = "Data2 5", Data3 = "Data3 5", Data4 = "Data4 5", OtherTypeValue = new SomeTestClass.OtherType() { ID = 5, Title = "Ot5" } });

            ViewBag.Info = Items.Where(item => item.ID == 2 || item.ID == 3).ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}