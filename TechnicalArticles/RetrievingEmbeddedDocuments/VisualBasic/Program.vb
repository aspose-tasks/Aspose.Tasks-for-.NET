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
Imports Aspose.Words
Imports Aspose.Words.Drawing

Namespace RetrievingEmbeddedDocumentsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim reader As New ProjectReader()
			Dim project As Project = reader.Read(dataDir & "project.mpp")
			Dim task As Task = project.GetTaskById(1)
			File.WriteAllText(dataDir & "Notes.rtf", task.NotesRTF)
			Dim doc As Document = Nothing
			Using stream As New MemoryStream()
			Using streamWriter As New StreamWriter(stream)
				streamWriter.Write(task.NotesRTF)
				doc = New Document(stream)

			End Using
			End Using
			Dim shapes As NodeCollection = doc.GetChildNodes(NodeType.Shape, True)
			For Each shape As Shape In shapes

				If shape.OleFormat IsNot Nothing Then
					If (Not shape.OleFormat.IsLink) Then
						'Extract OLE Word object
						If shape.OleFormat.ProgId = "Word.Document.12" Then
							Dim stream As New MemoryStream()
							shape.OleFormat.Save(stream)

							Dim newDoc As New Document(stream)
							newDoc.Save(dataDir & "Embedded doc.doc")
						End If
					End If
				End If


			Next shape
		End Sub
	End Class


End Namespace



