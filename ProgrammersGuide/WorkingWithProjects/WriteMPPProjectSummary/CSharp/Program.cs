//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;
using Aspose.Tasks.Saving;

namespace WriteMPPProjectSummary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate ProjectReader class
            ProjectReader reader = new ProjectReader();

            //Load an existing MPP file
            Project project = reader.Read(dataDir + "project.mpp");

            //Set some summary information about the project
            project.Author = "Muhammad Sabir";
            project.LastAuthor = "Sergey Polshkov";
            project.Revision = 15;
            project.CreationDate = new DateTime(2010, 4, 15);
            project.LastSaved = new DateTime(2010, 4, 15);
            project.Keywords = "MPP Aspose";
            project.LastPrinted = new DateTime(2010, 4, 16);
            project.Subject = "Aspose Subject";
            project.Template = "Aspose Template";
            project.Comments = "Aspose Comments";

            //Save the Project back in MPP format
            project.Save(dataDir + "MPPAspose.xml", SaveFileFormat.XML);
        }
    }
}