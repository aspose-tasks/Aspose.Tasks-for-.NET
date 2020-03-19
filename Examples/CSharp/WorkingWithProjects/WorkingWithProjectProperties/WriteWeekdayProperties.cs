namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using Aspose.Tasks.Saving;

    internal class WriteWeekdayProperties
    {
        public static void Run()
        {
            //ExStart:WriteWeekdayProperties
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            var project = new Project(dataDir + "WriteWeekdayProperties.mpp");

            // Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday);
            project.Set(Prj.DaysPerMonth, 24);
            project.Set(Prj.MinutesPerDay, 540);
            project.Set(Prj.MinutesPerWeek, 3240);
            project.Save(dataDir + "WriteWeekdayProperties_out.xml", SaveFileFormat.XML);
            //ExEnd:WriteWeekdayProperties            
        }
    }
}