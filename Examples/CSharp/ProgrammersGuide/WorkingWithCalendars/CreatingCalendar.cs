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
    class CreatingCalendar
    {
        public static void Run()
        {
            //ExStart: CreatingCalendar
            //New calendar can be added to a project's calendar collection using the collection's Add method.
            
            //Create a project instance
            Project project = new Project();

            //Define Calendar
            Aspose.Tasks.Calendar cal1 = project.Calendars.Add("New Info");
            Aspose.Tasks.Calendar cal2 = project.Calendars.Add("no name");
            Aspose.Tasks.Calendar cal3 = project.Calendars.Add("cal3");

            //Save the Project
            string dataDir = RunExamples.GetDataDir_Projects();
            project.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            //ExEnd: CreatingCalendar
        }
    }
}
