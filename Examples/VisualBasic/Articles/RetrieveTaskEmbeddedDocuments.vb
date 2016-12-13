Imports Aspose.Words
Imports System.IO

Namespace Articles
    Public Class RetrieveTaskEmbeddedDocuments
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:RetrieveTaskEmbeddedDocuments
            Dim project As New Project(dataDir & "TaskEmbeddedDocuments.mpp")
            Dim task As Task = project.RootTask.Children.GetById(1)

            File.WriteAllText(dataDir & "Notes_out.rtf", task.[Get](Tsk.NotesRTF))

            Dim doc As Document = Nothing
            Using stream As New MemoryStream()
                Using streamWriter As New StreamWriter(stream)
                    streamWriter.Write(task.[Get](Tsk.NotesRTF))
                    doc = New Document(stream)
                End Using
            End Using

            Dim shapes As NodeCollection = doc.GetChildNodes(NodeType.Shape, True)
            For Each shape As Aspose.Words.Drawing.Shape In shapes
                If shape.OleFormat IsNot Nothing Then
                    If Not shape.OleFormat.IsLink Then
                        ' Extract OLE Word object
                        If shape.OleFormat.ProgId = "Word.Document.12" Then
                            Dim stream As New MemoryStream()
                            shape.OleFormat.Save(stream)

                            Dim newDoc As New Document(stream)
                            newDoc.Save(dataDir & "RetrieveTaskEmbeddedDocuments_out.doc")
                        End If
                    End If
                End If
            Next
            ' ExEnd:RetrieveTaskEmbeddedDocuments
        End Sub
    End Class
End Namespace