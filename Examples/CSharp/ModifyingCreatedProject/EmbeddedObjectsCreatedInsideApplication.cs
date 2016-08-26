using System;
using System.Collections.Generic;
using System.IO;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class EmbeddedObjectsCreatedInsideApplication
    {
        public static void Run()
        {
            // ExStart:EmbeddedObjectsCreatedInsideApplication
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();
                IDictionary<string, string> fileFormatExt = new Dictionary<string, string>();
                fileFormatExt.Add(dataDir + "Image1", ".png");
                fileFormatExt.Add(dataDir + "Document1", ".docx");
                fileFormatExt.Add(dataDir + "Documennt1", ".xlsx");
                Project project = new Project(dataDir + "Project1.mpp"); // see this test project attached to this issue
                foreach (OleObject oleObject in project.OleObjects)
                {
                    if (!string.IsNullOrEmpty(oleObject.FileFormat) && fileFormatExt.ContainsKey(oleObject.FileFormat))
                    {
                        string path = dataDir + "EmbeddedContent_out" + fileFormatExt[oleObject.FileFormat];
                        using (FileStream fileStream = new FileStream(path, FileMode.Create))
                            fileStream.Write(oleObject.Content, 0, oleObject.Content.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:EmbeddedObjectsCreatedInsideApplication
        }
    }
}