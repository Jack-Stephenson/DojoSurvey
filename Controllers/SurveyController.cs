using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        public static Survey survey = new Survey();
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(Survey surveyInfo)
        {
            if (ModelState.IsValid)
            {
                survey = surveyInfo;
                return RedirectToAction("result");
            }
            return View("Index");
        }
        [HttpGet("result")]
        public IActionResult Result()
        {
            return View(model: survey);
        }
    }
}