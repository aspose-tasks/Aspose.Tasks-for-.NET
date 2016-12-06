using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

                ExtendedAttributeDefinition myText1Def = null;

                // If the Custom field doesn't exist in Project, create it
                if (project1.ExtendedAttributes.GetById(Convert.ToInt32(ExtendedAttributeTask.Text1.ToString("D"))) == null)
                {
                    myText1Def = new ExtendedAttributeDefinition();
                    myText1Def.Alias = "MyValue";
                    myText1Def.CfType = CustomFieldType.Number;
                    myText1Def.FieldId = ExtendedAttributeTask.Text1.ToString("D");
                    project1.ExtendedAttributes.Add(myText1Def);
                }
                else
                    myText1Def = project1.ExtendedAttributes.GetById(Convert.ToInt32(ExtendedAttributeTask.Number1.ToString("D")));

                // Generate Extended Attribute from definition
                ExtendedAttribute text1TaskAttr = myText1Def.CreateExtendedAttribute();
                text1TaskAttr.Value = "20.55";

                // Add extended attribute to task
                Task tsk = project1.RootTask.Children.Add("Task 1");
                tsk.ExtendedAttributes.Add(text1TaskAttr);

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
