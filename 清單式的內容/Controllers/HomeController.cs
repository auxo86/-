using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 清單式的內容.Models;

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
            ViewBag.ary2 = new SelectList(ary1);
            ViewBag.ary3 = new SelectList(ary1, "台灣");

            List<UserInfo> userlist = new List<UserInfo>()
            {
                new UserInfo(){ID=1, Name="Tony", Age=33},
                new UserInfo(){ID=1, Name="Mary", Age=23},
                new UserInfo(){ID=1, Name="John", Age=13}
            };
            ViewBag.ary4 = new SelectList(userlist, "ID", "Name", userlist[0].ID);

            return View();
        }
    }
}