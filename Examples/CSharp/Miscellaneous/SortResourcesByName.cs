using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    class SortResourcesByName
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:SortResourcesByName
            Project project = new Project(dataDir + "project-sort.mpp");

            List<Resource> resources = project.Resources.ToList();
            resources.Sort(new RscNameComparer());

            foreach (Resource rsc in resources)
            {
                Console.WriteLine(rsc);
            }
            // ExEnd:SortResourcesByName
        }

        // ExStart:ImplementIComparer
        private class RscNameComparer : IComparer<Resource>
        {
            public int Compare(Resource x, Resource y)
            {
                if (string.IsNullOrEmpty(x.Get(Rsc.Name)))
                    return 1;
                if (string.IsNullOrEmpty(y.Get(Rsc.Name)))
                    return -1;
                return x.Get(Rsc.Name).CompareTo(y.Get(Rsc.Name));
            }
        }
        // ExEnd:ImplementIComparer
    }
}
