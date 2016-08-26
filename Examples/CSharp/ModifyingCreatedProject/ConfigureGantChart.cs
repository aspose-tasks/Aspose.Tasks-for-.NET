using System;
using System.Drawing;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class ConfigureGantChart
    {
        public static void Run()
        {
            try
            {
                // ExStart:ConfigureGantChart
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();
                Project project = new Project(dataDir + "Project5.mpp"); // Create a new project task
                Task task = project.RootTask.Children.Add("New Activity");

                // Add custom text attribute to created task.
                ExtendedAttribute attr = new ExtendedAttribute();
                attr.FieldId = ((int)ExtendedAttributeTask.Text1).ToString();
                attr.Value = "Activity attribute";
                task.ExtendedAttributes.Add(attr);

                // Customize table by adding text attribute field
                TableField attrField = new TableField();
                attrField.Field = Field.TaskText1;
                attrField.Width = 20;
                attrField.Title = "Custom attribute";
                attrField.AlignTitle = StringAlignment.Center;
                attrField.AlignData = StringAlignment.Center;

                Table table = project.Tables.ToList()[0];
                table.TableFields.Insert(3, attrField);

                // The result of opening of saved project in MSP2010 is in attached screenshot
                project.Save(dataDir + "ConfigureGantChart_out.mpp", SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:ConfigureGantChart
        }
    }
}