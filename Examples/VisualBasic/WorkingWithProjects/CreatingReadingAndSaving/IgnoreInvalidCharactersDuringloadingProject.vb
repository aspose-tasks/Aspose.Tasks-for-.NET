Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class IgnoreInvalidCharactersDuringloadingProject
        ' ExStart:IgnoreInvalidCharactersDuringloadingProject 
        Public Shared Sub Run()
            ' Open modified xml stream
            Using stream As New MemoryStream(Encoding.UTF8.GetBytes(GetModifiedXml()))
                Dim project As New Project(stream, New ParseErrorCallback(AddressOf CustomDurationHandler))
            End Using
        End Sub

        Private Shared Function GetModifiedXml() As String
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim xml As String

            ' Open valid xml file and modify it
            Using reader As TextReader = New StreamReader(dataDir & Convert.ToString("Project.xml"))
                xml = reader.ReadToEnd()
            End Using

            Dim regex As New Regex("PT(\d+)H(\d+)M(\d+)S")
            Return regex.Replace(xml, "**$1Hrs$2Mins$3Secs**")
        End Function

        Private Shared Function CustomDurationHandler(sender As Object, args As ParseErrorArgs) As Object
            Dim regex As New Regex("[*]{2}(\d+)Hrs(\d+)Mins(\d+)Secs[*]{2}")
            If args.FieldType = GetType(TimeSpan) Then
                Debug.Print("Object field : {0}, Invalid value : {1}", args.FieldName, args.InvalidValue)
                Dim duration__1 As String = regex.Replace(args.InvalidValue, "PT$1H$2M$3S")
                Dim newValue As TimeSpan = Duration.ParseTimeSpan(duration__1)
                Debug.Print("New value : {0}", newValue)
                Return newValue
            End If
            ' Here we handle only TimeSpan instances, so rethrow original exception with other types
            Throw args.Exception
        End Function
        ' ExEnd:IgnoreInvalidCharactersDuringloadingProject
    End Class
End Namespace