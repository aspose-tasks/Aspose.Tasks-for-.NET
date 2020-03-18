namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System;
    using System.Collections.Generic;

    internal class SortResourcesByName
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SortResourcesByName
            var project = new Project(dataDir + "project-sort.mpp");

            List<Resource> resources = project.Resources.ToList();
            resources.Sort(new RscNameComparer());

            foreach (var rsc in resources)
            {
                Console.WriteLine(rsc);
            }
            //ExEnd:SortResourcesByName
        }

        //ExStart:ImplementIComparer
        private class RscNameComparer : IComparer<Resource>
        {
            public int Compare(Resource x, Resource y)
            {
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
        //ExEnd:ImplementIComparer
    }
}
