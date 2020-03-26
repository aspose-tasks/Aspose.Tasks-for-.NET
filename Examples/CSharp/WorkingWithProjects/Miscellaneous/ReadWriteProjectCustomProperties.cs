namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    internal class ReadWriteProjectCustomProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
#pragma warning disable 0618
            //ExStart:ReadWriteProjectCustomProperties
            //ExFor: Project.CustomProperties
            //ExSummary: Shows how to read/write project's custom properties.
            var project = new Project(dataDir + "Project2003.mpp");

            project.CustomProperties.Add("My_Server", "http://server.com");
            project.CustomProperties.Add("My_Boolean", true);
            project.CustomProperties.Add("My_ProjectID", 1);
            project.CustomProperties.Add("My_ProjectIDString", "1");
            project.CustomProperties.Add("My_DeliverableID", 2);
            project.CustomProperties.Add("My_ActivityID", 3);
            project.CustomProperties.Add("My_RelatedFileID", 4);
            project.CustomProperties.Add("My_GateDocumentID", 5);
            project.CustomProperties.Add("My_TemplateLibraryID", 6);

            Console.WriteLine(project.CustomProperties["My_Server"].ToString());
            //ExEnd:ReadWriteProjectCustomProperties
#pragma warning restore 0618
        }
    }
}