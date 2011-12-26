Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports Aspose.Tasks.Util

Namespace Aspose.Tasks.FilterTasksByName
	''' <summary>
	''' This example shows how to combine some conditions.
	''' </summary>
	Friend Class FilterTasksByName
		''' <summary>
		''' Main method
		''' </summary>
        <STAThread()> _
        Shared Sub Main(ByVal args As String())
            ' Provide path to project file and name of the task you want to filter 
            args = New String() {"Path to project file", "Name of the task to filter"}
            Try
                If args.Length <> 2 Then
                    System.Console.WriteLine("Usage: Aspose.Tasks.FindByName <input file name> <taskName>")
                Else
                    Filter(args(0), args(1))
                End If
            Catch ex As System.Exception
                System.Console.WriteLine(ex.StackTrace)
            End Try
            Console.ReadKey()
        End Sub

		Private Shared Sub Filter(ByVal fileName As String, ByVal pattern As String)
			' reads project from file
			Dim reader As ProjectReader = New ProjectReader()
			Dim project As Project = reader.Read(New FileStream(fileName, FileMode.Open))

			' filter tasks
			Dim newRoot As Task = TaskUtils.Filter(project.RootTask, New NameCondition(pattern))
			' print tasks
			TaskUtils.Apply(newRoot, New TreePrinter(), 0)
		End Sub
	End Class

	Friend Class TreePrinter
		Implements ITreeAlgorithm
		Private indent As String = ""

		''' <summary>
		''' Increase indent
		''' </summary>
		''' <param name="el"></param>
		''' <param name="index"></param>
		Public Sub PreAlg(ByVal el As Object, ByVal index As Integer) Implements ITreeAlgorithm.PreAlg
			indent = indent & " "
		End Sub


		Public Sub Alg(ByVal el As Object, ByVal index As Integer) Implements ITreeAlgorithm.Alg
			Dim task As Task = CType(el, Task)
			Console.WriteLine(String.Format("{0,4:#####}", task.Uid) & indent & task.Name)
		End Sub

		''' <summary>
		''' Decrease indent
		''' </summary>
		''' <param name="el"></param>
		''' <param name="index"></param>
		Public Sub PostAlg(ByVal el As Object, ByVal index As Integer) Implements ITreeAlgorithm.PostAlg
			indent = indent.Substring(0, indent.Length - 1)
		End Sub
	End Class

	''' <summary>
	''' Define find condition. Method Check() of this class returns true if task name starts with the pattern otherwise returns false;
	''' </summary>
	Friend Class NameCondition
		Implements ICondition
		Private pattern As String

		Public Sub New(ByVal pattern As String)
			Me.pattern = pattern
		End Sub

		Public Function Check(ByVal el As Object) As Boolean Implements ICondition.Check
			Dim task As Task = CType(el, Task)
			If Not task.Name Is Nothing Then
				Return task.Name.StartsWith(pattern)
			End If
			Return False
		End Function
	End Class
End Namespace