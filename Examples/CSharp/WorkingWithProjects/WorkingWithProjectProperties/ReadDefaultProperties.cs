namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class ReadDefaultProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:DefaultProperties
            //ExFor: Prj.DefaultStartTime
            //ExFor: Prj.DefaultTaskType
            //ExFor: Prj.DefaultStandardRate
            //ExFor: Prj.DefaultOvertimeRate
            //ExFor: Prj.DefaultTaskEVMethod
            //ExFor: Prj.DefaultFixedCostAccrual
            //ExSummary: Shows how to read project's default properties.
            // Create project
            var project = new Project(dataDir + "DefaultProperties.mpp");

            // Display default properties
            Console.WriteLine("New Task Default Start: " + project.Get(Prj.DefaultStartTime).ToShortDateString());
            Console.WriteLine("New Task Default Type: " + project.Get(Prj.DefaultTaskType));
            Console.WriteLine("Resource Default Standard Rate: " + project.Get(Prj.DefaultStandardRate));
            Console.WriteLine("Resource Default Overtime Rate: " + project.Get(Prj.DefaultOvertimeRate));
            Console.WriteLine("Default Task EV Method: " + project.Get(Prj.DefaultTaskEVMethod));
            Console.WriteLine("Default Cost Accrual: " + project.Get(Prj.DefaultFixedCostAccrual));
            //ExEnd:DefaultProperties
        }
    }
}