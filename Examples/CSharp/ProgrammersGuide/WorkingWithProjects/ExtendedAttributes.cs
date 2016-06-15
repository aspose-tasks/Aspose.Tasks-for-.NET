using System.IO;
using Aspose.Tasks;
using System.Xml;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ExtendedAttributes
    {
        public static void Run()
        {
            //Exstart: ExtendedAttributes
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project prj = new Project(dataDir+ "ExtendedAttributes.mpp");
            ExtendedAttributeDefinitionCollection eads = prj.ExtendedAttributes;

            // Create extended attribute definition
            ExtendedAttributeDefinition ead = new ExtendedAttributeDefinition();
            ead.FieldId = ((int)ExtendedAttributeTask.Start7).ToString();
            ead.FieldName = "Start7";
            eads.Add(ead);

            // Get zero index task
            Task tsk = prj.RootTask.Children.GetById(1);
            ExtendedAttributeCollection eas = tsk.ExtendedAttributes;

            string dateTimeFormat = "yyyy-MM-ddTHH:mm:ss";
            ExtendedAttribute ea = new ExtendedAttribute();
            ea.FieldId = ead.FieldId;
            ea.Value = XmlConvert.ToString(DateTime.Now, dateTimeFormat);
            eas.Add(ea);
            //ExEnd: ExtendedAttributes
        }
    }
}