'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks

Namespace VisualBasic.Projects
	Public Class GetNumberOfPages
        Public Shared Sub Run()
            'ExStart: GetNumberOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()



            'Read the input Project file
            Dim project As New Project(dataDir & "GetNumberOfPages.mpp")

            'Get number of pages
            Dim iPages As Integer = project.GetPageCount()

            'Get number of pages (Timescale.Months)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months)

            'Get number of pages (Timescale.ThirdsOfMonths)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths)
            'ExEnd: GetNumberOfPages
        End Sub
	End Class
End Namespace