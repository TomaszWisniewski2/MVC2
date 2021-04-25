using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]
        public ActionResult Index(Calc c, string calculate)
        {
            if (calculate == "kwadrat")
            {
                c.tot = c.no1 * c.no1;
            }
            else if (calculate == "trójkąt")
            {
                c.tot = (c.no1 * c.no3) / 2;
            }
            else if (calculate == "koło")
            {
                c.tot = c.no1 * 3.14;
            }
            else if (calculate == "trapez")
            {
                c.tot = ((c.no1 + c.no2) * c.no3) / 2;
            }
            else if (calculate == "prostokąt")
            {
                c.tot = c.no1 * c.no2;
            }
            else if (calculate == "równoległobok")
            {
                c.tot = c.no1 * c.no3;
            }

            else//romb
            {
                c.tot = (c.no1 * c.no2) / 2;
            }
            return View(c);
        }
    }
}