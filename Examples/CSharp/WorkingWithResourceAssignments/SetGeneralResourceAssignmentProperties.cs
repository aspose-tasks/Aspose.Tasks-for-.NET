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

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class SetGeneralResourceAssignmentProperties
    {
        public static void Run()
        {
            // ExStart:SetGeneralResourceAssignmentProperties
            // Create empty project
            Project project1 = new Project();

            // Add new task and resource
            Task task1 = project1.RootTask.Children.Add("Task");
            Resource rsc1 = project1.Resources.Add("Rsc");
            rsc1.Set(Rsc.StandardRate, 10);
            rsc1.Set(Rsc.OvertimeRate, 15);

            // Assign the resource desired task
            ResourceAssignment assn = project1.ResourceAssignments.Add(task1, rsc1);
            // ExEnd:SetGeneralResourceAssignmentProperties

            // Save project as PDF
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project1.Save(dataDir + "SetGeneralResourceAssignmentProperties_out.pdf", SaveFileFormat.PDF);
        }
    }
}
