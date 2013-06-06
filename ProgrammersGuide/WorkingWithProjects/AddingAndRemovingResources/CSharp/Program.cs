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

namespace AddingAndRemovingResources
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Remove a resource
            if (prj.Resources.Count > 1)
                prj.Resources.RemoveAt(0);

            //Add a resource
            Resource recADD = new Resource("Added");
            recADD.Type = ResourceType.Work;
            prj.Resources.Add(recADD);

            //Display resources
            ArrayList alRecs = prj.Resources;

            foreach (Resource rec in alRecs)
            {
                if (rec.Name != null)
                {
                    Console.WriteLine("Res Name" + rec.Name);
                    Console.WriteLine("Res Type" + rec.Type.ToString());
                }
            }

        }
    }
}