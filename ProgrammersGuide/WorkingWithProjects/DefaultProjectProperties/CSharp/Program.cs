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

namespace DefaultProjectProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // 1.
            // Reading Default Properties
            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Display default properties
            Console.WriteLine("New Task Default Start: " + prj.DefaultStartTime.ToShortDateString());
            Console.WriteLine("New Task Default Type: " + prj.DefaultTaskType.ToString());
            Console.WriteLine("Resource Default Standard Rate: " + prj.DefaultStandardRate.ToString());
            Console.WriteLine("Resource Default Overtime Rate: " + prj.DefaultOvertimeRate.ToString());
            Console.WriteLine("Default Task EV Method: " + prj.DefaultTaskEVMethod.ToString());
            Console.WriteLine("Default Cost Accrual: " + prj.DefaultFixedCostAccrual.ToString());



            // 2.
            // Writing Default Properties
            //Create a project instance
            Project prj1 = new Project();

            //Set default properties
            prj1.IsScheduleFromStart = true;
            prj1.StartDate = DateTime.Now;
            prj1.DefaultStartTime = prj.StartDate;
            prj1.DefaultTaskType = TaskType.FixedDuration;
            prj1.DefaultStandardRate = 15;
            prj1.DefaultOvertimeRate = 12;
            prj1.DefaultTaskEVMethod = EarnedValueMethodType.PercentComplete;
            prj1.DefaultFixedCostAccrual = CostAccrualType.Prorated;

            //Save the project to XML format
            prj1.Save(dataDir + "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}