namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class ReadProjectInfo
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadProjectInfo
            //ExFor: Prj.Author
            //ExFor: Prj.LastAuthor
            //ExFor: Prj.Revision
            //ExFor: Prj.Keywords
            //ExFor: Prj.Comments
            //ExSummary: Shows how to read meta project properties.
            // Open the project
            var project = new Project(dataDir + "ReadProjectInfo.mpp");

            // Display project information
            if (project.Get(Prj.ScheduleFromStart))
            {
                Console.WriteLine("Project Finish Date : " + project.Get(Prj.StartDate).ToShortDateString());
            }
            else
            {
                Console.WriteLine("Project Finish Date : " + project.Get(Prj.FinishDate).ToShortDateString());
            }
            
            Console.WriteLine(project.Get(Prj.Author));
            Console.WriteLine(project.Get(Prj.LastAuthor));
            Console.WriteLine(project.Get(Prj.Revision));
            Console.WriteLine(project.Get(Prj.Keywords));
            Console.WriteLine(project.Get(Prj.Comments));
            Console.WriteLine("The program has run successfully");
            //ExEnd:ReadProjectInfo
        }
    }
}