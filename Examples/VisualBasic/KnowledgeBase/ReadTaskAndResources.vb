
Namespace KnowledgeBase
    Public Class ReadTaskAndResources
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadTaskAndResources
            ' Load MPP file
            Dim project As New Project(dataDir & "Project1.mpp")

            ' Load all tasks
            Dim allTasks As TaskCollection = project.RootTask.Children

            ' Loop through each task and read information related to tasks
            For Each task As Task In allTasks
                Console.WriteLine("Reading Task " & task.[Get](Tsk.Name))
                Console.WriteLine(vbLf & "ID: " & task.[Get](Tsk.Id))
                Console.WriteLine("Start: " & task.[Get](Tsk.Start))
                Console.WriteLine("Finish: " & task.[Get](Tsk.Finish))
                Console.WriteLine(vbLf & "===========================" & vbLf)
            Next

            ' Loop through each resource and read information related to resources
            For Each resource As Resource In project.Resources
                'INSTANT VB NOTE: The local variable resourceType was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
                Dim resourceType_Renamed As String = Nothing
                Select Case resource.[Get](Rsc.Type)
                    Case ResourceType.Material
                        resourceType_Renamed = "Material"
                    Case ResourceType.Work
                        resourceType_Renamed = "Work"
                    Case Else
                        resourceType_Renamed = "Cost"
                End Select

                Console.WriteLine("Reading Resource " & resource.[Get](Rsc.Name))
                Console.WriteLine(Constants.vbLf & "ID: " & resource.[Get](Rsc.Id))
                Console.WriteLine("Type: " & resourceType_Renamed)
                Console.WriteLine(Constants.vbLf & "===========================" & Constants.vbLf)
            Next resource
            ' ExEnd:ReadTaskAndResources
        End Sub
    End Class
End Namespace