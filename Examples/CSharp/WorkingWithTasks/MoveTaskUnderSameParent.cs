using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class MoveTaskUnderSameParent
    {
        public static void Run()
        {        
            try
            {
                // ExStart:MoveTaskUnderSameParent
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);        
             
                // Loading project file
                Project project = new Project(dataDir + "MoveTask.mpp");

                // Move tasks with id 5 before task with id 3
                Task task = project.RootTask.Children.GetById(5);                
                task.MoveToSibling(3);

                // Saving File To Disk
                project.Save(dataDir + "MoveTaskUnderSameParent_out.mpp", SaveFileFormat.MPP);
                // ExEnd:MoveTaskUnderSameParent
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
