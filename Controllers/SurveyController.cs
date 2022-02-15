using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        public static List<string> FormInfo = new List<string>();
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("post")]
        public IActionResult Post(string name, string location, string language, string comment)
        {
            FormInfo.Add(name);
            FormInfo.Add(location);
            FormInfo.Add(language);
            FormInfo.Add(comment);
            return RedirectToAction("Result");
        }
        [HttpGet("result")]
        public ViewResult Result()
        {
            ViewBag.FormInfo = FormInfo;
            return View("Result");
        }
    }
}