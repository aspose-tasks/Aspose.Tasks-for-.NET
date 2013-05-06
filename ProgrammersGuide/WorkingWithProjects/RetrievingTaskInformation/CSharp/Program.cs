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

namespace RetrievingTaskInformation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create a project reader instance
            ProjectReader reader = new ProjectReader();

            // Read the project file
            Project project = reader.Read(dataDir + "Project.mpp");

            // Create a ChildTasksCollector instance
            ChildTasksCollector collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils 
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (Task task in collector.Tasks)
            {
                Console.WriteLine("Task Name : " + task.Name);
                Console.WriteLine("Start : " + task.Start.ToShortDateString());
                Console.WriteLine("Finish : " + task.Finish.ToShortDateString());
            }
            
        }
    }
}