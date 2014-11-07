//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace WritingProjectInformationExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //Create a project instance
            Project prj = new Project();

            //Set project information properties
            prj.IsScheduleFromStart = true;
            prj.StartDate = new System.DateTime(2009, 8, 10);
            prj.CurrentDate = new System.DateTime(2009, 8, 10);
            prj.StatusDate = new System.DateTime(2009, 8, 10);
            Aspose.Tasks.Calendar cal = Aspose.Tasks.Calendar.MakeStandardCalendar();
            cal.Name = "Standard";
            prj.Calendars.Add(cal);

            //Save the Project as XML
            prj.Save(dataDir+ "project3.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            
        }
    }
}