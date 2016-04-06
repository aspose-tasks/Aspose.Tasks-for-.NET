//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace CSharp.Projects
{
    public class WriteWeekdayProperties
    {
        public static void Run()
        {
            //ExStart: WriteWeekdayProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            //Create a project instance
            Project project = new Project(dataDir+ "WriteWeekdayProperties.mpp");

            //Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday);
            project.Set(Prj.DaysPerMonth, 24);
            project.Set(Prj.MinutesPerDay, 540);
            project.Set(Prj.MinutesPerWeek, 3240);

            project.Save(dataDir+ "saved.xml", SaveFileFormat.XML);
            //ExEnd: WriteWeekdayProperties            
        }
    }
}