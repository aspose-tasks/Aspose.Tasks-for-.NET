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

    internal class MoveTaskUnderAnotherParent
    {
        public static void Run()
        {        
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);  

                //ExStart:MoveTaskUnderAnotherParent
                //ExFor: TaskCollection.Add(Task)
                //ExSummary: Shows how to move a task under another parent.
                // Loading project file
                var project = new Project(dataDir + "MoveTask.mpp")
                {
                    CalculationMode = CalculationMode.Automatic
                };

                // Get Tasks by Ids
                var task = project.RootTask.Children.GetByUid(6);
                var task2 = project.RootTask.Children.GetByUid(3);

                // Adding Task 6 to another parent
                task2.Children.Add(task);

                // Saving File To Disk
                project.Save(dataDir + "MoveTaskUnderAnotherParent_out.mpp", SaveFileFormat.MPP);
                //ExEnd:MoveTaskUnderAnotherParent
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");  
            }
        }
    }
}
