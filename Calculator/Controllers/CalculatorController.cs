using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Domain.Contracts;
using Calculator.Presentation.Models;

namespace Calculator.Presentation.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculator calculator;

        public CalculatorController()
        {
            calculator = new Domain.Core.Calculator();
        }

        public CalculatorController(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        // GET: Calculator
        public ActionResult Index()
        {
            return View(new MathsView());
        }

        // POST: Calculator
        public ActionResult Calculate(MathsView view)
        {
            view.ErrorMessage = null;
            try
            {
                view.Result = calculator.Calc(view.Expression).ToString();
            }
            catch (Exception)
            {
                view.ErrorMessage = "That is not a valid expression";
            }
            return View("Index", view);
        }
    }
}