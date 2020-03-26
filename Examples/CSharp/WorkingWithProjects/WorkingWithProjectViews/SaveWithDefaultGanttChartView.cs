namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    using System;

    using Aspose.Tasks.Saving;

    internal class SaveWithDefaultGanttChartView
    {
        public static void Run()
        {
            try
            {
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
                
                //ExStart:SaveWithDefaultGanttChartView
                //ExFor: Project.Views
                //ExFor: Project.DefaultView
                //ExSummary: Shows how to set a default project view.
                var project = new Project(dataDir + "Project5.mpp"); 
                                                                         
                View view = null;
                foreach (var v in project.Views)
                {
                    if (v.Name == "&Gantt Chart")
                    {
                        view = v;
                    }
                }

                // set default view
                project.DefaultView = view;

                project.Save(dataDir + @"SaveGantChartView_out.mpp", new MPPSaveOptions { WriteViewData = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            //ExEnd:SaveWithDefaultGanttChartView
        }
    }
}
