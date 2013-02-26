//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace CreatingEmptyProjectFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // 1.
            // Create an Empty Project Using File Stream

            //Create a project instance
            Project newProject = new Project();

            //Create a file stream
            FileStream projectStream = new FileStream(dataDir + "Project1.xml", FileMode.Create, FileAccess.Write);

            //Write the stream into XML format
            newProject.Save(projectStream, Aspose.Tasks.Saving.SaveFileFormat.XML);
            
            // Close the stream.
            projectStream.Close();

            // Display Status.
            System.Console.WriteLine("New project created and saved successfully using FileStream.");

            
            // 2.
            // Create an Empty Project using ProjectWriter
            
            //Create a project instance
            Project newProject1 = new Project();

            //Write Project data to XML file
            newProject1.Save(dataDir + "Project2.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

            // Display Status.
            System.Console.WriteLine("New project created and saved successfully using ProjectWriter.");
        }
    }
}