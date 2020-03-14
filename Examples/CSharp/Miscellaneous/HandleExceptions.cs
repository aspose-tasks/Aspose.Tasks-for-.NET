using System;

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    class HandleExceptions
    {
        public static void Run()
        {
            //ExStart:HandleExceptions
            Project project;
            try
            {
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                project = new Project(dataDir + "project.mpp");
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
