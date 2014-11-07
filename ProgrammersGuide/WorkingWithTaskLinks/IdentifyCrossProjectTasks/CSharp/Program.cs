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

namespace IdentifyCrossProjectTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            

            ProjectReader reader = new ProjectReader();
Project externalProject = reader.Read(dataDir+ "External.mpp");

Task externalTask = externalProject.GetTaskByUid(4);
//ID of the task in the external project
Console.WriteLine(externalTask.Id.ToString());
//ID of the task in the original project
Console.WriteLine(externalTask.ExternalId.ToString());
        }
    }
}