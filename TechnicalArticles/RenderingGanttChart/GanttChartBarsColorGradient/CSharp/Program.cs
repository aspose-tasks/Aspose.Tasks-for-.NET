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
using System.Drawing;

namespace GanttChartBarsColorGradientExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new Project(dataDir+ "NewProductDev.mpp");
            SaveOptions options = new XamlOptions();
            options.UseGradientBrush = false;
            project.Save(dataDir+ "solid.xaml", options);
            options.UseGradientBrush = true;
            project.Save(dataDir+ "gradient.xaml", options);
            
        }
    }
}