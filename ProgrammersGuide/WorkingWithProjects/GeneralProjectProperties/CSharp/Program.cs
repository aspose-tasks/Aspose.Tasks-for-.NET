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

namespace GeneralProjectProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            
            // 1.
            // Read General Project Properties
            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            if (prj.IsScheduleFromStart)
                Console.WriteLine("Project Finish Date : " + prj.StartDate.ToShortDateString());
            else
                Console.WriteLine("Project Finish Date : " + prj.FinishDate.ToShortDateString());
            string strSchdl = (prj.IsScheduleFromStart) ? "Project Start Date" : "Project Finish Date";
            Console.WriteLine("Project Schedule From : " + strSchdl);
            Console.WriteLine("Current Date : " + prj.CurrentDate.ToShortDateString());
            Console.WriteLine("Status Date : " + prj.StatusDate.ToShortDateString());
            Console.WriteLine("Calendar : " + prj.Calendar.Name);

            // 2.
            // Write General Project Properties
            //Create a project instance
            Project prj1 = new Project();

            //Set project information properties
            prj1.IsScheduleFromStart = true;
            prj1.StartDate = new System.DateTime(2009, 8, 10);
            prj1.CurrentDate = new System.DateTime(2009, 8, 10);
            prj1.StatusDate = new System.DateTime(2009, 8, 10);
            Aspose.Tasks.Calendar cal = Aspose.Tasks.Calendar.MakeStandardCalendar();
            cal.Name = "Standard";
            prj1.Calendars.Add(cal);

            //Save the Project as XML
            prj1.Save(dataDir + "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}