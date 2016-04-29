//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using Aspose.Tasks;
using CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.ProgrammersGuide.WorkingWithCalendars
{
    class MakeAStandardCalendar
    {
        public static void Run()
        { 
            //ExStart: MakeAStandardCalendar
            //The static method of Calendar class, MakeStandardCalendar can be used to make a calendar as Standard after it has been added ot the project

            //Create a project instance
            Project project = new Project();

            //Define Calendar and make it standard
            Aspose.Tasks.Calendar cal1 = project.Calendars.Add("My Cal");

            //Now make this calendar as a standard calendar
            Aspose.Tasks.Calendar.MakeStandardCalendar(cal1);

            //Save the Project
            string dataDir = RunExamples.GetDataDir_Projects();

            project.Save("Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            //ExEnd: MakeAStandardCalendar
        }
    }
}
