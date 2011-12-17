Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.IO
Imports System.Text
Imports Aspose.Tasks.Util

Namespace Aspose.Tasks.ArrangeWBS
	''' <summary>
	''' Setups Roman WBS codes
	''' </summary>
	Friend Class CustomWBSArranger
		Implements ITreeAlgorithm
		' level indexes
		Private levelCounters As ArrayList = New ArrayList()

		' separates codes
		Private separator As Char = ","c

		''' <summary>
		''' Converts integer to Roman number string.
		''' </summary>
		''' <param name="num"></param>
		''' <returns></returns>
		Private Shared Function RomanUCNumbering(ByVal num As Integer) As String
			Dim sb As StringBuilder = New StringBuilder()
			If num >= 1000 Then
				sb.Append("M"c, num / 1000)
				num = num Mod 1000
			End If
			If num >= 900 Then
				sb.Append("CM")
				num -= 900
			End If
			If num >= 500 Then
				sb.Append("D"c)
				num -= 500
			End If
			If num >= 400 Then
				sb.Append("CD")
				num -= 400
			End If
			If num >= 100 Then
				sb.Append("C"c, num / 100)
				num = num Mod 100
			End If
			If num >= 90 Then
				sb.Append("XC")
				num -= 90
			End If
			If num >= 50 Then
				sb.Append("L"c)
				num -= 50
			End If
			If num >= 40 Then
				sb.Append("XL")
				num -= 40
			End If
			If num >= 10 Then
				sb.Append("X"c, num / 10)
				num = num Mod 10
			End If
			If num >= 9 Then
				sb.Append("IX")
				num -= 9
			End If
			If num >= 5 Then
				sb.Append("V"c)
				num -= 5
			End If
			If num >= 4 Then
				sb.Append("IV")
				num -= 4
			End If
			If num >= 1 Then
				sb.Append("I"c, num)
			End If
			Return sb.ToString()
		End Function

		Public Sub New()
			' init level indexes
			levelCounters.Clear()
			For i As Integer = 0 To 9
				levelCounters.Add(0)
			Next i
		End Sub

		''' <summary>
		''' This method increments current level counter in the list of level counters
		''' </summary>
		''' <param name="level"></param>
		Private Sub IncLevelCounter(ByVal level As Integer)
			If level > levelCounters.Count Then
				Return
			Else
				levelCounters(level - 1) = (CInt(Fix(levelCounters(level - 1)))) + 1
			End If
		End Sub

		Public Sub PreAlg(ByVal el As Object, ByVal level As Integer) Implements ITreeAlgorithm.PreAlg
		End Sub

		''' <summary>
		''' 
		''' </summary>
		''' <param name="el"></param>
		''' <param name="level"></param>
		Public Sub Alg(ByVal el As Object, ByVal level As Integer) Implements ITreeAlgorithm.Alg
			' skips zero level
			If level = 0 Then
				Return
			End If
			Dim task As Task = CType(el, Task)
			Dim wbs As String = ""
			IncLevelCounter(level)
			Dim i As Integer = 0
			Do While i < level
				' compose wbs code
				If i > 0 Then
					wbs &= separator
				End If
				wbs &= RomanUCNumbering(CInt(Fix(levelCounters(i))))
				i += 1
			Loop
			task.Wbs = wbs
		End Sub

		Public Sub PostAlg(ByVal el As Object, ByVal level As Integer) Implements ITreeAlgorithm.PostAlg
			If level < levelCounters.Count Then
				levelCounters(level) = 0
			End If
		End Sub
	End Class

	Public Class ArrangeWBS
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
        Shared Sub Main(ByVal args As String())
            args = New String() {"Path to project file"}
            Try
                If args.Length <> 1 Then
                    System.Console.WriteLine("Usage: Aspose.Tasks.ArrangeWBS <input file name>")
                    Console.ReadKey()
                Else
                    ProcessWBS(args(0))
                End If
            Catch ex As System.Exception
                System.Console.WriteLine(ex.StackTrace)
            End Try
            System.Console.WriteLine("Done")
            Console.ReadKey()
        End Sub

		Private Shared Sub ProcessWBS(ByVal fileName As String)
			' reads project from file
			Dim reader As ProjectReader = New ProjectReader()
			Dim project As Project = reader.Read(New FileStream(fileName, FileMode.Open))

			' uses TaskUtils to apply CustomWBSArranger to tasks tree
			TaskUtils.Apply(project.RootTask, New CustomWBSArranger(), 0)

			' writes project
			Dim writer As ProjectWriter = New ProjectWriter()
			writer.Write(project, New FileStream("./../../Output/Output.xml", FileMode.Create), TasksDataFormat.XML)
		End Sub
	End Class
End Namespace
