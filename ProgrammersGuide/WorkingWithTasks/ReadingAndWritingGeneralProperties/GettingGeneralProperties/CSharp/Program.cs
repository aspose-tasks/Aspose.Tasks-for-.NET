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

namespace GettingGeneralProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            ProjectReader rdr = new ProjectReader();
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();


            // Create a ChildTasksCollector instance
            ChildTasksCollector collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (Task tskCh in collector.Tasks)
            {
                //code to display task properties
                Console.WriteLine("Task Id: " + tskCh.Id);
                Console.WriteLine("Task Uid: " + tskCh.Uid);
                Console.WriteLine("Task Name: " + tskCh.Name);
                Console.WriteLine("Task Start: " + tskCh.Start);
                Console.WriteLine("Task Finish: " + tskCh.Finish);
            }

        }
    }
}