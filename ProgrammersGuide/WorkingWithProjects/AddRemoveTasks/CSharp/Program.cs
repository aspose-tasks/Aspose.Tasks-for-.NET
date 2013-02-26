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

namespace AddRemoveTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Remove a task
            if (prj.RootTask.Children.Count > 1)
                prj.RootTask.Children.RemoveAt(0);

            //Add a task
            Task tskADD = new Task("Added");
            tskADD.Start = new System.DateTime(2009, 8, 1);
            tskADD.Finish = new DateTime(2009, 8, 5);
            prj.RootTask.Children.Add(tskADD);

            //Display task
            // Create a ChildTasksCollector instance
            ChildTasksCollector collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (Task tsk in collector.Tasks)
            {
                System.Console.WriteLine("Task Name" + tsk.Name);
                System.Console.WriteLine("Start" + tsk.Start.ToShortDateString());
                System.Console.WriteLine("Finish" + tsk.Finish.ToShortDateString());
            }

            // Display Status.
            System.Console.WriteLine("Processing completed successfully.");
        }
    }
}