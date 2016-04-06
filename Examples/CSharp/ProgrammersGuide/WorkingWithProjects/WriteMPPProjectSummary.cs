//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;
using Aspose.Tasks.Saving;

namespace CSharp.Projects
{
    public class WriteMPPProjectSummary
    {
        public static void Run()
        {
            //ExStart: WriteMPPProjectSummary
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Instantiate ProjectReader class
            Project project = new Project(dataDir+ "WriteMPPProjectSummary.mpp");
            project.Set(Prj.Author, "Author");
            project.Set(Prj.LastAuthor, "Last Author");
            project.Set(Prj.Revision, 15);
            project.Set(Prj.Keywords, "MSP Aspose");
            project.Set(Prj.Comments, "Comments");

            project.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
            //ExEnd: WriteMPPProjectSummary
        }
    }
}