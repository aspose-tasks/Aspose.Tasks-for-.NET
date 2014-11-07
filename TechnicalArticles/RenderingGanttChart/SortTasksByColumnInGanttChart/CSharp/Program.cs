//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections.Generic;
using System;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

namespace SortTasksByColumnInGanttChartExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            
             class Program
    {
        static void Main(string[] args)
        {
            License lic = new License();
            lic.SetLicense(@"C:\Aspose.Total.Product.Family.lic");

            RenderGanttChartByColumn();

            Console.WriteLine("Done...");
            Console.ReadLine();
        }

        static void RenderGanttChartByColumn()
        {
            Project project = new Project("RenderMe.mpp"); // attached sample mpp
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;

            options.TasksComparer = new TasksNameComparer();

            project.Save("SortedByNames.pdf", options);

            options.TasksComparer = new TasksDurationComparer();
            project.Save("SortedByDurations.pdf", options);
        }
}
             public class TasksNameComparer : IComparer<Task>
    {
        public int Compare(Task x, Task y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public  class TasksDurationComparer : IComparer<Task>
    {
        public int Compare(Task x, Task y)
        {
            return x.Duration.CompareTo(y.Duration);
        }
    }

   
            
            
        }
    }
}