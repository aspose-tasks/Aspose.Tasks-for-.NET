using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspose.Tasks.Live.Demos.UI.Models
{
	///<Summary>
	/// License class to set apose products license
	///</Summary>
	public static class License
	{
		private static string _licenseFileName = "Aspose.Total.Product.Family.lic";

		///<Summary>
		/// SetAsposeTasksLicense method to Aspose.Tasks License
		///</Summary>
		public static void SetAsposeTasksLicense()
		{
			try
			{

				Aspose.Tasks.License lic = new Aspose.Tasks.License();
				lic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		///<Summary>
		/// SetAsposeCellsLicense method to Aspose.Cells License
		///</Summary>
		public static void SetAsposeCellsLicense()
		{
			try
			{

				Aspose.Cells.License lic = new Aspose.Cells.License();
				lic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
