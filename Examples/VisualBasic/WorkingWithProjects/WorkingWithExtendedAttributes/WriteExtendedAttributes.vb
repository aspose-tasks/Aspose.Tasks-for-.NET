Imports Microsoft.VisualBasic
Imports System
Imports System.Xml
Imports Aspose.Tasks

Namespace WorkingWithProjects.WorkingWithExtendedAttributes
    Public Class WriteExtendedAttributes
        Public Shared Sub Run()
            ' ExStart: ExtendedAttributes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim prj As New Project(dataDir & "ExtendedAttributes.mpp")
            Dim eads As ExtendedAttributeDefinitionCollection = prj.ExtendedAttributes

            ' Create extended attribute definition
            Dim ead As New ExtendedAttributeDefinition()
            ead.FieldId = (CInt(Fix(ExtendedAttributeTask.Start7))).ToString()
            ead.FieldName = "Start7"
            eads.Add(ead)

            ' Get zero index task
            Dim tsk As Task = prj.RootTask.Children.GetById(1)
            Dim eas As ExtendedAttributeCollection = tsk.ExtendedAttributes

            ' Add extended attribute
            Dim dateTimeFormat As String = "yyyy-MM-ddTHH:mm:ss"
            Dim ea As New ExtendedAttribute()
            ea.FieldId = ead.FieldId
            ea.Value = XmlConvert.ToString(DateTime.Now, dateTimeFormat)
            eas.Add(ea)
            ' ExEnd: ExtendedAttributes
        End Sub
    End Class
End Namespace