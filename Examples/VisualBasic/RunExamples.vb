'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports CSharp.Projects

Imports VisualBasic.Projects

Namespace VisualBasic
    Friend Class RunExamples
        <STAThread> _
        Public Shared Sub Main()
            Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run")
            Console.WriteLine("=====================================================")
            ' Un-comment the one you want to try out

            ' =====================================================
            ' =====================================================
            ' Working With Projects
            ' =====================================================
            ' =====================================================

            CalculateCriticalPath.Run()
            'CreateEmptyProjectSaveXML.Run()
            'DefaultProperties.Run()
            'DetermineProjectVersion.Run()
            'ExtendedAttributes.Run()
            'GetNumberOfPages.Run()
            'GetNumberOfPagesForViews.Run()
            'GetObjectByFieldMethods.Run()
            'MPPFileUpdate.Run()
            'PrintTaskWritingException.Run()
            'ReadCurrencyProperties.Run()
            'ReadFiscalYearProperties.Run()
            'ReadProjectFiles.Run()
            'ReadProjectInfo.Run()
            'ReadWeekdayProperties.Run()
            'ReplaceCalendar.Run()
            'RetrieveCalendarInfo.Run()
            'SetAttributesForNewTasks.Run()
            'WriteCurrencyProperties.Run()
            'WriteFiscalYearProperties.Run()
            'WriteMPPProjectSummary.Run()
            'WriteProjectInfo.Run()
            'WriteUpdatedExtendedAttributeDefinitions.Run()
            'WriteWeekdayProperties.Run()

            ' =====================================================
            ' =====================================================
            ' Working With VBA Examples 
            ' =====================================================
            ' =====================================================

            'ReadVBAProjectInformation.Run()
            'ReadReferencesInformation.Run()
            'ReadModulesInformation.Run()
            'ReadModuleAttributesInforamtion.Run()


            ' Stop before exiting
            Console.WriteLine(Constants.vbLf + Constants.vbLf & "Program Finished. Press any key to exit....")
            Console.ReadKey()
        End Sub

        Public Shared Function GetDataDir_Projects() As String
            Return Path.GetFullPath("../../ProgrammersGuide/WorkingWithProjects/Data/")
        End Function

    End Class
End Namespace