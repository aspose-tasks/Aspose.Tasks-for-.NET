//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;

namespace SetCurrencyProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project instance
            Project prj = new Project();

            //Set currency properties
            prj.CurrencyCode = "AUD";
            prj.CurrencyDigits = 2;
            prj.CurrencySymbol = "$";
            prj.CurrencySymbolPosition = CurrencySymbolPositionType.After;

            //Save the project as XML project file
            prj.Save(dataDir + "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML); 
            
        }
    }
}