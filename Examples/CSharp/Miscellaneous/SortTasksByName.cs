/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System;
    using System.Collections.Generic;

    using Aspose.Tasks.Util;

    internal class SortTasksByName
    {
        public static void Run()
        {
            //ExStart:SortTasksByName
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            var project = new Project(dataDir + "project-sort.mpp");
            var coll = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, coll, 0);
            List<Task> tasks = coll.Tasks;

            tasks.Sort(new TaskNameComparer());

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
            //ExEnd:SortTasksByName
        }
         
        //ExStart:ImplementIComparer
        private class TaskNameComparer : IComparer<Task>
        {
            public int Compare(Task x, Task y)
            {
                if (string.IsNullOrEmpty(x.Get(Tsk.Name)))
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(y.Get(Tsk.Name)))
                {
                    return -1;
                }
                
                return string.Compare(x.Get(Tsk.Name), y.Get(Tsk.Name), StringComparison.Ordinal);
            }
        }
        //ExEnd:ImplementIComparer
    }
}
