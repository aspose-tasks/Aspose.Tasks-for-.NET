using System;
using System.Collections;
using System.IO;
using System.Text;
using Aspose.Tasks.Util;

namespace Aspose.Tasks.ArrangeWBS
{
    /// <summary>
    /// Setups Roman WBS codes
    /// </summary>
    internal class CustomWBSArranger : ITreeAlgorithm
    {
        // level indexes
        private ArrayList levelCounters = new ArrayList();

        // separates codes
        private char separator = ',';

        /// <summary>
        /// Converts integer to Roman number string.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string RomanUCNumbering(int num)
        {
            StringBuilder sb = new StringBuilder();
            if (num >= 1000)
            {
                sb.Append('M', num / 1000);
                num %= 1000;
            }
            if (num >= 900)
            {
                sb.Append("CM");
                num -= 900;
            }
            if (num >= 500)
            {
                sb.Append('D');
                num -= 500;
            }
            if (num >= 400)
            {
                sb.Append("CD");
                num -= 400;
            }
            if (num >= 100)
            {
                sb.Append('C', num / 100);
                num %= 100;
            }
            if (num >= 90)
            {
                sb.Append("XC");
                num -= 90;
            }
            if (num >= 50)
            {
                sb.Append('L');
                num -= 50;
            }
            if (num >= 40)
            {
                sb.Append("XL");
                num -= 40;
            }
            if (num >= 10)
            {
                sb.Append('X', num / 10);
                num %= 10;
            }
            if (num >= 9)
            {
                sb.Append("IX");
                num -= 9;
            }
            if (num >= 5)
            {
                sb.Append('V');
                num -= 5;
            }
            if (num >= 4)
            {
                sb.Append("IV");
                num -= 4;
            }
            if (num >= 1)
            {
                sb.Append('I', num);
            }
            return sb.ToString();
        }

        public CustomWBSArranger()
        {
            // init level indexes
            levelCounters.Clear();
            for (int i = 0; i < 10; i++)
            {
                levelCounters.Add(0);
            }
        }

        /// <summary>
        /// This method increments current level counter in the list of level counters
        /// </summary>
        /// <param name="level"></param>
        private void IncLevelCounter(int level)
        {
            if (level > levelCounters.Count)
            {
                return;
            }
            else
            {
                levelCounters[level - 1] = ((int)levelCounters[level - 1]) + 1;
            }
        }

        public void PreAlg(object el, int level)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        /// <param name="level"></param>
        public void Alg(object el, int level)
        {
            // skips zero level
            if (level == 0)
            {
                return;
            }
            Task task = (Task)el;
            string wbs = "";
            IncLevelCounter(level);
            for (int i = 0; i < level; i++)
            {
                // compose wbs code
                if (i > 0)
                {
                    wbs += separator;
                }
                wbs += RomanUCNumbering((int)levelCounters[i]);
            }
            task.Wbs = wbs;
        }

        public void PostAlg(object el, int level)
        {
            if (level < levelCounters.Count)
                levelCounters[level] = 0;
        }
    }

    public class ArrangeWBS
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            args = new string[] { "Path to project file" };
            try
            {
                if (args.Length != 1)
                {
                    System.Console.WriteLine("Usage: Aspose.Tasks.ArrangeWBS <input file name>");
                    Console.ReadKey();
                }
                else
                {
                    ProcessWBS(args[0]);
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
            System.Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void ProcessWBS(String fileName)
        {
            // reads project from file
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(new FileStream(fileName, FileMode.Open));

            // uses TaskUtils to apply CustomWBSArranger to tasks tree
            TaskUtils.Apply(project.RootTask, new CustomWBSArranger(), 0);

            // writes project
            ProjectWriter writer = new ProjectWriter();
            writer.Write(project, new FileStream("./../../Output/Output.xml", FileMode.Create), TasksDataFormat.XML);
        }
    }
}
