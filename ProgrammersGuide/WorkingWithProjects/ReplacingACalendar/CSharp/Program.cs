//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace ReplacingACalendarExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new Project(dataDir+ "project.mpp");

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
            
            
        }
    }
}