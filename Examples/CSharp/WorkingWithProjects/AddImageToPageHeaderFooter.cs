using System;
using System.Drawing;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class AddImageToPageHeaderFooter
    {
        public static void Run()
        {
            try
            {
                // ExStart:AddImageToPageHeaderFooter
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                Project project = new Project(dataDir + "Project1.mpp");

                project.RootTask.Children.Add("Task1");
                PageInfo pageInfo = project.DefaultView.PageInfo;
                
                using (Image image = Image.FromFile(dataDir + "Image1.png"))
                {
                    pageInfo.Header.CenteredImage = image;
                    pageInfo.Legend.LeftImage = image;
                    pageInfo.Legend.LeftText = string.Empty;
                    MPPSaveOptions saveOptions = new MPPSaveOptions();
                    saveOptions.WriteViewData = true;                    
                    project.Save(dataDir + "ReadHeaderAndFooterInformationFromMPPFile1_out.mpp", saveOptions);
                }
                // ExEnd:AddImageToPageHeaderFooter
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}