'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports System

Namespace VisualBasic.Projects
	Public Class DefaultProperties
        Public Shared Sub Run()
            'ExStart: DefaultProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            Dim prj__1 As New Project(dataDir & "DefaultProperties.mpp")

            'Display default properties
            'Display default properties
            Console.WriteLine("New Task Default Start: " + prj__1.[Get](Prj.DefaultStartTime).ToShortDateString())
            Console.WriteLine("New Task Default Type:" + prj__1.[Get](Prj.DefaultTaskType))
            Console.WriteLine("Resouce Default Standard Rate: " + prj__1.[Get](Prj.DefaultStandardRate).ToString())
            Console.WriteLine("Resource Default Overtime Rate: " + prj__1.[Get](Prj.DefaultOvertimeRate).ToString())
            Console.WriteLine("Default Task EV Method: " + prj__1.[Get](Prj.DefaultTaskEVMethod).ToString())
            Console.WriteLine("Default Cost Accrual: " + prj__1.[Get](Prj.DefaultFixedCostAccrual).ToString())
            'ExEnd: DefaultProperties
        End Sub
	End Class
End Namespace