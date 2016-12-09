using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class ImplementCustomBarStyleWriting
    {
        public static void Run()
        {
            ImplementCustomBarSytle();
        }

        // ExStart:ImplementCustomBarStyleWriting
        static void ImplementCustomBarSytle()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                Project project = new Project(dataDir + "Blank2010.mpp");
                project.RootTask.Children.Add("Task");

                GanttChartView view = project.DefaultView as GanttChartView;
                GanttBarStyle custom = GetCustomBarStyle();

                // Add the custom bar style to the custom bar collection of the project view
                view.CustomBarStyles.Add(custom);

                string file = "ImplementCustomBarStyleWriting_out.mpp";

                MPPSaveOptions options = new MPPSaveOptions();
                options.WriteViewData = true;

                project.Save(dataDir + file, options);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        private static GanttBarStyle GetCustomBarStyle()
        {
            GanttBarStyle style = new GanttBarStyle();
            style.ShowFor = "1";
            style.MiddleShape = GanttBarMiddleShape.RectangleBottom;
            style.MiddleFillPattern = GanttBarFillPattern.MediumFill;
            style.MiddleShapeColor = Color.Blue;

            style.StartShape = GanttBarEndShape.ArrowDown;
            style.StartShapeColor = Color.Red;

            style.EndShape = GanttBarEndShape.ArrowUp;
            style.EndShapeColor = Color.Yellow;

            style.LeftField = Field.TaskResourceNames;
            style.RightField = Field.TaskName;
            style.TopField = Field.TaskStart;
            style.BottomField = Field.TaskFinish;
            style.InsideField = Field.TaskDuration;

            return style;
        }
        // ExEnd:ImplementCustomBarStyleWriting
    }
}
