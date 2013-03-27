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

namespace WeekdayProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            // 1.
            // Reading Weekday Properties
            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Display week days properties
            Console.WriteLine("Week Start Date : " + prj.WeekStartDay.ToString());
            Console.WriteLine("Days Per Month : " + prj.DaysPerMonth.ToString());
            Console.WriteLine("Minutes Per Day : " + prj.MinutesPerDay.ToString());
            Console.WriteLine("Minutes Per Month : " + prj.MinutesPerWeek.ToString());


            // 2.
            // Writing Weekday Properties
            //Create a project instance
            Project prj1 = new Project();

            //Set week days properties
            prj1.WeekStartDay = DayType.Monday;
            prj1.DaysPerMonth = 24;
            prj1.MinutesPerDay = 540;
            prj1.MinutesPerWeek = 3240;

            //Save the project as XML project file
            prj1.Save(dataDir + "savedProject.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}