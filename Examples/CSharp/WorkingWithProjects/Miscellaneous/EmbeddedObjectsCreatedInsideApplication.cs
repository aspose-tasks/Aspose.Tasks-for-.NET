/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class EmbeddedObjectsCreatedInsideApplication
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:EmbeddedObjectsCreatedInsideApplication
                //ExFor: Project.OleObjects
                //ExSummary: Shows how to extract an embedded OLE objects.
                IDictionary<string, string> formatExt = new Dictionary<string, string>();
                formatExt.Add("RTF", "_rtfFile_out.rtf");
                formatExt.Add("MSWordDoc", "_wordFile_out.docx");
                formatExt.Add("ExcelML12", "_excelFile_out.xlsx");

                var project = new Project(dataDir + "Embedded.mpp"); 

                foreach (var oleObject in project.OleObjects)
                {
                    if (string.IsNullOrEmpty(oleObject.FileFormat) || !formatExt.ContainsKey(oleObject.FileFormat))
                    {
                        continue;
                    }

                    var path = dataDir + "EmbeddedContent_" + formatExt[oleObject.FileFormat];
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        stream.Write(oleObject.Content, 0, oleObject.Content.Length);
                    }
                }
                //ExEnd:EmbeddedObjectsCreatedInsideApplication
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}