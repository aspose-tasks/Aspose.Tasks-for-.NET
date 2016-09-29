Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ReadingData
    Public Class ReadTableDataFromProjectFile
        Public Shared Sub Run()
            ' ExStart:ReadTableDataFromProjectFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ReadingData()
            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
            Dim task1 As Table = project.Tables.ToList()(0)
            Console.WriteLine("Table Fields Count" + task1.TableFields.Count.ToString())
            Dim tableField As TableField = task1.TableFields(0)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(1)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(2)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(3)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(4)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(5)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(6)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            tableField = task1.TableFields(7)
            Console.WriteLine("Field width: " + tableField.Width.ToString())
            Console.WriteLine("Field Title: " + tableField.Title)
            Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString())
            Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString())
            ' ExEnd:ReadTableDataFromProjectFile
        End Sub
    End Class
End Namespace