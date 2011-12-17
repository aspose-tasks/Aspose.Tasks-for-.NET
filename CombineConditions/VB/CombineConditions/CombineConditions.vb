Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports Aspose.Tasks.Util

Namespace Aspose.Tasks.CombineConditions
    ''' <summary>
    ''' This example shows how to combine some conditions.
    ''' </summary>
    Friend Class CombineConditions
        ''' <summary>
        ''' Main method
        ''' </summary>
        <STAThread()> _
        Shared Sub Main(ByVal args As String())
            ' Provide path to project file, name of the task you want to search 
            ' and smallest id i.e. searching will be performed on tasks with greater id than this smallest id
            args = New String() {"Path to project file", "Name of the task to find", "Smallest id for condition"}
            Try
                If args.Length <> 3 Then
                    System.Console.WriteLine("Usage: Aspose.Tasks.CombineConditions <input file name> <taskName> <task id>")
                Else
                    Filter(args(0), args(1), args(2))
                End If
            Catch ex As System.Exception
                System.Console.WriteLine(ex.StackTrace)
            End Try
            Console.ReadKey()
        End Sub

        Private Shared Sub Filter(ByVal fileName As String, ByVal taskName As String, ByVal taskID As String)
            ' reads project from file
            Dim reader As ProjectReader = New ProjectReader()
            Dim project As Project = reader.Read(New FileStream(fileName, FileMode.Open))

            ' find task
            Dim task As Task = New Task()
            task = TaskUtils.Find(project.RootTask, New Aspose.Tasks.Util.And(New NameCondition(taskName), New MoreThanIDCondition(Int32.Parse(taskID))))

            ' Prints task parameters
            If Not task Is Nothing Then
                Console.WriteLine("Name   : " & task.Name)
                Console.WriteLine("UID    : " & task.Uid)
                Console.WriteLine("ID     : " & task.Id)
                Console.WriteLine("Start  : " & task.Start)
                Console.WriteLine("Finish : " & task.Finish)
            End If
        End Sub

        ''' <summary>
        ''' Define find condition. Method Check() of this class returns true if task name starts with the pattern otherwise returns false;
        ''' </summary>
        Private Class NameCondition
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

        ''' <summary>
        ''' Method Check() of this class returns true if task has id more than initial id
        ''' </summary>
        Private Class MoreThanIDCondition
            Implements ICondition
            Private id As Integer

            Public Sub New(ByVal id As Integer)
                Me.id = id
            End Sub

            Public Function Check(ByVal el As Object) As Boolean Implements ICondition.Check
                Dim task As Task = CType(el, Task)
                Return task.Id > id
            End Function
        End Class
    End Class
End Namespace