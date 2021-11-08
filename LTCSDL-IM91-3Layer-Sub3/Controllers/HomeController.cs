using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTCSDL.IM91.BLL;
using LTCSDL.IM91.DTO;

namespace LTCSDL_IM91_3Layer_Sub3.Controllers
{
    public class HomeController : Controller
    {
        public List<Category> lst;
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            CategoryBLL bus = new CategoryBLL();
            lst = bus.GetAll();
            return View(lst);
        }
    }
}
