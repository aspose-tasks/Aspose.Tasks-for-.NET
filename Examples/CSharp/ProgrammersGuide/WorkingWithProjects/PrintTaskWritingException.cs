//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
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
    public class PrintTaskWritingException
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir+ "PrintTaskWritingException.mpp");

            try
            {
                project.Save("project.MPP", Aspose.Tasks.Saving.SaveFileFormat.MPP);
            }
            catch (TasksWritingException ex)
            {
                Console.WriteLine(ex.LogText);
            }

        }
    }
}