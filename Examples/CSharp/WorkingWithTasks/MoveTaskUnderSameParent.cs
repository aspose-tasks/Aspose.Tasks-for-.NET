/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    using Aspose.Tasks.Saving;

    internal class MoveTaskUnderSameParent
    {
        public static void Run()
        {        
            try
            {
                //ExStart:MoveTaskUnderSameParent
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);        
             
                // Loading project file
                var project = new Project(dataDir + "MoveTask.mpp");

                // Move tasks with id 5 before task with id 3
                var task = project.RootTask.Children.GetById(5);                
                task.MoveToSibling(3);

                // Saving File To Disk
                project.Save(dataDir + "MoveTaskUnderSameParent_out.mpp", SaveFileFormat.MPP);
                //ExEnd:MoveTaskUnderSameParent
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
