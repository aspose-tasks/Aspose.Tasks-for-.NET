//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;

namespace GettingTaskCalendar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            ProjectReader rdr = new ProjectReader();
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();
            ArrayList alTasks = prj.RootTask.Children;
            foreach (Task tskCh in alTasks)
            {
                //code to display tskCh.Calendar properties
                Console.WriteLine("Calendar Name: " + tskCh.Calendar.Name);
                Console.WriteLine("Calendar Uid: " + tskCh.Calendar.Uid);
                
            }

        }
    }
}