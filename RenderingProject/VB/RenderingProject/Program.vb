Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Aspose.Tasks
Imports Aspose.Tasks.Visualization
Imports System.Collections
Imports System.Drawing

Namespace RenderingProject
	Friend Class Program
		Shared Sub Main(ByVal args As String())
			Dim prg As Program = New Program()

			Dim reader As ProjectReader = New ProjectReader()
			Dim project As Project = reader.Read("./../../Samples/TestViews.mpp")

			'Create the view columns
			Dim columns As ArrayList = New ArrayList()
			columns.Add(New GanttChartColumn("Name", 300, New TaskToColumnTextConverter(AddressOf prg.TaskName)))
			columns.Add(New GanttChartColumn("Notes", 100, New TaskToColumnTextConverter(AddressOf prg.TaskNotes)))
			columns.Add(New GanttChartColumn("Resources", 200, New TaskToColumnTextConverter(AddressOf prg.TaskResources)))

			'Create the view
			Dim view As ProjectView = New ProjectView(columns)

			'Render to image
			Dim res As IRenderResult = project.Export(RenderFormat.Image, PresentationFormat.GanttChart, "./../../Output/Project.png", New BaseImageRenderParam(Nothing, New Point(), New Size(1200, 800), 100, 0, True), True, Nothing, view)

			'Create a new view
			Dim columns2 As ArrayList = New ArrayList()
			columns2.Add(New GanttChartColumn("Name", 300, New TaskToColumnTextConverter(AddressOf prg.TaskNameHtml)))
			columns2.Add(New GanttChartColumn("Notes", 100, New TaskToColumnTextConverter(AddressOf prg.TaskNotes)))
			columns2.Add(New GanttChartColumn("Resources", 200, New TaskToColumnTextConverter(AddressOf prg.TaskResources)))

			'Create the view
			Dim view2 As ProjectView = New ProjectView(columns2)

			'Render to html
			res = project.Export(RenderFormat.Html, PresentationFormat.GanttChart, "./../../Output/Project.html", New BaseImageRenderParam(Nothing, New Point(), New Size(1200, 800), 100, 0, False), True, Nothing, view2)
		End Sub


		''' <summary>
		''' Forms task's name column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskName(ByVal task As Task) As String
			Dim res As StringBuilder = New StringBuilder()
			Dim i As Integer = 1
			Do While i < task.OutlineLevel
				res.Append("  ")
				i += 1
			Loop
			res.AppendFormat("{0}. {1}", task.Id, task.Name)
			Return res.ToString()
		End Function


		''' <summary>
		''' Forms task's name column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskNameHtml(ByVal task As Task) As String
			Dim res As StringBuilder = New StringBuilder()
			Dim i As Integer = 1
			Do While i < task.OutlineLevel
				res.Append("&nbsp;&nbsp;")
				i += 1
			Loop
			res.AppendFormat("{0}. {1}", task.Id, task.Name)
			Return res.ToString()
		End Function


		''' <summary>
		''' Forms task's notes column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskNotes(ByVal task As Task) As String
			If Not task.NotesText Is Nothing Then
				Return task.NotesText
			Else
				Return String.Empty
			End If
		End Function


		''' <summary>
		''' Forms task's resources column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskResources(ByVal task As Task) As String
			Dim res As StringBuilder = New StringBuilder()
			Dim project As Project = task.ParentProject
			Dim bFirst As Boolean = True


			For Each assignment As ResourceAssignment In project.GetResourceAssignmentsByTask(task)
				If Not assignment.Resource Is Nothing Then
					If (Not bFirst) Then
						res.Append(", ")
					End If
					res.Append(assignment.Resource.Name)
					bFirst = False
				End If
			Next assignment
			Return res.ToString()
		End Function
	End Class
End Namespace
