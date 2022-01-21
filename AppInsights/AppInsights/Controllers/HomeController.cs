using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppInsights.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var telemetryClient = new TelemetryClient();
            telemetryClient.InstrumentationKey = "489af2eb-1136-4abb-a779-9a56be206db7";

            telemetryClient.Context.Cloud.RoleInstance = "Lucy";
            telemetryClient.TrackEvent("This is a test event");
            telemetryClient.TrackMetric("Test Metric", 777);
            telemetryClient.TrackTrace("Test Trace Message", Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Information);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}