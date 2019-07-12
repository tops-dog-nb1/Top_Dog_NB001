using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BWXM2_MVC.Models;

namespace BWXM2_MVC.Controllers
{
    public class GoodsController : Controller
    {
        HttpClientHelper client = new HttpClientHelper();
        // GET: Goods
        public ActionResult GoodsShow()
        {
            return View();
        }
    }
}