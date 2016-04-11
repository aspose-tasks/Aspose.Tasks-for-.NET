using System;
using Aspose.Tasks;

namespace CSharp.Projects
{
    public class TaskSettingStartFinishDates
    {
        /// <summary>
        /// By default, the project calculation mode is set to automatic that recalculates everything and sets the dates. 
        /// If you are creating a new project, it's start date is as of today and rest of the dates are calculated 
        /// automatically with reference to this start date. 
        /// </summary>
        public static void Run()
        {
            Project project = new Project();
            Console.WriteLine(project.Get(Prj.StartDate));
            Console.WriteLine(project.CalculationMode.ToString());

            project.CalculationMode = CalculationMode.None;

            Console.WriteLine(project.CalculationMode.ToString());

            Task task = project.RootTask.Children.Add("Task1");

            task.Set(Tsk.Start, new DateTime(2012, 8, 1));
            task.Set(Tsk.Finish, new DateTime(2012, 8, 5));

            Console.WriteLine("*************** Before Recalculate *****************");
            Console.WriteLine(task.Get(Tsk.Start));
            Console.WriteLine(task.Get(Tsk.Finish));


            project.Recalculate();

            Console.WriteLine("*************** After Recalculate *****************");
            Console.WriteLine(task.Get(Tsk.Start));
            Console.WriteLine(task.Get(Tsk.Finish));
        }
    }
}
