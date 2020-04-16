namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExCheckCircuit : ApiExampleBase
    {
        [Test]
        public void CheckCircuit()
        {
            //ExStart
            //ExFor: CheckCircuit
            //ExFor: CheckCircuit.#ctor
            //ExFor: CheckCircuit.Alg(Task,Int32)
            //ExFor: CheckCircuit.PostAlg(Task,Int32)
            //ExFor: CheckCircuit.PreAlg(Task,Int32)
            //ExSummary: Shows how to detect broken project's structure.
            var project = new Project(DataDir + "ParentChildTasks.mpp");
            
            // check the project's structure.
            // The TasksException will be thrown if the project structure is incorrect.
            TaskUtils.Apply(project.RootTask, new CheckCircuit(), 0);

            //ExEnd
        }
    }
}