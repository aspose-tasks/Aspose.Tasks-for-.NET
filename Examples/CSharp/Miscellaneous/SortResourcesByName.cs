namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System;
    using System.Collections.Generic;

    internal class SortResourcesByName
    {
        private static readonly string DataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
        
        //ExStart:SortResourcesByName
        //ExFor: Project.Resources
        //ExSummary: Shows how to sort resources by name.
        public static void Run()
        {
            var project = new Project(DataDir + "project-sort.mpp");

            List<Resource> resources = project.Resources.ToList();
            resources.Sort(new RscNameComparer());

            foreach (var rsc in resources)
            {
                Console.WriteLine(rsc);
            }
        }

        private class RscNameComparer : IComparer<Resource>
        {
            public int Compare(Resource x, Resource y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }

                if (x == null)
                {
                    return -1;
                }

                if (y == null)
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(x.Get(Rsc.Name)))
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(y.Get(Rsc.Name)))
                {
                    return -1;
                }
                
                return string.Compare(x.Get(Rsc.Name), y.Get(Rsc.Name), StringComparison.Ordinal);
            }
        }
        //ExEnd:SortResourcesByName
    }
}
