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

namespace ReadingProjectFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project reader instance
            ProjectReader projectReader = new ProjectReader();

            //Call the read method of project reader object to get project object
            FileStream projectStream = new FileStream(dataDir + "Project.mpp", FileMode.Open);
            Project existingProject = projectReader.Read(projectStream);
            projectStream.Close();

            //Display default properties
            Console.WriteLine("New Task Default Start: " + existingProject.DefaultStartTime.ToShortDateString());
            Console.WriteLine("New Task Default Type: " + existingProject.DefaultTaskType.ToString());
            Console.WriteLine("Resouce Default Standard Rate: " + existingProject.DefaultStandardRate.ToString());
            Console.WriteLine("Resource Default Overtime Rate: " + existingProject.DefaultOvertimeRate.ToString());
            Console.WriteLine("Default Task EV Method: " + existingProject.DefaultTaskEVMethod.ToString());
            Console.WriteLine("Default Cost Accrual: " + existingProject.DefaultFixedCostAccrual.ToString());
        }
    }
}