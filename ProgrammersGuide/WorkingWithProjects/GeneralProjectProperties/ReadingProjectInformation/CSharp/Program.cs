//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;
using System;
using Aspose.Tasks;

namespace ReadingProjectInformationExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the read method of project reader object to get project object
            FileStream St = new FileStream(dataDir+ "input.xml", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();
            Aspose.Tasks.Calendar cal = Aspose.Tasks.Calendar.Make24HourCalendar();

            if (prj.IsScheduleFromStart)
                Console.WriteLine("Project Finish Date : " + prj.StartDate.ToShortDateString());
            else
                Console.WriteLine("Project Finish Date : " + prj.FinishDate.ToShortDateString());
            string strSchdl = (prj.IsScheduleFromStart) ? "Project Start Date" : "Project Finish Date";
            Console.WriteLine("Project Schedule From : " + strSchdl);
            Console.WriteLine("Current Date : " + prj.CurrentDate.ToShortDateString());
            Console.WriteLine("Status Date : " + prj.StatusDate.ToShortDateString());
            Console.WriteLine("Calendar : " + cal.Name);
            Console.WriteLine("The program has run successfully");
           
        }
    }
}