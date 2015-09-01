using Microsoft.Office.Interop.MSProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MSProject = Microsoft.Office.Interop.MSProject;
using Office = Microsoft.Office.Core;

namespace VSTO_Tasks
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //Create an Application object
            Microsoft.Office.Interop.MSProject.Application projectApplication = new MSProject.Application();

            object missingValue = System.Reflection.Missing.Value;

            //Open an MPP file
            projectApplication.FileOpenEx("Project.mpp",
                missingValue, missingValue, missingValue, missingValue,
                missingValue, missingValue, missingValue, missingValue,
                missingValue, missingValue, PjPoolOpen.pjPoolReadOnly,
                missingValue, missingValue, missingValue, missingValue,
                missingValue);

            //Create a Project object by assigning active project
            Microsoft.Office.Interop.MSProject.Project project = projectApplication.ActiveProject;

            //Add dependencies among the tasks
            project.Tasks.get_UniqueID(2).TaskDependencies.Add(project.Tasks.get_UniqueID(1), PjTaskLinkType.pjFinishToStart);
            project.Tasks.get_UniqueID(3).TaskDependencies.Add(project.Tasks.get_UniqueID(2), PjTaskLinkType.pjFinishToStart);
            project.Tasks.get_UniqueID(4).TaskDependencies.Add(project.Tasks.get_UniqueID(3), PjTaskLinkType.pjFinishToStart);
            project.Tasks.get_UniqueID(5).TaskDependencies.Add(project.Tasks.get_UniqueID(4), PjTaskLinkType.pjFinishToStart);
            project.Tasks.get_UniqueID(5).TaskDependencies.Add(project.Tasks.get_UniqueID(2), PjTaskLinkType.pjFinishToStart);

            //Display the dependencies
            foreach (Task tsk in project.Tasks)
            {
                foreach (TaskDependency dep in project.Tasks.get_UniqueID(tsk.ID).TaskDependencies)
                {
                    Console.WriteLine("From ID = " + dep.From.ID + "=>To ID = " + dep.To.ID);
                }
                Console.WriteLine("____________________________________________________________");
            }

            //Save the project
            projectApplication.FileCloseAll(Microsoft.Office.Interop.MSProject.PjSaveType.pjSave);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
