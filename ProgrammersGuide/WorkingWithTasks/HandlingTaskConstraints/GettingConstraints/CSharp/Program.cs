//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Util;
using System;

namespace GettingConstraints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            ProjectReader rdr = new ProjectReader();
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            // Create a ChildTasksCollector instance
            ChildTasksCollector collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (Task tsk in collector.Tasks)
            {
                if (tsk.ConstraintDate.ToShortDateString() == "1/1/2000")
                    Console.WriteLine("NA");
                else
                    Console.WriteLine(tsk.ConstraintDate.ToShortDateString());
                Console.WriteLine(tsk.ConstraintType.ToString());

            }

        }
    }
}