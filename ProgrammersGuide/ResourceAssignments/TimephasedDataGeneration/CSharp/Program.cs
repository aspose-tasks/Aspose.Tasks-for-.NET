//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;

namespace TimephasedDataGeneration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Define a Project Reader Object
            ProjectReader reader = new ProjectReader();

            //Read the source MPP file
            Project project = reader.Read(dataDir + "project.mpp");

            //Get the first task of the Project
            Task task = project.GetTaskById(1);

            //Get the First Resource Assignment of the Project
            ResourceAssignment RA = (ResourceAssignment)project.ResourceAssignments[0];

            // Flat contour is default contour
            Console.WriteLine("Flat contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            RA.WorkContour = WorkContourType.Turtle;
            Console.WriteLine("Turtle contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            RA.WorkContour = WorkContourType.BackLoaded;
            Console.WriteLine("BackLoaded contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            RA.WorkContour = WorkContourType.FrontLoaded;
            Console.WriteLine("FrontLoaded contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            RA.WorkContour = WorkContourType.Bell;
            Console.WriteLine("Bell contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            RA.WorkContour = WorkContourType.EarlyPeak;
            Console.WriteLine("EarlyPeak contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            RA.WorkContour = WorkContourType.LatePeak;
            Console.WriteLine("LatePeak contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            // Change contour
            RA.WorkContour = WorkContourType.DoublePeak;
            Console.WriteLine("DoublePeak contour");
            foreach (TimephasedData td in task.TimeScaleData(project.StartDate, project.FinishDate))
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

        }
    }
}