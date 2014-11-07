//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Tasks;
using Aspose.Tasks.Visualization;
using System.Collections;
using System.Drawing;
using System.IO;


namespace DisplayMultipleColumnsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            {
                Program prg = new Program();
                ProjectReader reader = new ProjectReader();
                Project project = reader.Read(dataDir + "Project1.mpp");
                //Create the view columns
                ArrayList columns = new ArrayList();
                columns.Add(new GanttChartColumn("Name", 100, new TaskToColumnTextConverter(prg.TaskName)));
                columns.Add(new GanttChartColumn("Notes", 100, new TaskToColumnTextConverter(prg.TaskNotes)));
                columns.Add(new GanttChartColumn("Resources", 200, new TaskToColumnTextConverter(prg.TaskResources)));
                //Create the view
                ProjectView view = new ProjectView(columns);
                //Render to image
                IRenderResult res = project.Export(RenderFormat.Image, PresentationFormat.GanttChart, "project.tiff", new BaseImageRenderParam(null,
                    new Point(), new Size(1200, 800), 100, 0, true), true, null, view);

                //Create a new view
                ArrayList columns2 = new ArrayList();
                columns2.Add(new GanttChartColumn("Name", 100, new TaskToColumnTextConverter(prg.TaskNameHtml)));
                columns2.Add(new GanttChartColumn("Notes", 100, new TaskToColumnTextConverter(prg.TaskNotes)));
                columns2.Add(new GanttChartColumn("Resources", 200, new TaskToColumnTextConverter(prg.TaskResources)));
                //Create the view
                ProjectView view2 = new ProjectView(columns2);
                //Render to html
                project.Export(RenderFormat.Html, PresentationFormat.GanttChart, dataDir + "project.html", new BaseImageRenderParam(null, new Point(), new Size(1200, 800), 100, 0, false), true, null, view2);
            }
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
            
            
       