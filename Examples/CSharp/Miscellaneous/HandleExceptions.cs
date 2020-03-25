namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System;

    using Saving;

    internal class HandleExceptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:HandleExceptions
            //ExFor: Project.#ctor(String)
            //ExSummary: Shows how to handle exceptions or project' reading/writing.
            try
            {
                var project = new Project(dataDir + "project.mpp");
                project.Save(dataDir + "HandleExceptions.mpp", SaveFileFormat.MPP);
            }
            catch (TasksReadingException ex)
            {
                Console.WriteLine("Message:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Log:");
                Console.WriteLine(ex.LogText);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception message:");
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:HandleExceptions
        }
    }
}
