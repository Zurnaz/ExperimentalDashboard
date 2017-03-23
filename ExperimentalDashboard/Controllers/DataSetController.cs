using ExperimentalDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExperimentalDashboard.Controllers
{
    public class DataSetController : Controller
    {
        // GET: CitiesPopulationTimeline
        public ActionResult CitiesPopulationTimeline(Int16 start = -9999, Int16 end = 3000)
        {        
            
            CityPopulationDBContext cp = new CityPopulationDBContext();
            cp.Database.Connection.Open();
            // List<PopulationModel> CityPops = cp.PopulationModel.Where(p => p.Year >= start && p.Year <= end).ToList();
            var CityPops = from p in cp.PopulationModel
                           join c in cp.CityModel on p.CityId equals c.CityId
                           where p.Year >= start && p.Year <= end
                           group p by new { p.CityId, c.CityName, c.Country, p.certainty} into g
                           select new {
                                Name = g.Key.CityName,
                                Country = g.Key.Country,
                                Certainty = g.Key.certainty,
                                Population = g.Max(x => x.Population)                                
                           };

            cp.Database.Connection.Close();
            return View(CityPops);
            
        }

        public JsonResult CitiesPopulationService(Int16 start = -9999, Int16 end = 3000, int top = 100)
        {
            CityPopulationDBContext cp = new CityPopulationDBContext();
            cp.Database.Connection.Open();
            var CityPops = (from p in cp.PopulationModel
                           join c in cp.CityModel on p.CityId equals c.CityId
                           where p.Year >= start && p.Year <= end
                           group p by new { p.CityId, c.CityName, c.Country, p.certainty } into g
                           select new
                           {
                               Country = g.Key.Country,
                               City = g.Key.CityName,
                               Certainty = g.Key.certainty,
                               Population = g.Max(x => x.Population)
                           }).OrderByDescending(x => x.Population).Take(top);
            cp.Database.Connection.Close();
            return Json(CityPops, JsonRequestBehavior.AllowGet);
        }
    }

}