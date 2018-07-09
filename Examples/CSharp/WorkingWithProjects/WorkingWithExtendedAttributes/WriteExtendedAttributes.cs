using System;
using System.Xml;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    public class WriteExtendedAttributes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ExtendedAttributes
            Project prj = new Project(dataDir + "ExtendedAttributes.mpp");
            ExtendedAttributeDefinitionCollection eads = prj.ExtendedAttributes;

            // Create extended attribute definition
            ExtendedAttributeDefinition ead = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Start, ExtendedAttributeTask.Start7, "Start 7");
            eads.Add(ead);

            // Get zero index task
            Task tsk = prj.RootTask.Children.GetById(1);
            ExtendedAttributeCollection eas = tsk.ExtendedAttributes;

            // Add extended attribute
            string dateTimeFormat = "yyyy-MM-ddTHH:mm:ss";
            ExtendedAttribute ea = new ExtendedAttribute();
            ea.FieldId = ead.FieldId;
            ea.Value = XmlConvert.ToString(DateTime.Now, dateTimeFormat);
            eas.Add(ea);
            // ExEnd:ExtendedAttributes
        }
    }
}