//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections.Generic;
using System.Collections;
using System;


namespace OvertimesResource
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();
            //Call read method of project reader object to get project object
            FileStream St = new FileStream(dataDir+ "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            List<Resource> alRes = prj.Resources;
            foreach (Resource res in alRes)
            {
                if (res.Name != null)
                {
                    Console.WriteLine(res.OvertimeCost);
                    Console.WriteLine(res.OvertimeWork.ToString());
                    Console.WriteLine(res.OvertimeRateFormat.ToString());
                    Console.WriteLine(res.Overtime);
                }
            }

        }
    }
}