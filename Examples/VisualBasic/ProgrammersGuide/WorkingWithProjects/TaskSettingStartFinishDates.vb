'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports Aspose.Tasks
Imports System

Namespace VisualBasic.Projects
    Public Class TaskSettingStartFinishDates
        ''' <summary>
        ''' By default, the project calculation mode is set to automatic that recalculates everything and sets the dates. 
        ''' If you are creating a new project, it's start date is as of today and rest of the dates are calculated 
        ''' automatically with reference to this start date. 
        ''' </summary>
        Public Shared Sub Run()
            'ExStart: TaskSettingStartFinishDates
            Dim project As New Project()
            Console.WriteLine(project.[Get](Prj.StartDate))
            Console.WriteLine(project.CalculationMode.ToString())

            project.CalculationMode = CalculationMode.None

            Console.WriteLine(project.CalculationMode.ToString())

            Dim task As Task = project.RootTask.Children.Add("Task1")

            task.[Set](Tsk.Start, New DateTime(2012, 8, 1))
            task.[Set](Tsk.Finish, New DateTime(2012, 8, 5))

            Console.WriteLine("*************** Before Recalculate *****************")
            Console.WriteLine(task.[Get](Tsk.Start))
            Console.WriteLine(task.[Get](Tsk.Finish))


            project.Recalculate()

            Console.WriteLine("*************** After Recalculate *****************")
            Console.WriteLine(task.[Get](Tsk.Start))
            Console.WriteLine(task.[Get](Tsk.Finish))

            'ExEnd: TaskSettingStartFinishDates
        End Sub
    End Class
End Namespace
