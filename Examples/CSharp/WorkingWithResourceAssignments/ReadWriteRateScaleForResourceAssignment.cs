/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/
namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    using Aspose.Tasks.Saving;

    internal class ReadWriteRateScaleForResourceAssignment
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart: ReadWriteRateScaleForResourceAssignment
            var project = new Project(dataDir + "New project 2013.mpp");

            var task = project.RootTask.Children.Add("t1");

            var materialResource = project.Resources.Add("materialResource");
            materialResource.Set(Rsc.Type, ResourceType.Material);

            var nonMaterialResource = project.Resources.Add("nonMaterialResource");
            nonMaterialResource.Set(Rsc.Type, ResourceType.Work);

            var materialResourceAssignment = project.ResourceAssignments.Add(task, materialResource);
            materialResourceAssignment.Set(Asn.RateScale, RateScaleType.Week);

            var nonMaterialResourceAssignment = project.ResourceAssignments.Add(task, nonMaterialResource);
            nonMaterialResourceAssignment.Set(Asn.RateScale, RateScaleType.Week);

            project.Save("output.mpp", SaveFileFormat.MPP);

            var resavedProject = new Project("output.mpp");

            var resavedMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(1);
            Console.WriteLine(resavedMaterialResourceAssignment.Get(Asn.RateScale));

            // only material resource assignments can have non-zero rate scale value.
            resavedProject.ResourceAssignments.GetByUid(2);
            //ExEnd: ReadWriteRateScaleForResourceAssignment
        }
    }
}
