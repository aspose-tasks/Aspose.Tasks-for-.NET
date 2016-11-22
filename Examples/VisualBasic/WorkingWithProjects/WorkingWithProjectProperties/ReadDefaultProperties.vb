Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class ReadDefaultProperties
        Public Shared Sub Run()
            ' ExStart: DefaultProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project
            Dim project As New Project(dataDir & "DefaultProperties.mpp")

            ' Display default properties
            Console.WriteLine("New Task Default Start: " + project.[Get](Prj.DefaultStartTime).ToShortDateString())
            Console.WriteLine("New Task Default Type:" + project.[Get](Prj.DefaultTaskType).ToString())
            Console.WriteLine("Resouce Default Standard Rate: " + project.[Get](Prj.DefaultStandardRate).ToString())
            Console.WriteLine("Resource Default Overtime Rate: " + project.[Get](Prj.DefaultOvertimeRate).ToString())
            Console.WriteLine("Default Task EV Method: " + project.[Get](Prj.DefaultTaskEVMethod).ToString())
            Console.WriteLine("Default Cost Accrual: " + project.[Get](Prj.DefaultFixedCostAccrual).ToString())
            ' ExEnd: DefaultProperties
        End Sub
    End Class
End Namespace