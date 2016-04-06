//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace CSharp.Projects
{
    public class ReplaceCalendar
    {
        public static void Run()
        {
            //ExStart: ReplaceCalendar
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project(dataDir+ "ReplaceCalendar.mpp");

            Aspose.Tasks.Calendar cal = new Aspose.Tasks.Calendar("New Cal");
            CalendarCollection calColl = project.Calendars;
            foreach (Aspose.Tasks.Calendar c in calColl)
            {
                if (c.Name == "Standard")
                {
                    calColl.Remove(c);
                    calColl.Add("Standard", cal);
                    break;
                }
            }
            //ExEnd: ReplaceCalendar
            
        }
    }
}