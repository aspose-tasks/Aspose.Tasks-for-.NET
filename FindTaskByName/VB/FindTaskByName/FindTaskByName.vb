Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports Aspose.Tasks.Util

Namespace Aspose.Tasks.FindTaskByName
	''' <summary>
	''' This example shows how to combine some conditions.
	''' </summary>
	Friend Class FindTaskByName
		''' <summary>
		''' Main method
		''' </summary>
        <STAThread()> _
        Shared Sub Main(ByVal args As String())
            ' Provide path to project file, name of the task you want to search 
            args = New String() {"Path to project file", "Name of the task to find"}
            Try
                If args.Length <> 2 Then
                    System.Console.WriteLine("Usage: Aspose.Tasks.FindByName <input file name> <taskName>")
                Else
                    Find(args(0), args(1))
                End If
            Catch ex As System.Exception
                System.Console.WriteLine(ex.StackTrace)
            End Try
            Console.ReadKey()
        End Sub

		''' <summary>
		''' Finds taks by name and prinst task name, uid, id, date start and date end
		''' </summary>
		''' <param name="fileName"></param>
		''' <param name="taskName"></param>
        Private Shared Sub Find(ByVal fileName As String, ByVal taskName As String)
            ' reads project from file
            Dim reader As ProjectReader = New ProjectReader()
            Dim project As Project = reader.Read(New FileStream(fileName, FileMode.Open))

            ' Searching task
            Dim task As Task = TaskUtils.Find(project.RootTask, New NameCondition(taskName))

            ' Prints task parameters
            If Not task Is Nothing Then
                Console.WriteLine("Name   : " & task.Name)
                Console.WriteLine("UID    : " & task.Uid)
                Console.WriteLine("ID     : " & task.Id)
                Console.WriteLine("Start  : " & task.Start)
                Console.WriteLine("Finish : " & task.Finish)
            End If
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