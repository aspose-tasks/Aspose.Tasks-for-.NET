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
using System.Collections.Generic;

namespace ResourceCost
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
                    Console.WriteLine(res.Cost);
                    Console.WriteLine(res.Acwp);
                    Console.WriteLine(res.Bcwp);
                    Console.WriteLine(res.Bcws);
                    Console.WriteLine(res.AccrueAt.ToString());
                }
            }

            
            
        }
    }
}