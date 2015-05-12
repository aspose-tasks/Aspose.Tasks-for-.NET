'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports System

Namespace WritingUpdatedExtendedAttributeDefinitionsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim newFile As String = dataDir & "project.mpp"
			Dim resultFile As String = dataDir & "Output.mpp"

			Dim project As New Project(dataDir & "project.mpp")

'			#Region "task attributes"
			' Add new text3 extended attribute and one text value
			Dim taskTextAttr As New ExtendedAttributeDefinition()
			taskTextAttr.Alias = "New text3 attribute"
			taskTextAttr.FieldName = "Text3"
			taskTextAttr.ElementType = ElementType.Task
			taskTextAttr.CfType = CustomFieldType.Text

			project.ExtendedAttributes.Add(taskTextAttr)

			Dim textVal As New Value()
			textVal.Id = 1
			textVal.Description = "Text value descr"
			textVal.Val = "Text value1"

			taskTextAttr.ValueList.Add(textVal)

			' Add new cost1 extended attribute and two cost values
			Dim taskCostAttr As New ExtendedAttributeDefinition()
			taskCostAttr.Alias = "New cost1 attribute"
			taskCostAttr.FieldName = "Cost1"
			taskCostAttr.ElementType = ElementType.Task
			taskCostAttr.CfType = CustomFieldType.Cost

			project.ExtendedAttributes.Add(taskCostAttr)

			Dim costVal1 As New Value()
			costVal1.Id = 2
			costVal1.Description = "Cost value 1 descr"
			costVal1.Val = "99900"

			Dim costVal2 As New Value()
			costVal2.Id = 3
			costVal2.Description = "Cost value 2 descr"
			costVal2.Val = "11100"

			taskCostAttr.ValueList.Add(costVal1)
			taskCostAttr.ValueList.Add(costVal2)

			' Add new task and assign attribute value
			Dim task As Task = project.RootTask.Children.Add("New task")

			Dim taskAttr As New ExtendedAttribute()
			taskAttr.AttributeDefinition = taskCostAttr
			taskAttr.Value = "99900"
			taskAttr.FieldId = taskCostAttr.FieldId
			task.ExtendedAttributes.Add(taskAttr)

			Dim taskStartAttr As New ExtendedAttributeDefinition()
			taskStartAttr.Alias = "New start 7 attribute"
			taskStartAttr.CfType = CustomFieldType.Start
			taskStartAttr.ElementType = ElementType.Task
			taskStartAttr.FieldName = "Start7"

			Dim startVal As New Value()
			startVal.Val = DateTime.Now.ToString()
			startVal.Description = "Start 7 value description"

			taskStartAttr.ValueList.Add(startVal)

			project.ExtendedAttributes.Add(taskStartAttr)

			Dim taskFinishAttr As New ExtendedAttributeDefinition()
			taskFinishAttr.Alias = "New finish 4 attribute"
			taskFinishAttr.CfType = CustomFieldType.Finish
			taskFinishAttr.ElementType = ElementType.Task
			taskFinishAttr.FieldName = "Finish4"

			Dim finishVal As New Value()
			finishVal.Val = DateTime.Now.ToString()
			finishVal.Description = "Finish 4 value description"

			taskFinishAttr.ValueList.Add(finishVal)

			project.ExtendedAttributes.Add(taskFinishAttr)

			Dim numberAttr As New ExtendedAttributeDefinition()
			numberAttr.Alias = "New number attribute"
			numberAttr.FieldName = "Number20"
			numberAttr.CfType = CustomFieldType.Number
			numberAttr.ElementType = ElementType.Task

			Dim val1 As New Value()
			val1.Val = "1"
			val1.Description = "Number 1 value"
			Dim val2 As New Value()
			val2.Val = "2"
			val2.Description = "Number 2 value"
			Dim val3 As New Value()
			val3.Val = "3"
			val3.Description = "Number 3 value"

			numberAttr.ValueList.Add(val1)
			numberAttr.ValueList.Add(val2)
			numberAttr.ValueList.Add(val3)

			project.ExtendedAttributes.Add(numberAttr)

'			#End Region

			Dim rscStartAttr As New ExtendedAttributeDefinition()
			rscStartAttr.Alias = "New start5 attribute"
			rscStartAttr.FieldName = "Start5"
			rscStartAttr.ElementType = ElementType.Resource
			rscStartAttr.CfType = CustomFieldType.Start

			Dim startVal2 As New Value()
			startVal2.Id = 4
			startVal2.Val = DateTime.Now.ToString()
			startVal2.Description = "this is start5 value descr"

			rscStartAttr.ValueList.Add(startVal2)

			project.ExtendedAttributes.Add(rscStartAttr)


			'Save the project as MPP project file
			project.Save(resultFile, Aspose.Tasks.Saving.SaveFileFormat.MPP)
		End Sub
	End Class
End Namespace