using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace General.Controllers
{
    public class FormulaController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult General(double a, double b, double c)
        {
            
            double rb = Math.Pow(b,2);
            double ac = (4 * a * c);
            double resta = rb - ac;
            double raiz = Math.Sqrt(resta);
            double di = 2 * a;

            double x1 = (((-b * di) + raiz )/ di);
            double x2 = (((-b * di) - raiz)/di);
            


            ViewBag.Potencia = x1;
            ViewBag.Resultado = x2;




            return View();
        }
    }
}