namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExITreeAlgorithm : ApiExampleBase
    {
        // ExStart
        // ExFor: Util.ITreeAlgorithm`1
        // ExFor: Util.ITreeAlgorithm`1.Alg(`0,System.Int32)
        // ExFor: Util.ITreeAlgorithm`1.PostAlg(`0,System.Int32)
        // ExFor: Util.ITreeAlgorithm`1.PreAlg(`0,System.Int32)
        // ExSummary: Shows how to use <see cref="Aspose.Tasks.Util.ITreeAlgorithm`1" /> tree based algorithm.
        [Test] // ExSkip
        public void WorkWithITreeAlgorithm()
        {
            var project = new Project(DataDir + "Project1.mpp");

            var root = project.RootTask.Children.Add("Project Management");
            var summary = root.Children.Add("Manage iteration");

            var task = summary.Children.Add("Acquire staff");
            task.Set(Tsk.Start, new DateTime(1999, 5, 3, 9, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8 * 14, TimeUnitType.Hour));
            task.Set(Tsk.DurationFormat, TimeUnitType.Day);
            task.Set(Tsk.Finish, project.Get(Prj.Calendar).GetFinishDateByStartAndWork(task.Get(Tsk.Start), task.Get(Tsk.Duration)));

            var resource = project.Resources.Add("Project Manager");
            resource.Set(Rsc.Type, ResourceType.Work);

            project.ResourceAssignments.Add(task, resource);

            // use tree algorithm to gather common work and update work 
            var acc = new WorkAccumulator();
            TaskUtils.Apply(summary, acc, 0);

            var summaryWork = acc.Work.ToDouble();
            summary.Set(Tsk.Work, project.GetWork(summaryWork));
            summary.Set(Tsk.RemainingWork, project.GetWork(summaryWork));

            // ...
        }

        private class WorkAccumulator : ITreeAlgorithm<Task>
        {
            /// <summary>Initializes a new instance of the <see cref="WorkAccumulator" /> class.</summary>
            public WorkAccumulator()
            {
                this.Work = new Duration();
            }

            public Duration Work { get; private set; }

            public void PreAlg(Task el, int level)
            {
                // there is nothing to do in pre algorithm steps
            }

            public void Alg(Task el, int level)
            {
                if (!el.Get(Tsk.IsSummary))
                {
                    this.Work.Add(el.Get(Tsk.Work));
                }
            }

            public void PostAlg(Task el, int level)
            {
                // there is nothing to do in post algorithm steps
            }
        }

        // ExEnd
    }
}