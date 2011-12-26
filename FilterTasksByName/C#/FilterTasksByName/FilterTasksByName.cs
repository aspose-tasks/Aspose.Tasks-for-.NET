using System;
using System.IO;
using Aspose.Tasks.Util;

namespace Aspose.Tasks.FilterTasksByName
{
    /// <summary>
    /// This example shows how to combine some conditions.
    /// </summary>
    internal class FilterTasksByName
    {
        /// <summary>
        /// Main method
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Provide path to project file and name of the task you want to filter 
            args = new string[] { @"Path to project file", "Name of the task to filter" };
            try
            {
                if (args.Length != 2)
                {
                    System.Console.WriteLine("Usage: Aspose.Tasks.FindByName <input file name> <taskName>");
                }
                else
                {
                    Filter(args[0], args[1]);
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }

        private static void Filter(string fileName, string pattern)
        {
            // reads project from file
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(new FileStream(fileName, FileMode.Open));

            // filter tasks
            Task newRoot = TaskUtils.Filter(project.RootTask, new NameCondition(pattern));
            // print tasks
            TaskUtils.Apply(newRoot, new TreePrinter(), 0);
        }
    }

    internal class TreePrinter : ITreeAlgorithm
    {
        private string indent = "";

        /// <summary>
        /// Increase indent
        /// </summary>
        /// <param name="el"></param>
        /// <param name="index"></param>
        public void PreAlg(object el, int index)
        {
            indent = indent + " ";
        }


        public void Alg(object el, int index)
        {
            Task task = (Task)el;
            Console.WriteLine(String.Format("{0,4:#####}", task.Uid) + indent + task.Name);
        }

        /// <summary>
        /// Decrease indent
        /// </summary>
        /// <param name="el"></param>
        /// <param name="index"></param>
        public void PostAlg(object el, int index)
        {
            indent = indent.Substring(0, indent.Length - 1);
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