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
           MSProject. Application projectApplication = new MSProject.Application();

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

            //Loop through each task and read information related to tasks
            foreach (Task task in project.Tasks)
            {
                Console.WriteLine("Reading Task " + task.Name);
                Console.WriteLine("\nID: " + task.ID);
                Console.WriteLine("Start: " + task.Start);
                Console.WriteLine("Finish: " + task.Finish);
                Console.WriteLine("\n===========================\n");

                //Read any other information you need
            }

            //Loop through each resource and read information related to resources
            foreach (Resource resource in project.Resources)
            {
                string resourceType = null;
                switch (resource.Type)
                {
                    case PjResourceTypes.pjResourceTypeCost:
                        resourceType = "Cost";
                        break;
                    case PjResourceTypes.pjResourceTypeMaterial:
                        resourceType = "Material";
                        break;
                    case PjResourceTypes.pjResourceTypeWork:
                        resourceType = "Work";
                        break;
                }
                Console.WriteLine("Reading Resource " + resource.Name);
                Console.WriteLine("\nID: " + resource.ID);
                Console.WriteLine("Type: " + resourceType);
                Console.WriteLine("\n===========================\n");

                //Read any other information you need
            }
            Console.ReadLine();
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
