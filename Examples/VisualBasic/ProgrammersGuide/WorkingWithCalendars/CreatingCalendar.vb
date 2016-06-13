'''///////////////////////////////////////////////////////////////////////
' Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'''///////////////////////////////////////////////////////////////////////
Imports System
Imports Aspose.Tasks
Imports VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Examples.ProgrammersGuide.WorkingWithCalendars
    Class CreatingCalendar
        Public Shared Sub Run()
            'ExStart: CreatingCalendar
            'New calendar can be added to a project's calendar collection using the collection's Add method.

            'Create a project instance
            Dim project As New Project()

            'Define Calendar
            Dim cal1 As Aspose.Tasks.Calendar = project.Calendars.Add("New Info")
            Dim cal2 As Aspose.Tasks.Calendar = project.Calendars.Add("no name")
            Dim cal3 As Aspose.Tasks.Calendar = project.Calendars.Add("cal3")

            'Save the Project
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            project.Save(dataDir & Convert.ToString("Project.Xml"), Aspose.Tasks.Saving.SaveFileFormat.XML)
            'ExEnd: CreatingCalendar
        End Sub
    End Class
End Namespace
