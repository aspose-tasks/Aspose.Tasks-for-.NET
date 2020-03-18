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

    internal class MoveTaskAtTheEnd
    {
        public static void Run()
        {   
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);   

                //ExStart:MoveTaskAtTheEnd
                // Loading project file
                var project = new Project(dataDir + "MoveTask.mpp");

                // Move tasks with id 2 to the end of the collection
                var task = project.RootTask.Children.GetById(2);             
                task.MoveToSibling(-1);

                // Saving File To Disk
                project.Save(dataDir + "MoveTaskAtTheEnd_out.mpp", SaveFileFormat.MPP);
                //ExEnd:MoveTaskAtTheEnd
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
