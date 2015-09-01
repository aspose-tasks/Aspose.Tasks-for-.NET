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
            //Create Application object
            MSProject.Application projectApplication = new MSProject.Application();

            object missingValue = System.Reflection.Missing.Value;

            //Open an MPP file
            projectApplication.FileOpenEx("Project1.mpp",
                missingValue, missingValue, missingValue, missingValue,
                missingValue, missingValue, missingValue, missingValue,
                missingValue, missingValue, PjPoolOpen.pjPoolReadOnly,
                missingValue, missingValue, missingValue, missingValue,
                missingValue);

            //Create a Project object by assigning active project
            Project project = projectApplication.ActiveProject;

            // Enumerate the tasks
            foreach (Task task in project.Tasks)
            {
                //Get critical tasks
                if (task != null)
                    if ((bool)task.Critical)
                    {
                        Console.WriteLine(task.ID + "  " + task.Name);
                        Console.WriteLine(task.Start);
                        Console.WriteLine(task.Finish + "\n");
                    }
            }

            // Make sure to clean up and close the file
            projectApplication.FileCloseAll(PjSaveType.pjDoNotSave);

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
