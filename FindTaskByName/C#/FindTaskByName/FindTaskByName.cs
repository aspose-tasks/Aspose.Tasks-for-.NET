using System;
using System.IO;
using Aspose.Tasks.Util;

namespace Aspose.Tasks.FindTaskByName
{
    /// <summary>
    /// This example shows how to combine some conditions.
    /// </summary>
    internal class FindTaskByName
    {
        /// <summary>
        /// Main method
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Provide path to project file and name of the task you want to search 
            args = new string[] { @"Path to project file", "Name of the task to find" };
            try
            {
                if (args.Length != 2)
                {
                    System.Console.WriteLine("Usage: Aspose.Tasks.FindByName <input file name> <taskName>");
                }
                else
                {
                    Find(args[0], args[1]);
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Finds taks by name and prinst task name, uid, id, date start and date end
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="taskName"></param>
        private static void Find(string fileName, string taskName)
        {
            // reads project from file
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(new FileStream(fileName, FileMode.Open));

            // Searching task
            Task task = TaskUtils.Find(project.RootTask, new NameCondition(taskName));

            // Prints task parameters
            if (task != null)
            {
                Console.WriteLine("Name   : " + task.Name);
                Console.WriteLine("UID    : " + task.Uid);
                Console.WriteLine("ID     : " + task.Id);
                Console.WriteLine("Start  : " + task.Start);
                Console.WriteLine("Finish : " + task.Finish);
            }
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Define find condition. Method Check() of this class returns true if task name starts with the pattern otherwise returns false;
    /// </summary>
    internal class NameCondition : ICondition
    {
        private string pattern;

        public NameCondition(String pattern)
        {
            this.pattern = pattern;
        }

        public bool Check(object el)
        {
            Task task = (Task)el;
            if (task.Name != null)
            {
                return task.Name.StartsWith(pattern);
            }
            return false;
        }
    }
}