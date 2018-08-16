using Aspose.Tasks.Saving;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    class CreateExtendedAttributes
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:CreateExtendedAttributes  
                Project project1 = new Project(dataDir + "Blank2010.mpp");

                ExtendedAttributeDefinition myTextAttributeDefinition = project1.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Text1);

                // If the Custom field doesn't exist in Project, create it
                if (myTextAttributeDefinition == null)
                {
                    myTextAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, "My text field");
                    project1.ExtendedAttributes.Add(myTextAttributeDefinition);
                }

                // Generate Extended Attribute from definition
                ExtendedAttribute text1TaskAttribute = myTextAttributeDefinition.CreateExtendedAttribute();

                text1TaskAttribute.TextValue = "Text attribute value";

                // Add extended attribute to task
                Task tsk = project1.RootTask.Children.Add("Task 1");
                tsk.ExtendedAttributes.Add(text1TaskAttribute);

                project1.Save(dataDir + "CreateExtendedAttributes_out.mpp", SaveFileFormat.MPP);
                // ExEnd:CreateExtendedAttributes
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
