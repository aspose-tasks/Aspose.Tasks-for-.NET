using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    class AddNewTask
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:AddNewTask            
            Project project = new Project(dataDir + "Project1.mpp");

            Task task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.ActualStart, DateTime.Parse("23-Aug-2012"));

            // Set duration in hours
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour));
            task.Set(Tsk.DurationFormat, TimeUnitType.Day);
            project.RootTask.Children.Add(task);
            
            // Save the Project as XML
            project.Save(dataDir + "AddNewTask_out.xml", SaveFileFormat.XML);
            // ExEnd:AddNewTask        
        }
    }
}
