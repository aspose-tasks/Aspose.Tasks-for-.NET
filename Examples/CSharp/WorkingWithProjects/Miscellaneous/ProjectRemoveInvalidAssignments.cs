namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    public class ProjectRemoveInvalidAssignments
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ProjectRemoveInvalidAssignments
            //ExFor: Project.RemoveInvalidResourceAssignments
            //ExSummary: Shows how to remove invalid assignments.
            Project project = new Project(dataDir + "InvalidResourceAssignments.mpp");
            int invalid = 0;
            foreach (var ra in project.ResourceAssignments)
            {
                if (ra.Get(Asn.Resource) == null)
                {
                    invalid++;
                }
            }

            Console.WriteLine("Count of invalid assignments (before):" + invalid);
            
            // remove invalid assignments
            project.RemoveInvalidResourceAssignments();
            
            Console.WriteLine("Count of invalid assignments (after):" + invalid);
            //ExEnd:ProjectRemoveInvalidAssignments
        }
    }
}