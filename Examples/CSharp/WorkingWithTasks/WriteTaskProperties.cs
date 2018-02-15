using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class WriteTaskProperties
    {
        public static void Run()
        {
            // ExStart:WriteTaskProperties
            // Create project instance
            Project project = new Project();
            
            // Add task and set task properties
            Task task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.Start, project.RootTask.Get(Tsk.Start).AddDays(1));
            task.Set(Tsk.Name, "new name");
            // ExEnd:WriteTaskProperties

            // Save project
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project.Save(dataDir + "WriteTaskProperties_out.pdf", SaveFileFormat.PDF); 
        }
    }
}
