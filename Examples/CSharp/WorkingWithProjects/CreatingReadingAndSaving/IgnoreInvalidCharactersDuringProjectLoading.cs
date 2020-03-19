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
        //ExStart:IgnoreInvalidCharactersDuringLoadingProject 
        public static void Run()
        {         
            // Open modified xml stream
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(GetModifiedXml())))
            {
                var project = new Project(stream, CustomDurationHandler);
                Console.WriteLine(project.Get(Prj.Name));
            }
        }

        private static string GetModifiedXml()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName); 
            string xml;

            // Open valid xml file and modify it
            using (TextReader reader = new StreamReader(dataDir + "IgnoreInvalidCharacters.xml"))
            {
                xml = reader.ReadToEnd();
            }

            var regex = new Regex("PT(\\d+)H(\\d+)M(\\d+)S");
            return regex.Replace(xml, "**$1Hrs$2Mins$3Secs**");
        }

        private static object CustomDurationHandler(object sender, ParseErrorArgs args)
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

            // Here we handle only TimeSpan instances, so rethrow original exception with other types
        }
        //ExEnd:IgnoreInvalidCharactersDuringLoadingProject
    }
}