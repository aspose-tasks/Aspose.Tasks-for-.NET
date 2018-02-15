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

namespace Aspose.Tasks.Examples.CSharp.Licensing
{
    class EvaluationDateTimeLimitations
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:DateTimeLimitations
            // Create a prject instance
            Project project1 = new Project();

            // Define Tasks
            Task task1 = project1.RootTask.Children.Add("Task1");
            task1.Set(Tsk.ActualStart, DateTime.Parse("06-Apr-2010"));

            Task task2 = project1.RootTask.Children.Add("Task2");
            task2.Set(Tsk.ActualStart, DateTime.Parse("10-Apr-2010"));

            // Save the Project as XML
            project1.Save("EvalProject_out.xml", SaveFileFormat.XML);
            // ExEnd:DateTimeLimitations
        }
    }
}
