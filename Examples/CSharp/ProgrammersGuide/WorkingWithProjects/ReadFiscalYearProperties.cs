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
    public class ReadFiscalYearProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            //Create a project reader instance
            Project project = new Project(dataDir+ "ReadFiscalYearProperties.mpp");

            //Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date : " + project.Get(Prj.FyStartDate).ToString());
            Console.WriteLine("Fiscal Year Numbering : " + project.Get(Prj.FiscalYearStart).ToString());
            
        }
    }
}