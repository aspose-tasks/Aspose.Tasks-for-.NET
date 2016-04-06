//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;
using System;
using Aspose.Tasks;

namespace CSharp.Projects
{
    public class ReadProjectInfo
    {
        public static void Run()
        {
            //ExStart: ReadProjectInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Create a project reader instance
            Project project = new Project(dataDir+ "ReadProjectInfo.mpp");
            if (project.Get(Prj.ScheduleFromStart))
                Console.WriteLine("Project Finish Date : " + project.Get(Prj.StartDate).ToShortDateString());
            else
                Console.WriteLine("Project Finish Date : " + project.Get(Prj.FinishDate).ToShortDateString());
            Console.WriteLine(project.Get(Prj.Author));
            Console.WriteLine(project.Get(Prj.LastAuthor));
            Console.WriteLine(project.Get(Prj.Revision));
            Console.WriteLine(project.Get(Prj.Keywords));
            Console.WriteLine(project.Get(Prj.Comments));
            Console.WriteLine("The program has run successfully");
            //ExEnd: ReadProjectInfo
        }
    }
}