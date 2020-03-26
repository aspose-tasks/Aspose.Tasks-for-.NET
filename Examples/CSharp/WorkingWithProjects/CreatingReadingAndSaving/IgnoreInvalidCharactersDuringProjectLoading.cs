/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class IgnoreInvalidCharactersDuringProjectLoading
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            LoadProjectFromStream(GetModifiedXml(dataDir));
            var xml = GetModifiedXml(dataDir);
            File.WriteAllText(dataDir + "IgnoreInvalidCharacters_out.xml", xml);
            LoadProjectFromFile(dataDir + "IgnoreInvalidCharacters_out.xml");
        }

        //ExStart:IgnoreInvalidCharactersDuringLoadingProjectFromStream
        //ExFor: Project.#ctor(String, ParseErrorCallback)
        //ExSummary: Shows how to read a project from a stream with XML file with invalid characters.
        private static void LoadProjectFromFile(string pathToModifiedXml)
        {
            // open the file which contains XML with broken timespans
            var project = new Project(pathToModifiedXml, CustomDurationHandlerForFile);
            Console.WriteLine(project.Get(Prj.Name));
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
        //ExEnd:IgnoreInvalidCharactersDuringLoadingProjectFromFile

        //ExStart:IgnoreInvalidCharactersDuringLoadingProjectFromStream
        //ExFor: Project.#ctor(Stream, ParseErrorCallback)
        //ExSummary: Shows how to read a project from XML file with invalid characters.
        private static void LoadProjectFromStream(string brokenXmlData)
        {
            // open the stream which contains XML with broken timespans
            byte[] bytes = Encoding.UTF8.GetBytes(brokenXmlData);
            using (var stream = new MemoryStream(bytes))
            {
                var project = new Project(stream, CustomDurationHandlerForStream);
                Console.WriteLine(project.Get(Prj.Name));
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
        //ExEnd:IgnoreInvalidCharactersDuringLoadingProjectFromStream
        
        private static string GetModifiedXml(string dataDir)
        {
            // Open valid xml file and modify it
            using (TextReader reader = new StreamReader(dataDir + "IgnoreInvalidCharacters.xml"))
            {
                var xml = reader.ReadToEnd();
                var regex = new Regex("PT(\\d+)H(\\d+)M(\\d+)S");
                return regex.Replace(xml, "**$1Hrs$2Mins$3Secs**");
            }
        }
    }
}