using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read("Project.mpp");

            Aspose.Tasks.Task task = new Aspose.Tasks.Task("Task1");
            task.ActualStart = DateTime.Parse("23-Aug-2012");

            //Set duration in hours
            task.Duration = new TimeSpan(24, 0, 0);
            task.DurationFormat = TimeUnitType.Day;
            project.RootTask.Children.Add(task);

            //Recalculate task IDs
            project.CalcTaskIds();
            project.CalcTaskUids();

            //Save the Project as XML
            project.Save("OutputProject.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

        }
    }
}
