using AS.DbFirst;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AS.MVCFramework.Controllers
{
    public class RegionsController : Controller
    {
        // GET: Regions
        public ActionResult Index()
        {
            var regions = GetRegions();

            return View(regions);
        }

        private List<DbFirst.Region> GetRegions()
        {
            using (var db = new StateStatisticsDBEntities())
            {
                var regions = db.Regions.ToList();
                return regions;
            }
        }
    } }