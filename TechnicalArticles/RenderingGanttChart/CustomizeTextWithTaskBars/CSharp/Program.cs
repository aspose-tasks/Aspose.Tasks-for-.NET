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
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System.Drawing;
using System.Collections.Generic;

namespace CustomizeTextWithTaskBarsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new Project();

            Task task1 = project.AddTask("Task 1");
            Task task2 = project.AddTask("Task 2");

            task1.Duration = task2.Duration = TimeSpan.FromDays(1);

            TaskLink link = new TaskLink(task1, task2, TaskLinkType.FinishToStart);
            project.AddTaskLink(link);

            Task task3 = project.AddTask("Task 3");

            Resource rsc1 = project.AddResource("Resource 1");
            Resource rsc2 = project.AddResource("Resource 2");
            Resource rsc3 = project.AddResource("Resource 3");

            project.AddResourceAssignment(task1, rsc1);
            project.AddResourceAssignment(task2, rsc2);
            project.AddResourceAssignment(task3, rsc3);

            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.ThirdsOfMonths;

            BarStyle style = new BarStyle();
            style.ItemType = BarItemType.CriticalTask;

            style.BarTextConverter = delegate(Task t)
            {
                return string.Format("task \"{0}\" is on critical path", t.Name);
            };

            BarStyle style2 = new BarStyle();
            style2.BarColor = Color.DarkOrchid;
            style2.ItemType = BarItemType.Task;

            options.BarStyles = new List<BarStyle>();
            options.BarStyles.Add(style);
            options.BarStyles.Add(style2);

            project.Save(dataDir+ "result2.pdf", options);
            
            
        }
    }
}