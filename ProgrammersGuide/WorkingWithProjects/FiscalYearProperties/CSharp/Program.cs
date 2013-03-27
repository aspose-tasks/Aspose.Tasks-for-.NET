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

namespace FiscalYearProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // 1.
            // Reading Fiscal Year Properties
            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date : " + prj.FyStartDate.ToString());
            Console.WriteLine("Fiscal Year Numbering : " + prj.FiscalYearStart.ToString());



            // 2.
            // Writing Fiscal Year Properties
            //Create a project instance
            Project prj1 = new Project();

            //Set fiscal year properties
            prj1.FyStartDate = Month.July;
            prj1.FiscalYearStart = true;

            //Save the project as XML project file
            prj1.Save(dataDir + "savedProject.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}