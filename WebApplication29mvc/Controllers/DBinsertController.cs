using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication29mvc.Models;

namespace WebApplication29mvc.Controllers
{
    public class DBinsertController : Controller
    {
        AugustDBEntities dbobj = new AugustDBEntities();
        // GET: DBinsert
        public ActionResult Insert_pageload()
        {
            return View();
        }
        public ActionResult Insert_click(Class1 clsobj)
        {
            if (ModelState.IsValid)
            {
            dbobj.sp_stinsert(clsobj.name, clsobj.age, clsobj.address);
            clsobj.msg = "inserted";
            return View("Insert_pageload", clsobj);
             }
            return View("Insert_pageload", clsobj);
        }
    }
}