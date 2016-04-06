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

Namespace VisualBasic.Projects
	Public Class WriteCurrencyProperties
        Public Shared Sub Run()
            'Exstart: WriteCurrencyProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            'Create a project instance
            Dim project As New Project(dataDir & "WriteCurrencyProperties.mpp")

            'Set currency properties
            project.Set(Prj.CurrencyCode, "AUD")
            project.Set(Prj.CurrencyDigits, 2)
            project.Set(Prj.CurrencySymbol, "$")
            project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.After)

            'Save the project as XML project file
            project.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
            'ExEnd: WriteCurrencyProperties
        End Sub
	End Class
End Namespace