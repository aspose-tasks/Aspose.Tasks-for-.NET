/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;
    using System.Drawing;
    using System.Reflection;
    using Saving;

    internal class AddImageToPageHeaderFooter
    {
        public static void Run()
        {
            try
            {
                var dataDir = RunExamples.GetDataDir(MethodBase.GetCurrentMethod());

                //ExStart:AddImageToPageHeaderFooter
                //ExFor: View.PageInfo
                //ExFor: PageInfo.Header
                //ExFor: PageInfo.Legend
                //ExFor: PageInfo.Footer
                //ExFor: PageLegend
                //ExFor: HeaderFooterInfo
                //ExSummary: Shows how to add image to page header/footer.
                var project = new Project(dataDir + "AddImageToPageHeaderFooter.mpp");

                project.RootTask.Children.Add("Task1");
                var info = project.DefaultView.PageInfo;

                using (var image = Image.FromFile(dataDir + "Image1.png"))
                {
                    info.Header.CenteredImage = image;
                    info.Legend.LeftImage = image;
                    info.Legend.LeftText = string.Empty;
                    var options = new MPPSaveOptions();
                    options.WriteViewData = true;
                    project.Save(dataDir + "AddImageToPageHeaderFooter_out.mpp", options);
                }
                //ExEnd:AddImageToPageHeaderFooter
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}