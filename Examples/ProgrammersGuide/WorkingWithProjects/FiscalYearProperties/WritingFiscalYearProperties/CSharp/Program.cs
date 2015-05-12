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

namespace WritingFiscalYearPropertiesExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project instance
            Project prj = new Project(dataDir+ "project.mpp");
            //Set fiscal year properties
            prj.Set(Prj.FyStartDate, Month.July);
            prj.Set(Prj.FiscalYearStart, true);
            prj.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
        }
    }
}