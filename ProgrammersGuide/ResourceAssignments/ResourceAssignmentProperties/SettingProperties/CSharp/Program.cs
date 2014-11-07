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

namespace SettingProperties
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

            Project prj = new Project();

            Task tskRoot = new Task();
            Task tsk1 = new Task("Task1");
            Task tsk2 = new Task("Task2");

            Resource res = new Resource();
            Resource res1 = new Resource("Resource1");

            ResourceAssignment ra1 = new ResourceAssignment(tsk1, res1);
            ra1.Start = DateTime.Parse("18-Aug-2009 8:00 AM");
            ra1.Finish = DateTime.Parse("18-Aug-2009 5:00 PM");
            ra1.Uid = 1;

            ResourceAssignment ra2 = new ResourceAssignment(tsk2, res1);
            ra2.Start = DateTime.Parse("19-Aug-2009 8:00 AM");
            ra2.Finish = DateTime.Parse("19-Aug-2009 5:00 PM");
            ra2.Uid = 2;

            prj.RootTask = tskRoot;
            prj.RootTask.Children.Add(tsk1);
            prj.RootTask.Children.Add(tsk2);

            prj.Resources.Add(res);
            prj.Resources.Add(res1);

            prj.ResourceAssignments.Add(ra1);
            prj.ResourceAssignments.Add(ra2);

            prj.CalcResourceUids();
            prj.CalcTaskIds();
            prj.CalcTaskUids();
            prj.CalcResourceUids();
            prj.CalcResourceStartFinish();
            prj.CalcResourceIds();
            prj.CalcResourceFields();
            prj.CalcResourceAssignmentUids();
            prj.CalcResourceAssignmentIds();

            //Save the Project
            prj.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

        }
    }
}