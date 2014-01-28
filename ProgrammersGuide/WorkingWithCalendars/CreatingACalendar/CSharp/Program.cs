//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace CreatingACalendar
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

            //Define Calendar
            Aspose.Tasks.Calendar cal1 = new Aspose.Tasks.Calendar();
            cal1.Name = "no info";
            Aspose.Tasks.Calendar cal2 = new Aspose.Tasks.Calendar(1);
            cal2.Name = "no name";
            Aspose.Tasks.Calendar cal3 = new Aspose.Tasks.Calendar("cal3");
            prj.Calendars.Add(cal1);
            prj.Calendars.Add(cal2);
            prj.Calendars.Add(cal3);

            prj.CalcCalendarUids();

            //Save the Project
            prj.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

        }
    }
}