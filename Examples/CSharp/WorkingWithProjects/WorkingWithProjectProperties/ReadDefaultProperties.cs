using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    public class ReadDefaultProperties
    {
        public static void Run()
        {
            // ExStart:DefaultProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
            
            // Create project
            Project project = new Project(dataDir + "DefaultProperties.mpp");

            // Display default properties
            Console.WriteLine("New Task Default Start: " + project.Get(Prj.DefaultStartTime).ToShortDateString());
            Console.WriteLine("New Task Default Type: " + project.Get(Prj.DefaultTaskType));
            Console.WriteLine("Resouce Default Standard Rate: " + project.Get(Prj.DefaultStandardRate).ToString());
            Console.WriteLine("Resource Default Overtime Rate: " + project.Get(Prj.DefaultOvertimeRate).ToString());
            Console.WriteLine("Default Task EV Method: " + project.Get(Prj.DefaultTaskEVMethod).ToString());
            Console.WriteLine("Default Cost Accrual: " + project.Get(Prj.DefaultFixedCostAccrual).ToString());
            // ExEnd:DefaultProperties
        }
    }
}