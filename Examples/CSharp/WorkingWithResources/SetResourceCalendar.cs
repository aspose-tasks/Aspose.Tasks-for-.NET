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

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class SetResourceCalendar
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:SetResourceCalendar
            // Create project instance and add resource
            Project project = new Project();
            Resource res = project.Resources.Add("Resource1");

            // Add standard calendar and assign to resource
            Aspose.Tasks.Calendar cal = project.Calendars.Add("Resource1");
            res.Set(Rsc.Calendar, cal);
            // ExEnd:SetResourceCalendar

            // Save project as XML
            project.Save(dataDir + "SetResourceCalendar_out.xml", SaveFileFormat.XML);
        }
    }
}
