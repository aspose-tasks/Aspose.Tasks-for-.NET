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

namespace DefiningRootTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project instance
            Project prj = new Project();

            //Define a Task and set it as Root Task
            Task rootTsk = new Task();
            prj.RootTask = rootTsk;

            //Define Tasks
            Task tsk1 = new Task("Task1");
            tsk1.Start = DateTime.Now;
            Task tsk2 = new Task("Task2");
            tsk2.Start = DateTime.Now;

            //Add tsk1 and tsk2 to the rootTsk
            rootTsk.Children.Add(tsk1);
            rootTsk.Children.Add(tsk2);

            //Perform recalculations
            prj.CalcTaskIds();
            prj.CalcTaskUids();

            //Save the project as XML project file
            prj.Save(dataDir + "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}