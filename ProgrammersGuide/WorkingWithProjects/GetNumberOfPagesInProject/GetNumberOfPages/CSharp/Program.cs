//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace GetNumberOfPagesExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");



            //Read the input Project file
            Project project = new Project(dataDir+ "project.mpp");

            //Get number of pages
            int iPages = project.GetPageCount();

            //Get number of pages (Timescale.Months)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months);

            //Get number of pages (Timescale.ThirdsOfMonths)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths);


        }
    }
}