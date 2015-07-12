//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace CSharp.Projects
{
    public class GetNumberOfPages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();



            //Read the input Project file
            Project project = new Project(dataDir+ "GetNumberOfPages.mpp");

            //Get number of pages
            int iPages = project.GetPageCount();

            //Get number of pages (Timescale.Months)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months);

            //Get number of pages (Timescale.ThirdsOfMonths)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths);


        }
    }
}