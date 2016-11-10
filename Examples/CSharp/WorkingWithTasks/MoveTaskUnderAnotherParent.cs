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
    class MoveTaskUnderAnotherParent
    {
        public static void Run()
        {        
            try
            {
                // ExStart:MoveTaskUnderAnotherParent
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);  

                // Loading project file
                Project project = new Project(dataDir + "MoveTask.mpp");

                // Set CalculationMode
                project.CalculationMode = CalculationMode.Automatic;
              
                // Get Tasks by Ids
                Task t6 = project.RootTask.Children.GetByUid(6);
                Task t3 = project.RootTask.Children.GetByUid(3);

                // Adding Task 6 to another parent
                t3.Children.Add(t6);

                // Saving File To Disk
                project.Save(dataDir + "MoveTaskUnderAnotherParent_out.mpp", SaveFileFormat.MPP);
                // ExEnd:MoveTaskUnderAnotherParent
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");  
            }
        }
    }
}
