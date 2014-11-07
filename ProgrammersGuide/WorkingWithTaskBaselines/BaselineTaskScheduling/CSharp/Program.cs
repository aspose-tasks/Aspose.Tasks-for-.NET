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

namespace BaselineTaskScheduling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            ProjectReader rdr = new ProjectReader();
            FileStream St = new FileStream(dataDir+ "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();
            Task tsk = (Task)prj.RootTask.Children[0];
            ArrayList alB = tsk.Baseline;
            foreach (TaskBaseline tskB in alB)
            {
                Console.WriteLine(tskB.Start.ToShortDateString());
                Console.WriteLine(tskB.Finish.ToShortDateString());
            }

        }
    }
}