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

namespace SettingGeneralProperties
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

            //Add child task and set general properties
            Task tskGen = new Task("Task1");
            tskGen.Id = 1;
            tskGen.Uid = 1;
            tskGen.Start = DateTime.Parse("17-Aug-2009 8:00 AM");
            tskGen.Finish = DateTime.Parse("17-Aug-2009 5:00 PM");

            root.Children.Add(tskGen);

            //We need to recalculate the IDs only as UIDs were set correctly.
            project.CalcTaskIds();
            project.CalcTaskUids();


            project.UpdateReferences();

            //Save the Project
            project.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

        }
    }
}