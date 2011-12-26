using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Tasks;
using Aspose.Tasks.Visualization;
using System.Collections;
using System.Drawing;

namespace RenderingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();

            ProjectReader reader = new ProjectReader();
            Project project = reader.Read("./../../Samples/TestViews.mpp");
            
            //Create the view columns
            ArrayList columns = new ArrayList();
            columns.Add(new GanttChartColumn("Name", 300, new TaskToColumnTextConverter(prg.TaskName)));
            columns.Add(new GanttChartColumn("Notes", 100, new TaskToColumnTextConverter(prg.TaskNotes)));
            columns.Add(new GanttChartColumn("Resources", 200, new TaskToColumnTextConverter(prg.TaskResources)));
           
            //Create the view
            ProjectView view = new ProjectView(columns);
           
            //Render to image
            IRenderResult res = project.Export(RenderFormat.Image, PresentationFormat.GanttChart, "./../../Output/Project.png", new BaseImageRenderParam(null,
                new Point(), new Size(1200, 800), 100, 0, true), true, null, view);

            //Create a new view
            ArrayList columns2 = new ArrayList();
            columns2.Add(new GanttChartColumn("Name", 300, new TaskToColumnTextConverter(prg.TaskNameHtml)));
            columns2.Add(new GanttChartColumn("Notes", 100, new TaskToColumnTextConverter(prg.TaskNotes)));
            columns2.Add(new GanttChartColumn("Resources", 200, new TaskToColumnTextConverter(prg.TaskResources)));
           
            //Create the view
            ProjectView view2 = new ProjectView(columns2);
            
            //Render to html
            res = project.Export(RenderFormat.Html, PresentationFormat.GanttChart, "./../../Output/Project.html", new BaseImageRenderParam(null,
                new Point(), new Size(1200, 800), 100, 0, false), true, null, view2);
        }


        /// <summary>
        /// Forms task's name column.
        /// </summary>
        /// <param name="task">Current task.</param>
        /// <returns>Column's text.</returns>
        private string TaskName(Task task)
        {
            StringBuilder res = new StringBuilder();
            for (int i = 1; i < task.OutlineLevel; i++)
                res.Append("  ");
            res.AppendFormat("{0}. {1}", task.Id, task.Name);
            return res.ToString();
        }


        /// <summary>
        /// Forms task's name column.
        /// </summary>
        /// <param name="task">Current task.</param>
        /// <returns>Column's text.</returns>
        private string TaskNameHtml(Task task)
        {
            StringBuilder res = new StringBuilder();
            for (int i = 1; i < task.OutlineLevel; i++)
                res.Append("&nbsp;&nbsp;");
            res.AppendFormat("{0}. {1}", task.Id, task.Name);
            return res.ToString();
        }


        /// <summary>
        /// Forms task's notes column.
        /// </summary>
        /// <param name="task">Current task.</param>
        /// <returns>Column's text.</returns>
        private string TaskNotes(Task task)
        {
            if (task.NotesText != null)
                return task.NotesText;
            else
                return string.Empty;
        }


        /// <summary>
        /// Forms task's resources column.
        /// </summary>
        /// <param name="task">Current task.</param>
        /// <returns>Column's text.</returns>
        private string TaskResources(Task task)
        {
            StringBuilder res = new StringBuilder();
            Project project = task.ParentProject;
            bool bFirst = true;


            foreach (ResourceAssignment assignment in project.GetResourceAssignmentsByTask(task))
                if (assignment.Resource != null)
                {
                    if (!bFirst)
                        res.Append(", ");
                    res.Append(assignment.Resource.Name);
                    bFirst = false;
                }
            return res.ToString();
        }
    }
}
