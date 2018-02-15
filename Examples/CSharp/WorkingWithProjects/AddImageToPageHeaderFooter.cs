using System;
using System.Drawing;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class AddImageToPageHeaderFooter
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:AddImageToPageHeaderFooter
                Project project = new Project(dataDir + "AddImageToPageHeaderFooter.mpp");

                project.RootTask.Children.Add("Task1");
                PageInfo pageInfo = project.DefaultView.PageInfo;
                
                using (Image image = Image.FromFile(dataDir + "Image1.png"))
                {
                    pageInfo.Header.CenteredImage = image;
                    pageInfo.Legend.LeftImage = image;
                    pageInfo.Legend.LeftText = string.Empty;
                    MPPSaveOptions saveOptions = new MPPSaveOptions();
                    saveOptions.WriteViewData = true;
                    project.Save(dataDir + "AddImageToPageHeaderFooter_out.mpp", saveOptions);
                }
                // ExEnd:AddImageToPageHeaderFooter
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}