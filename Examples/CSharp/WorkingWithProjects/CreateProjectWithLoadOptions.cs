namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;
    using System.IO;
    using System.Reflection;

    internal class CreateProjectWithLoadOptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(MethodBase.GetCurrentMethod());

            {
                //ExStart:CreateProjectFromStreamWithLoadOptions
                //ExFor: Project.#ctor(Stream,LoadOptions)
                //ExSummary: Shows how to load the project from a stream by using <see cref="Aspose.Tasks.LoadOptions"/> instance.
                using (var stream = new FileStream(dataDir + "PasswordProtectedProject.mpp", FileMode.Open))
                {
                    var options = new LoadOptions();
                    options.Password = "password";
                    var project = new Project(stream, options);
                    Console.WriteLine(project.Get(Prj.Name));
                }
                //ExEnd:CreateProjectFromStreamWithLoadOptions
            }
            
            {
                //ExStart:CreateProjectFromFileWithLoadOptions
                //ExFor: Project.#ctor(String,LoadOptions)
                //ExSummary: Shows how to load the project from a file by using <see cref="Aspose.Tasks.LoadOptions"/> instance.
                var options = new LoadOptions();
                options.Password = "password";
                var project = new Project(dataDir + "PasswordProtectedProject.mpp", options);
                Console.WriteLine(project.Get(Prj.Name));
                //ExEnd:CreateProjectFromFileWithLoadOptions
            }
        }
    }
}