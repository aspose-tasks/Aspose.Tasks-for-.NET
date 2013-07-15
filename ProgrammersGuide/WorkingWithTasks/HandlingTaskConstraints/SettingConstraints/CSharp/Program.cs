//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;

namespace SettingConstraints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Reading a project file
            ProjectReader rdr = new ProjectReader();
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project project = rdr.Read(St);
            St.Close();

            //Setting Save Option
            SaveOptions o = new PdfSaveOptions();
            o.StartDate = project.StartDate;
            o.Timescale = Timescale.ThirdsOfMonths;
            
            //Get Task by ID
            Task summary = project.GetTaskById(7);

            //Set Constraint
            summary.ConstraintType = ConstraintType.StartNoEarlierThan;
            summary.ConstraintDate = new DateTime(2013, 6, 3, 9, 0, 0);
            Task.Recalculate(project.RootTask);
            
            //Save to PDF file
            project.Save(dataDir + "summary SNET June 3.pdf", o);
        }
    }
}