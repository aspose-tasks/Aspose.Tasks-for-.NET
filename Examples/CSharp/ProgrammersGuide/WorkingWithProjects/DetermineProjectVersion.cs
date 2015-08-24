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

namespace CSharp.Projects
{
    public class DetermineProjectVersion
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project(dataDir+ "DetermineProjectVersion.mpp");
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion).ToString());
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());
        }
    }
}