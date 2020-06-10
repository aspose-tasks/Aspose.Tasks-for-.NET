using Aspose.Tasks;
using Aspose.Tasks.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aspose.Tasks.Live.Demos.UI.Models;
using System.Reflection;

namespace Aspose.Tasks.Live.Demos.UI.Controllers
{
	/// <summary>
	/// AsposeTasksMetadataController class
	/// </summary>
	public class AsposeTasksMetadataController : TasksBase
	{
		///<Summary>
		/// Properties method to get metadata
		///</Summary>
		///
		[HttpPost]
		public HttpResponseMessage Properties(string folderName, string fileName)
		{


			try
			{

				Project project = new Project(Path.Combine(Config.Configuration.WorkingDirectory, folderName, fileName));
				return Request.CreateResponse(HttpStatusCode.OK, new PropertiesResponse(project));
			}
			catch (Exception e)
			{

				return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
			}
		}

		///<Summary>
		/// Properties method. Should include 'FileName', 'id', 'properties' as params
		///</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public Response Download()
		{
			Aspose.Tasks.Live.Demos.UI.Models.License.SetAsposeTasksLicense();
			Opts.AppName = "MetadataApp";
			Opts.MethodName = "Download";
			try
			{
				var request = Request.Content.ReadAsAsync<JObject>().Result;
				Opts.FileName = Convert.ToString(request["FileName"]);
				Opts.ResultFileName = Opts.FileName;
				Opts.FolderName = Convert.ToString(request["id"]);
				Project project = new Project(Opts.WorkingFileName);

				var pars = request["properties"]["BuiltIn"].ToObject<List<DocProperty>>();
				SetBuiltInProperties(project, pars);
				pars = request["properties"]["Custom"].ToObject<List<DocProperty>>();
				SetCustomProperties(project, pars);

				return Process((inFilePath, outPath, zipOutFolder) => { project.Save(outPath, Aspose.Tasks.Saving.SaveFileFormat.MPP); });
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new Response
				{
					Status = "500 " + ex.Message,
					StatusCode = 500
				};
			}
		}

		//<Summary>
		// Properties method.Should include 'FileName', 'id' as params
		//</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public Response Clear()
		{
			Opts.AppName = "MetadataApp";
			Opts.MethodName = "Clear";
			try
			{
				var request = Request.Content.ReadAsAsync<JObject>().Result;
				Opts.FileName = Convert.ToString(request["FileName"]);
				Opts.ResultFileName = Opts.FileName;
				Opts.FolderName = Convert.ToString(request["id"]);

				Project project = new Project(Opts.WorkingFileName);
				project.CustomProps.Clear();
				

				return Process((inFilePath, outPath, zipOutFolder) => { project.Save(outPath, Aspose.Tasks.Saving.SaveFileFormat.MPP); });
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new Response
				{
					Status = "500 " + ex.Message,
					StatusCode = 500
				};
			}
		}

		/// <summary>
		/// SetBuiltInProperties
		/// </summary>
		/// <param name="workbook"></param>
		/// <param name="pars"></param>
		private void SetBuiltInProperties(Project project, List<DocProperty> pars)
		{
			var builtin = project.BuiltInProps;
			var t = builtin.GetType();
			foreach (var par in pars)
			{
				var prop = t.GetProperty(par.Name);
				if (prop != null)
					switch (par.Type)
					{
						case PropertyType.String:
							prop.SetValue(builtin, Convert.ToString(par.Value));
							break;
						case PropertyType.Boolean:
							prop.SetValue(builtin, Convert.ToBoolean(par.Value));
							break;
						case PropertyType.Number:
							prop.SetValue(builtin, Convert.ToInt32(par.Value));
							break;
						case PropertyType.DateTime:
							prop.SetValue(builtin, Convert.ToDateTime(par.Value));
							break;
						case PropertyType.Double:
							prop.SetValue(builtin, Convert.ToDouble(par.Value));
							break;
					}
			}
		}


		/// <summary>
		/// SetCustomProperties
		/// </summary>
		/// <param name="workbook"></param>
		/// <param name="pars"></param>
		private void SetCustomProperties(Project project, List<DocProperty> pars)
		{
			var custom = project.CustomProps;
			custom.Clear();
			foreach (var par in pars)
				switch (par.Type)
				{
					case PropertyType.String:
						custom.Add(par.Name, Convert.ToString(par.Value));
						break;
					case PropertyType.Boolean:
						custom.Add(par.Name, Convert.ToBoolean(par.Value));
						break;
					case PropertyType.Number:
						custom.Add(par.Name, Convert.ToInt32(par.Value));
						break;
					case PropertyType.DateTime:
						custom.Add(par.Name, Convert.ToDateTime(par.Value));
						break;
					case PropertyType.Double:
						custom.Add(par.Name, Convert.ToDouble(par.Value));
						break;
				}
		}

		/// <summary>
		/// PropertiesResponse
		/// </summary>
		private class PropertiesResponse
		{
			//public BuiltInProjectPropertyCollection BuiltIn { get; set; }
			//public CustomProjectPropertyCollection Custom { get; set; }

			public List<DocProperty> BuiltIn { get; set; }
			public List<DocProperty> Custom { get; set; }


			public PropertiesResponse(Project project)
			{
				BuiltIn = new List<DocProperty>();
				Custom = new List<DocProperty>();

				foreach (var obj in project.BuiltInProps)
				{
					DocProperty metadataObject = new DocProperty
					{
						
						Name = obj.Name,
						Value = obj.Value,
						Type = PropertyType.String
					};
					BuiltIn.Add(metadataObject);
				}


				foreach (var obj in project.CustomProps)
				{
					string value = obj.Type.ToString();
					PropertyType propertyType = PropertyType.None;

					switch (value.ToLower())
					{
						case "string":
							propertyType = PropertyType.String;
							break;
						case "datetime":
							propertyType = PropertyType.DateTime;
							break;
						case "number":
							propertyType = PropertyType.Number;
							break;
						case "boolean":
							propertyType = PropertyType.Boolean;
							break;
					}

					DocProperty metadataObject = new DocProperty
					{

						Name = obj.Name,
						Value = obj.Value,
						Type = propertyType
					};
					Custom.Add(metadataObject);
				}

			}
		}
		
		/// <summary>
		/// The same fields as in DocumentProperty
		/// </summary>
		private class DocProperty
		{
			public string Name { get; set; }
			public object Value { get; set; }
			public PropertyType Type { get; set; }
		}

		public enum PropertyType
		{
			/// <summary>The property is a None value.</summary>
			None,
			/// <summary>The property is a String value.</summary>
			String,
			/// <summary>The property is a Date Time Value.</summary>
			DateTime,
			/// <summary>The property is an integer number.</summary>
			Number,
			/// <summary>The property is a Boolean.</summary>
			Boolean,
			/// <summary>The property is a Double.</summary>
			Double,
		}
		}

}
