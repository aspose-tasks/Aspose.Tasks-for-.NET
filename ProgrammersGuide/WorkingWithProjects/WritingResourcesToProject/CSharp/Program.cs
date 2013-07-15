//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace WritingResourcesToProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Create a project instance
            Project prj = new Project();

            //Define Resources
            Resource rec = new Resource();
            Resource rec1 = new Resource("Res1");
            rec1.Type = ResourceType.Work;
            Resource rec2 = new Resource("Res2");
            rec2.Type = ResourceType.Material;

            //Add to the project
            prj.Resources.Add(rec);
            prj.Resources.Add(rec1);
            prj.Resources.Add(rec2);

            //Perform recalculations
            prj.CalcResourceIds();
            prj.CalcResourceUids();
            prj.CalcResourceFields();

            //Save the project as XML project file
            prj.Save(dataDir + "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML); 
        }
    }
}