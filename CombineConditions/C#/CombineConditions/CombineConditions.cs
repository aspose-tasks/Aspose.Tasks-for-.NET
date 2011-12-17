using System;
using System.IO;
using Aspose.Tasks.Util;

namespace Aspose.Tasks.CombineConditions
{
    /// <summary>
    /// This example shows how to combine some conditions.
    /// </summary>
    internal class CombineConditions
    {
        /// <summary>
        /// Main method
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Provide path to project file, name of the task you want to search 
            // and smallest id i.e. searching will be performed on tasks with greater id than this smallest id
            args = new string[] { @"Path to project file","Name of the task to find","Smallest id for condition" };
            try
            {
                if (args.Length != 3)
                {
                    System.Console.WriteLine(
                        "Usage: Aspose.Tasks.CombineConditions <input file name> <taskName> <task id>");
                }
                else
                {
                    Filter(args[0], args[1], args[2]);
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }

        private static void Filter(string fileName, string taskName, string taskID)
        {
            // reads project from file
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(new FileStream(fileName, FileMode.Open));

            // find task
            Task task = TaskUtils.Find(project.RootTask, new And(new NameCondition(taskName),
                new MoreThanIDCondition(Int32.Parse(taskID))));

            // Prints task parameters
            if (task != null)
            {
                Console.WriteLine("Name   : " + task.Name);
                Console.WriteLine("UID    : " + task.Uid);
                Console.WriteLine("ID     : " + task.Id);
                Console.WriteLine("Start  : " + task.Start);
                Console.WriteLine("Finish : " + task.Finish);
            }
        }

        /// <summary>
        /// Define find condition. Method Check() of this class returns true if task name starts with the pattern otherwise returns false;
        /// </summary>
        private class NameCondition : ICondition
        {
            private string pattern;

            public NameCondition(String pattern)
            {
                this.pattern = pattern;
            }

            public bool Check(object el)
            {
                Task task = (Task) el;
                if (task.Name != null)
                {
                    return task.Name.StartsWith(pattern);
                }
                return false;
            }
        }

        /// <summary>
        /// Method Check() of this class returns true if task has id more than initial id
        /// </summary>
        private class MoreThanIDCondition : ICondition
        {
            private int id;

            public MoreThanIDCondition(int id)
            {
                this.id = id;
            }

            public bool Check(object el)
            {
                Task task = (Task) el;
                return task.Id > id;
            }
        }
    }
}