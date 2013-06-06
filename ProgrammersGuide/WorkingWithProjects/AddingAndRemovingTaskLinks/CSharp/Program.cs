//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;

namespace AddingAndRemovingTaskLinks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Remove existing task links
            ArrayList alTskLnk = new ArrayList();
            foreach (TaskLink tskLnk in prj.TaskLinks)
            {
                alTskLnk.Add(tskLnk);
            }
            foreach (TaskLink tlnk in alTskLnk)
            {
                prj.RemoveLink(tlnk);
            }

            //Define new Tasks
            Task tsk3 = new Task("Task13");
            Task tsk4 = new Task("Task14");

            //Add tsk3 and tsk4 to the project
            prj.RootTask.Children.Add(tsk3);
            prj.RootTask.Children.Add(tsk4);

            //Define link between tsk3 and tsk4
            TaskLink tskLnkNew = new TaskLink(tsk3, tsk4, TaskLinkType.FinishToFinish);

            //Add new Task link to project
            prj.AddTaskLink(tskLnkNew);

            //Perform recalculations
            prj.CalcTaskIds();
            prj.CalcTaskUids();

            //Save the project as XML project file
            prj.Save(dataDir + "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML); 
        }
    }
}