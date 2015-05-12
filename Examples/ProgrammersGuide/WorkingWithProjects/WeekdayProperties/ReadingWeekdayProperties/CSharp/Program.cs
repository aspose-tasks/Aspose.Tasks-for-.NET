//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;

namespace ReadingWeekdayPropertiesExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new Project(dataDir+ "project.mpp");

            //Display week days properties
            Console.WriteLine("Week Start Date : " + project.Get(Prj.WeekStartDay).ToString());
            Console.WriteLine("Days Per Month : " + project.Get(Prj.DaysPerMonth).ToString());
            Console.WriteLine("Minutes Per Day : " + project.Get(Prj.MinutesPerDay).ToString());
            Console.WriteLine("Minutes Per Week : " + project.Get(Prj.MinutesPerWeek).ToString());
            
            
        }
    }
}