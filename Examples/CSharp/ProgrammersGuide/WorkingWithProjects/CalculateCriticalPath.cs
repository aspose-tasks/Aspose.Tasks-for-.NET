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
    public class CalculateCriticalPath
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir+ "CalculateCriticalPath.mpp");
            project.CalculationMode = CalculationMode.Automatic;

            Task subtask1 = project.RootTask.Children.Add("1");
            Task subtask2 = project.RootTask.Children.Add("2");
            Task subtask3 = project.RootTask.Children.Add("3");

            project.TaskLinks.Add(subtask1, subtask2, TaskLinkType.FinishToStart);

            //Display the critical path now
            foreach (Task task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Name));
            }
        }
    }
}