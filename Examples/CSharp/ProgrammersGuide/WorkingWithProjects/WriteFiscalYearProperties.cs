//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace CSharp.Projects
{
    public class WriteFiscalYearProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Create a project instance
            Project prj = new Project(dataDir+ "WriteFiscalYearProperties.mpp");
            //Set fiscal year properties
            prj.Set(Prj.FyStartDate, Month.July);
            prj.Set(Prj.FiscalYearStart, true);
            prj.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
        }
    }
}