using Aspose.Tasks.Live.Demos.UI.Models.Common;
using Aspose.Tasks.Live.Demos.UI.Models;
using Aspose.Tasks.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Tasks.Live.Demos.UI.Controllers
{
	public class MetadataController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];

		public ActionResult Metadata()
		{
			var model = new ViewModel(this, "Metadata")
			{
				ControlsView = "MetadataControls",
				UploadAndRedirect = true,
				MaximumUploadFiles = 10,
				DropOrUploadFileLabel = Resources["DropOrUploadFiles"]
			};
			if (model.RedirectToMainApp)
				return Redirect("/tasks/" + model.AppName.ToLower());
			return View(model);
		}

	}
}
