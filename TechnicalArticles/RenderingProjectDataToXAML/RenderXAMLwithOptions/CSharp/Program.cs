//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

namespace RenderXAMLwithOptionsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //Load project
            Project project = new Project(dataDir+ "NewProductDev.mpp");
            string resFile = dataDir+ "NewProductDev.xaml";
            SaveOptions options = new XamlOptions();
            options.FitContent = true;
            options.LegendOnEachPage = false;
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(resFile, options);
            
            
        }
    }
}