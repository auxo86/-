using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 清單式的內容.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //DropDownBox ListBox
            //CheckBox RadioButton
            string[] ary1 = { "日本", "美國", "台灣", "韓國" };
            ViewBag.ary1 = ary1;
            return View();
        }
    }
}