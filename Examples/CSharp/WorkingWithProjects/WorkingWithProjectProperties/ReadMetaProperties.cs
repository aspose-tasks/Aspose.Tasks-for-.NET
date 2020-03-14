using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    class ReadMetaProperties
    {
        public static void Run()
        {
            //ExStart:ReadMetaProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project reader instance
            Project project = new Project(dataDir + "ReadProjectInfo.mpp");

            // custom properties are available through the typed collection
            foreach (var property in project.CustomProps)
            {
                Console.WriteLine(property.Type);
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }

            // built-in properties are available directly
            Console.WriteLine(project.BuiltInProps.Author);
            Console.WriteLine(project.BuiltInProps.Title);


            // or as an item of built-in property collection
            foreach (var property in project.BuiltInProps)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }
            //ExEnd:ReadMetaProperties
            Console.WriteLine("The program has run successfully");
        }
    }
}
