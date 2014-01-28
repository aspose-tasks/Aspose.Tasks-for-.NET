//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace MakingAStandardCalendar
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

            //Define Calendar and make it standard
            Aspose.Tasks.Calendar cal1 = new Aspose.Tasks.Calendar("My Cal");
            Aspose.Tasks.Calendar.MakeStandardCalendar(cal1);

            prj.Calendars.Add(cal1);
            prj.CalcCalendarUids();

            //Save the Project
            prj.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
 
        }
    }
}