/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    using Aspose.Tasks.Saving;

    internal class SetResourceExtendedAttributes
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:SetResourceExtendedAttributes
                // Create project instance
                var project = new Project(dataDir + "ResourceExtendedAttributes.mpp");

                // Define extended attribute
                var myNumber1 = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Number1);
                if (myNumber1 == null)
                {
                    myNumber1 = ExtendedAttributeDefinition.CreateResourceDefinition(ExtendedAttributeResource.Number1, "Age");
                    project.ExtendedAttributes.Add(myNumber1);
                }

                // Create extended attribute and set its value
                var number1Resource = myNumber1.CreateExtendedAttribute();
                number1Resource.NumericValue = 30.5345m;

                // Add a new resource and its extended attribute   
                var rsc = project.Resources.Add("R1");
                rsc.ExtendedAttributes.Add(number1Resource);

                // Save project as MPP
                project.Save(dataDir + "ResourceExtendedAttributes_out.mpp", SaveFileFormat.MPP);
                //ExEnd:SetResourceExtendedAttributes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
