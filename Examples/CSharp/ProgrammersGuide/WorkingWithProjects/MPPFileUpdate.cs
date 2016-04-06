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
    public class MPPFileUpdate
    {
        public static void Run()
        {
            //ExStart: MPPFileUpdate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            //Read an existing project
            Project project = new Project(dataDir+ "MPPFileUpdate.mpp");

            //create a new task
            Task task = project.RootTask.Children.Add("Task1");

            task.Set(Tsk.Start, new System.DateTime(2012, 8, 1));
            task.Set(Tsk.Finish, new DateTime(2012, 8, 5));

            //Save the project as MPP project file
            project.Save(dataDir+ "AfterLinking.Mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP);
            //ExEnd: MPPFileUpdate   
        }
    }
}