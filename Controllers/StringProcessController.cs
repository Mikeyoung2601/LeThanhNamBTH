using Microsoft.AspNetCore.Mvc;
using LeThanhNamBTH.Models;

namespace LeThanhNamBTH.Controllers
{
    public class StringProcessController : Controller
    {
        Stringprocess strPro = new Stringprocess();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string strInput)
        {
            string strResult = strPro.RemoveRemainingWhiteSpace(strInput);
            ViewBag.thongTin = strResult;
            return View();
        }

         public IActionResult LowerUpper()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LowerUpper(string strInput)
        {
            string message = "";
            message = strPro.LowerToUpper(strInput);
            ViewBag.message = message;
            return View();
        }

        public IActionResult UpperToLower()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpperToLower(string strInput)
        {
            string message = "";
            message = strPro.UpperToLower(strInput);
            ViewBag.message = message;
            return View();
        }

        public IActionResult CapitalizeOneFirstCharacter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CapitalizeOneFirstCharacter(string strInput)
        {
            string message = "";
            message = strPro.CapitalizeOneFirstCharacter(strInput);
            ViewBag.message = message;
            return View();
        }

        public IActionResult VietHoaCacKyTuDau()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VietHoaCacKyTuDau(string strInput)
        {
            string message = "";
            message = strPro.CapitalizeFirstCharacter(strInput);
            ViewBag.message = message;
            return View();
        }
    }
}