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
            projectApplication.FileOpenEx("Project1.mpp",
                missingValue, missingValue, missingValue, missingValue,
                missingValue, missingValue, missingValue, missingValue,
                missingValue, missingValue, PjPoolOpen.pjPoolReadOnly,
                missingValue, missingValue, missingValue, missingValue,
                missingValue);
            Microsoft.Office.Interop.MSProject.Project project = projectApplication.ActiveProject;

            int iRecourceId = 1;
            foreach (Task tsk in project.Tasks)
            {
                string developer = "Developer0" + iRecourceId;
                project.Resources.Add(developer, iRecourceId);
                tsk.Assignments.Add(tsk.ID, iRecourceId, missingValue);
                iRecourceId++;
            }

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
