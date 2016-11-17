Imports Aspose.Tasks.Saving
Imports Aspose.Tasks

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Class MoveTaskUnderAnotherParent
        Public Shared Sub Run()
            Try
                ' ExStart:MoveTaskUnderAnotherParent
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' Loading project file
                Dim project As New Project(dataDir & Convert.ToString("MoveTask.mpp"))

                ' Set CalculationMode
                project.CalculationMode = CalculationMode.Automatic

                ' Get Tasks by Ids
                Dim t6 As Task = project.RootTask.Children.GetByUid(6)
                Dim t3 As Task = project.RootTask.Children.GetByUid(3)

                ' Adding Task 6 to another parent
                t3.Children.Add(t6)

                ' Saving File To Disk
                project.Save(dataDir & Convert.ToString("MoveTaskUnderAnotherParent_out.mpp"), SaveFileFormat.MPP)
                ' ExEnd:MoveTaskUnderAnotherParent
            Catch exception As Exception
                Console.WriteLine(exception.Message + vbLf & "This example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
