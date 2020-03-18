/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System;
    using System.Drawing;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class ImplementCustomBarStyleWriting
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            ImplementCustomBarStyle(dataDir);
        }

        //ExStart:ImplementCustomBarStyleWriting
        //ExFor: GanttChartView.CustomBarStyles
        //ExSummary: Shows how to set custom bar styles of Gantt Chart project view. 
        private static void ImplementCustomBarStyle(string dataDir)
        {
            try
            {
                var project = new Project(dataDir + "Blank2010.mpp");
                project.RootTask.Children.Add("Task");

                var view = (GanttChartView)project.DefaultView;
                var custom = GetCustomBarStyle();

                // Add the custom bar style to the custom bar collection of the project view
                view.CustomBarStyles.Add(custom);

                var options = new MPPSaveOptions();
                options.WriteViewData = true;

                project.Save(dataDir + "ImplementCustomBarStyleWriting_out.mpp", options);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        private static GanttBarStyle GetCustomBarStyle()
        {
            var style = new GanttBarStyle();
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
        //ExEnd:ImplementCustomBarStyleWriting
    }
}
