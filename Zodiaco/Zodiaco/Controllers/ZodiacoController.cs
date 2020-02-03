using Zodiaco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zodiaco.Controllers
{
    public class ZodiacoController : Controller
    {
        public IActionResult Persona(int dia, int mes)
        {

           if(dia >= 20  && mes == 1 || dia <= 18 && mes == 2)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es Acuario";
            }else if (dia>18 && mes == 2 || dia <= 20 && mes == 3)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es Piscis";
            }else if (dia >=21 && mes ==3 || dia <=20 && mes == 4)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Aries";
            }else if(dia > 20 && mes == 4 || dia <= 20 && mes == 5)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Tauro";
            }else if (dia>20 && mes== 5 || dia<=24 && mes ==6 )
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Geminis";
            }else if (dia >24 && mes == 6|| dia<=22 && mes == 7)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Cancer";
            }else if(dia > 22 && mes==7 || dia <= 23 && mes == 8)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Leo";
            }else if (dia > 23 && mes ==8 || dia <=23 && mes==9)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Virgo";
            }else if (dia >23 && mes ==9 || dia <= 22 && mes == 10)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Libra";
            }else if (dia>22 && mes == 10 || dia <= 22 && mes==11)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Escorpio";
            }else if (dia>22 && mes == 11 || dia <= 21 && mes ==12)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Sagitario";
            }else if (dia > 21 && mes == 12 || dia <=19 && mes == 1)
            {
                ViewBag.Saludo = "Tu signo Zodiacal es: Capricornio";
            }
            else
            {
                ViewBag.Saludo = "Gracias";
            }
           
            return View(ViewBag);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}