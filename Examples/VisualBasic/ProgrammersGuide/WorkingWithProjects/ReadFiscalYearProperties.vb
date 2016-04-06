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
Imports System

Namespace VisualBasic.Projects
	Public Class ReadFiscalYearProperties
        Public Shared Sub Run()
            'ExStart: ReadFiscalYearProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            'Create a project reader instance
            Dim project As New Project(dataDir & "ReadFiscalYearProperties.mpp")

            'Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date : " & project.Get(Prj.FyStartDate).ToString())
            Console.WriteLine("Fiscal Year Numbering : " & project.Get(Prj.FiscalYearStart).ToString())
            'ExEnd: ReadFiscalYearProperties
        End Sub
	End Class
End Namespace