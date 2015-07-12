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
using Aspose.Tasks.Visualization;

namespace CSharp.Projects
{
    public class GetNumberOfPagesForViews
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Read the source Project
            Project project = new Project(dataDir+ "GetNumberOfPagesForViews.mpp");


            //Get number of pages
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days)));

            //Get number of pages (Months)
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months)));

            //Get number of pages (ThirdsOfMonths)
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths)));
        }
    }
}