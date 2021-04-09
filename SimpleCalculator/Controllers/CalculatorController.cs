using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Models;
using System;

namespace SimpleCalculator.Controllers
{
    public class Calculator : Controller
    {
        // Define array only for 5 calculations
        private static string[] lastFiveCalculations = new string[5];
 
        [HttpGet]
        public IActionResult Index()
        {
           return View(new Calculation());
        }

        [HttpPost]
        public IActionResult Index(Calculation model)
        {

            if (model.OperationType == OperationType.Division && model.SecondNumber == 0)
            {
                ViewBag.ErrorOutput = "Can't divide by Zero!";
                return View(model);
            }
            if (model.OperationType == 0)
            {
                ViewBag.ErrorOutput = "Can't calculate without operation type!";
                return View(model);
            }
            Calculations calculations = new Calculations();

            model.Result = calculations.Calculate(
                model.FirstNumber,
                model.SecondNumber,
                model.OperationType.ToString());

            SaveLastFiveCalculations save = new SaveLastFiveCalculations();

            lastFiveCalculations = save.SaveCalculations(
                lastFiveCalculations,
                model.FirstNumber.ToString(),
                model.SecondNumber.ToString(),
                model.OperationType.ToString(),
                model.Result.ToString());

            model.LastFiveCalculations = lastFiveCalculations;

            return View(model);
        }
    }
}