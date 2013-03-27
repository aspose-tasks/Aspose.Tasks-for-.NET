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

namespace DeterminingProjectVersion
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
            FileStream st = new FileStream(dataDir + "input.xml", FileMode.Open);
            Project prj = rdr.Read(st);
            st.Close();

            //Display project version property
            Console.WriteLine("Project Version : " + prj.SaveVersion.ToString());
            Console.WriteLine("Last Saved : " + prj.LastSaved.ToShortDateString());
        }
    }
}