//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Xml;
using System;

namespace ExtendedAttributesExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Project prj = new Project(dataDir+ "project.mpp");
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
        }
    }
}