Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization
Imports System.Drawing

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class ImplementCustomBarStyleWriting
        Public Shared Sub Run()
            ImplementCustomBarSytle()
        End Sub

        ' ExStart:ImplementCustomBarStyleWriting
        Private Shared Sub ImplementCustomBarSytle()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                Dim project As New Project(dataDir & "Blank2010.mpp")
                project.RootTask.Children.Add("Task")

                Dim view As GanttChartView = TryCast(project.DefaultView, GanttChartView)
                Dim [custom] As GanttBarStyle = GetCustomBarStyle()

                ' Add the custom bar style to the custom bar collection of the project view
                view.CustomBarStyles.Add([custom])

                Dim file As String = "ImplementCustomBarStyleWriting_out.mpp"

                Dim options As New MPPSaveOptions()
                options.WriteViewData = True

                project.Save(dataDir & file, options)
            Catch ex As NotSupportedException
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub

        Private Shared Function GetCustomBarStyle() As GanttBarStyle
            Dim style As New GanttBarStyle()
            style.ShowFor = "1"
            style.MiddleShape = GanttBarMiddleShape.RectangleBottom
            style.MiddleFillPattern = GanttBarFillPattern.MediumFill
            style.MiddleShapeColor = Color.Blue

            style.StartShape = GanttBarEndShape.ArrowDown
            style.StartShapeColor = Color.Red

            style.EndShape = GanttBarEndShape.ArrowUp
            style.EndShapeColor = Color.Yellow

            style.LeftField = Field.TaskResourceNames
            style.RightField = Field.TaskName
            style.TopField = Field.TaskStart
            style.BottomField = Field.TaskFinish
            style.InsideField = Field.TaskDuration

            Return style
        End Function
        ' ExEnd:ImplementCustomBarStyleWriting
    End Class
End Namespace