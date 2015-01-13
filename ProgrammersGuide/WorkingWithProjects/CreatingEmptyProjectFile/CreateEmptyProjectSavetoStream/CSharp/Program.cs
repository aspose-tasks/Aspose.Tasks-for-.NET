//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace CreateEmptyProjectSavetoStreamExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //Create a project instance
            Project newProject = new Project();

            //Create a file stream
            FileStream projectStream = new FileStream(dataDir+ "Project1.xml", FileMode.Create, FileAccess.Write);

            //Write the stream into XML format
            newProject.Save(projectStream, Aspose.Tasks.Saving.SaveFileFormat.XML);

            projectStream.Close();

            
            
        }
    }
}