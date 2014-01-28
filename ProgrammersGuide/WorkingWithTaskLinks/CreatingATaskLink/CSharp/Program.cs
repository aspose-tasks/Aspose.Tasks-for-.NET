//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;

namespace CreatingATaskLink
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

            Project project = new Project();
            project.MinutesPerDay = 60 * 8;

            //Set project Start and Finish Date
            project.StartDate = new DateTime(2012, 07, 16);
            project.FinishDate = new DateTime(2012, 07, 20);

            //Add root task
            Task root = new Task();
            project.RootTask = root;


            Task tsk1 = new Task("Task1");
            Task tsk2 = new Task("Task2");
            TaskLink tsklnk1 = new TaskLink(tsk1, tsk2, TaskLinkType.FinishToStart);

            root.Children.Add(tsk1);
            root.Children.Add(tsk2);

            project.AddTaskLink(tsklnk1);

            project.CalcTaskIds();
            project.CalcTaskUids();

            project.UpdateReferences();

            //Save the Project
            project.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

        }
    }
}