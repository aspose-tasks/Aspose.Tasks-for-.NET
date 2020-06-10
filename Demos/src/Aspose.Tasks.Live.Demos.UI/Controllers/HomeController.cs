using Aspose.Tasks.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Tasks.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "View or Convert MS Project files to PDF, XLSX, HTML, Primavera";
			ViewBag.MetaDescription = "Vigorous Web Apps to View &amp; Convert Microsoft Project files (MPP &amp; XML) without leaving your browser. Transform to PDF, Primavera, HTML, XLSX, XPS and XML";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
