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

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class UpdateResourceAssignmentInMPP
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:UpdateResourceAssignmentInMPP
                // Create project instance and access first task and resource
                Project project1 = new Project(dataDir + "UpdateResourceAssignment.mpp");
                Task task = project1.RootTask.Children.GetById(1);
                Resource rsc = project1.Resources.GetById(1);

                // Create resource assignment
                ResourceAssignment assn = project1.ResourceAssignments.Add(task, rsc);
                assn.Set(Asn.Notes, "Newly added assignment");

                // Save project as MPP
                project1.Save(dataDir + "UpdateResourceAssignment_out.mpp", SaveFileFormat.MPP);
                // ExEnd:UpdateResourceAssignmentInMPP
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
