using Aspose.Tasks.Visualization;
using System.Drawing;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    class SupportForTextStyle
    {
        public static void Run()
        {
            //ExStart:SupportForTextStyle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project = new Project(dataDir + "Project5.mpp"); // Create a new project task
            var ganttChartView = project.Views.ToList()[0] as GanttChartView;
            if (ganttChartView != null)
            {
                ganttChartView.TableTextStyles.Clear();
                ganttChartView.TableTextStyles.Add(new TableTextStyle(1) { Color = Color.Red, Field = Field.TaskName });
                ganttChartView.TableTextStyles.Add(new TableTextStyle(1) { Color = Color.Gray, Field = Field.TaskDurationText });
                ganttChartView.TableTextStyles.Add(new TableTextStyle(2) { Color = Color.Blue, FontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline });
            }
            //ExEnd:SupportForTextStyle
        }
    }
}
