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

namespace ManagingDurations
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

            //Create a project instance
            Project prj = new Project();
            prj.MinutesPerDay = 480;
            //Define Tasks
            Task rootTsk = new Task();
            Task tsk1 = new Task("Task1");

            tsk1.ActualStart = DateTime.Parse("01-Jun-00 8:00 AM");
            tsk1.Duration = new TimeSpan(8, 0, 0);
            tsk1.DurationFormat = TimeUnitType.Day;

            //Add tsk1 to the rootTsk
            rootTsk.Children.Add(tsk1);
            //Set rootTsk as root task of the project
            prj.RootTask = rootTsk;
            //Perform recalculations
            prj.CalcTaskIds();
            prj.CalcTaskUids();

            //Save the Project
            prj.Save(dataDir + "ManagaingDurations.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

        }
    }
}