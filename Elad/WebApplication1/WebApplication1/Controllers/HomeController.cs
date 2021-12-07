using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult CreateCity()
        {
            string nameCity = "בני ברק";
            BL bl = new BL();
            bl.CreateCity(nameCity);

            return View();
        }
        public ActionResult CreateStreet()
        {
            string nameStreet = "";
            string nameCity = "";
            BL bl = new BL();
            bl.CreateStreet(nameStreet,nameCity);

            return View();
        }
        public ActionResult DeleteCity()
        {
            string nameCity = "";
            BL bl = new BL();
            bl.DeleteCity(nameCity);

            return View();
        }
        public ActionResult GetStreetByCity()
        {
            int cityId = 1;
            BL bl = new BL();
            List<GetStreetsByCityId_Result>list=  bl.GetListStreetByCityId(cityId);
            
            return View();
        }
    }
}
