/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class ReadXMLFileWithMultipleProjects
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            {
                //ExStart:ReadXMLFileWithMultipleProjects
                //ExFor: PrimaveraXmlReadingOptions
                //ExFor: Project.#ctor(String,PrimaveraXmlReadingOptions)
                //ExSummary: Shows how to read a project from a Primavera XML file with multiple projects.
                var options = new PrimaveraXmlReadingOptions();
                options.ProjectUid = 4557;
                // Returns project with special Uid
                var project = new Project(dataDir + "Project.xml", options);
                Console.WriteLine(project.Get(Prj.Name));
                //ExEnd:ReadXMLFileWithMultipleProjects
            }
            
            {
                //ExStart:ReadXMLStreamWithMultipleProjects
                //ExFor: PrimaveraXmlReadingOptions
                //ExFor: Project.#ctor(Stream,PrimaveraXmlReadingOptions)
                //ExSummary: Shows how to read a project from a stream with Primavera XML file with multiple projects.
                var options = new PrimaveraXmlReadingOptions();
                options.ProjectUid = 4557;
                using (var stream = new FileStream(dataDir + "Project.xml", FileMode.Open, FileAccess.Read))
                {
                    // Returns project with special Uid
                    var project = new Project(stream, options);
                    Console.WriteLine(project.Get(Prj.Name));
                }
                //ExEnd:ReadXMLStreamWithMultipleProjects
            }
            
            {
                byte[] brokenXmlFileBytes = Encoding.UTF8.GetBytes(GetModifiedXml(dataDir));
                
                //ExStart:ReadBrokenPrimaveraXmlStreamWithMultipleProjects
                //ExFor: PrimaveraXmlReadingOptions
                //ExFor: Project.#ctor(Stream,ParseErrorCallback,PrimaveraXmlReadingOptions)
                //ExSummary: Shows how to read a project from a stream with Primavera XML file with multiple projects.
                var options = new PrimaveraXmlReadingOptions();
                options.ProjectUid = 4557;
                using (var stream = new MemoryStream(brokenXmlFileBytes))
                {
                    // Returns project with special Uid
                    var project = new Project(stream, CustomDurationHandlerForStream, options);
                    Console.WriteLine(project.Get(Prj.Name));
                }
                //ExEnd:ReadBrokenPrimaveraXmlStreamWithMultipleProjects
            }
            
            {
                var xml = GetModifiedXml(dataDir);
                File.WriteAllText(dataDir + "IgnoreInvalidCharacters_out.xml", xml);
                //ExStart:ReadBrokenPrimaveraXmlFileWithMultipleProjects
                //ExFor: PrimaveraXmlReadingOptions
                //ExFor: Project.#ctor(String,ParseErrorCallback,PrimaveraXmlReadingOptions)
                //ExSummary: Shows how to read a project from a stream with Primavera XML file with multiple projects.
                var options = new PrimaveraXmlReadingOptions();
                options.ProjectUid = 4557;
                
                // Returns project with special Uid
                var project = new Project(dataDir + "IgnoreInvalidCharacters_out.xml", CustomDurationHandlerForFile, options);
                Console.WriteLine(project.Get(Prj.Name));
                //ExEnd:ReadXMLFileWithMultipleProjects
            }
        }
        
        private static object CustomDurationHandlerForStream(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Debug.Print("Object field : {0}, Invalid value : {1}", args.FieldName, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var newValue = Duration.ParseTimeSpan(duration);
            Debug.Print("New value : {0}", newValue);
            return newValue;
        }
        
        private static object CustomDurationHandlerForFile(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Debug.Print("Object field : {0}, Invalid value : {1}", args.FieldName, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var newValue = Duration.ParseTimeSpan(duration);
            Debug.Print("New value : {0}", newValue);
            return newValue;
        }
        
        private static string GetModifiedXml(string dataDir)
        {
            // Open valid xml file and modify it
            using (TextReader reader = new StreamReader(dataDir + "Project.xml"))
            {
                var xml = reader.ReadToEnd();
                var regex = new Regex("PT(\\d+)H(\\d+)M(\\d+)S");
                return regex.Replace(xml, "**$1Hrs$2Mins$3Secs**");
            }
        }
    }
}