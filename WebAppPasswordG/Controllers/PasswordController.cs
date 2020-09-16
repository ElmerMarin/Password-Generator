using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPasswordG.Controllers
{
    public class PasswordController : Controller
    {
        // GET: Password
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(bool? numeros, bool? minusculas, bool? mayusculas, bool? simbolos, string longitud)
        {

            Random rdn = new Random();
            string cadena = "";
            string Minusculas = "";
            string Mayusculas = "";
            string Numeros = "1234567890";
            string Simbolos = "%$#@<>?¡¿()+-*/:.;,{}|¬&#!_-";

            for (int i = 97; i < 123; i++)
            {
                Minusculas = Minusculas + char.ConvertFromUtf32(i);


            }

            for (int i = 65; i < 91; i++)
            {
                Mayusculas = Mayusculas + char.ConvertFromUtf32(i);


            }


            if (numeros == true)
            {
                cadena = cadena + Numeros;

            }

            if (minusculas == true)
                cadena = cadena + Minusculas;

            {

            }
            if (mayusculas == true)
                cadena = cadena + Mayusculas;
            {


            }
            if (simbolos == true)
            {
                cadena = cadena + Simbolos;


            }



            int longitudcadena = cadena.Length;
            char letra;
            int longitudContrasenia = Convert.ToInt32(longitud);
            string contraseniaAleatoria = "";
            for (int i = 0; i < longitudContrasenia && longitudcadena>0; i++)
            {
                letra = cadena[rdn.Next(longitudcadena)];
                contraseniaAleatoria += letra.ToString();
            }


            ViewBag.Result = contraseniaAleatoria;
            return View();
        }
    }
}