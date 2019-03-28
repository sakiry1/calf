using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("Calculator")]
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index(double num1, double num2)
        {
            var clase = new CalculatorClass();

            return View(clase);
            //return View(new CalculatorClass()); //son lo mismo
        }

        // POST: Calculator/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CalculatorClass calculator)
        {
            var n = calculator.Valor1.GetType();
            var n1 = calculator.Valor2.GetType();
            var op = calculator.Operador.GetType();
            
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}