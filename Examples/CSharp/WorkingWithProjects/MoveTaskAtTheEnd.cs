using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    class MoveTaskAtTheEnd
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithProjects();        

            try
            {
                // loading project file
                Project project = new Project(dataDir + "MoveTask.mpp");

                Task task = project.RootTask.Children.GetById(2);
                // move tasks with id == 2 to the end of the collection
                task.MoveToSibling(-1);

                // Saving File To Disk
                project.Save(dataDir + "MoveTaskAtTheEnd_out.mpp", SaveFileFormat.MPP);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            }
        }
    }
}
