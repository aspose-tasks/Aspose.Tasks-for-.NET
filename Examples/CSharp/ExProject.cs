namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using Connectivity;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1600", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Reviewed. Suppression is OK here.")]
    public class ExProject : ApiExampleBase
    {
        [Test]
        public void SaveProjectOverviewReport()
        {
            // ExStart:SaveProjectOverviewReport
            // ExFor: Project.SaveReport(String)
            // ExSummary: Shows how to save the project overview report to PDF file into a stream.
            var project = new Project(DataDir + "Cyclic stucture.mpp");

            // one can save the overview report to PDF file to the specified path
            project.SaveReport(OutDir + "SaveProjectOverviewReport_out.pdf");

            // ExEnd:SaveProjectOverviewReport
        }

        [Test]
        public void SaveProjectOverviewReport2()
        {
            // ExStart:SaveProjectOverviewReportStream
            // ExFor: Project.SaveReport(Stream)
            // ExSummary: Shows how to save the project overview report to PDF file.
            var project = new Project(DataDir + "Cyclic stucture.mpp");

            // save the overview report to PDF file to the specified stream.
            using (var stream = new FileStream(OutDir + "SaveProjectOverviewReport_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream);
            }

            // ExEnd:SaveProjectOverviewReportStream
        }

        [Test, Explicit("Too long time running.")]
        public void SaveProjectOverviewReport3()
        {
            // ExStart:SaveProjectOverviewReportStream
            // ExFor: Project.SaveReport(Stream,ReportType)
            // ExSummary: Shows how to save the project report to PDF file for specific report type.
            var project = new Project(DataDir + "Cyclic stucture.mpp");

            // save the overview report to PDF file to the specified stream.
            using (var stream = new FileStream(OutDir + "SaveProjectOverviewReport_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.Burndown);
            }

            // ExEnd:SaveProjectOverviewReportStream
        }

        [Test]
        public void GetDefaultDurationFromProject1()
        {
            // ExStart:GetDefaultDurationFromProject
            // ExFor: Project.GetDuration(Double)
            // ExSummary: Shows how to create a <see cref="Aspose.Tasks.Duration" /> instance with default project's duration format by using project fabric methods.
            var project = new Project();

            // get a duration with default project format.
            var duration = project.GetDuration(1);

            Console.WriteLine("Default project duration time unit type: " + project.Get(Prj.DurationFormat));
            Console.WriteLine("Created duration time unit type: " + duration.TimeUnit);

            // ExEnd:GetDefaultDurationFromProject
        }

        [Test]
        public void GetDefaultDurationFromProject2()
        {
            // ExStart:GetDefaultDurationFromProject
            // ExFor: Project.GetDuration(Double,TimeUnitType)
            // ExSummary: Shows how to create a <see cref="Aspose.Tasks.Duration" /> instance by using project fabric methods.
            var project = new Project();

            // get a duration with default project format.
            var duration = project.GetDuration(1, TimeUnitType.Minute);

            Console.WriteLine("Created duration: " + duration);

            // ExEnd:GetDefaultDurationFromProject
        }

        [Test]
        public void GetWorkWithDefaultProjectFormat()
        {
            // ExStart:GetWorkWithDefaultProjectFormat
            // ExFor: Project.GetWork(Double)
            // ExSummary: Shows how to get a work with default work format.
            var project = new Project(DataDir + "Blank2010.mpp");

            Console.WriteLine("Project's work format: " + project.Get(Prj.WorkFormat));

            // create a work value with project's default work format
            var work = project.GetWork(2);
            Console.WriteLine("Work: " + work.TimeSpan);
            Console.WriteLine("Time unit: " + work.TimeUnit);

            // ExEnd:GetWorkWithDefaultProjectFormat
        }

        [Test]
        public void ProjectCopyToTest()
        {
            // ExStart:ProjectCopying
            // ExFor: Project.CopyTo(Project)
            // ExSummary: Shows how to copy the project data to another project.
            var project = new Project(DataDir + "CopyToProjectEmpty.xml");
            File.Copy(DataDir + "CopyToProjectEmpty.mpp", DataDir + "ProjectCopying_out.mpp", true);

            var mppProject = new Project(DataDir + "ProjectCopying_out.mpp");

            // skip copying of view data while copying common project data.
            project.CopyTo(mppProject);

            // ExEnd:ProjectCopying
        }

        [Test]
        public void ProjectCopyToTest2()
        {
            // ExStart:ProjectCopyingWithOptions
            // ExFor: Project.CopyTo(Project,CopyToOptions)
            // ExSummary: Shows how to copy the project with usage of <see cref="Aspose.Tasks.CopyToOptions"/> instance.
            var project = new Project(DataDir + "CopyToProjectEmpty.xml");
            File.Copy(DataDir + "CopyToProjectEmpty.mpp", OutDir + "ProjectCopying_out.mpp", true);

            var mppProject = new Project(OutDir + "ProjectCopying_out.mpp");

            // skip copying of view data while copying common project data.
            var options = new CopyToOptions
            {
                CopyViewData = false
            };
            project.CopyTo(mppProject, options);

            // ExEnd:ProjectCopyingWithOptions
        }

        [Test]
        public void ProjectCreation()
        {
            // ExStart:ProjectCreation
            // ExFor: Project
            // ExSummary: Shows how to work with a <see cref="Aspose.Tasks.Project"/> instance.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour); // set the desired project properties
            project.Set(Prj.NewTasksAreManual, false);

            // adding new tasks and set desired properties
            var task1 = project.RootTask.Children.Add("Task 1");
            task1.Set(Tsk.Start, new DateTime(2020, 2, 5, 8, 0, 0));
            task1.Set(Tsk.Duration, project.GetDuration(8, TimeUnitType.Hour));
            task1.Set(Tsk.Finish, new DateTime(2020, 2, 5, 17, 0, 0));
            var task2 = project.RootTask.Children.Add("Task 2");
            task2.Set(Tsk.Start, new DateTime(2020, 2, 6, 8, 0, 0));
            task2.Set(Tsk.Duration, project.GetDuration(8, TimeUnitType.Hour));
            task2.Set(Tsk.Finish, new DateTime(2020, 2, 6, 17, 0, 0));

            // adding new resources
            var workResource = project.Resources.Add("Work Resource");
            workResource.Set(Rsc.Type, ResourceType.Work);
            var costResource = project.Resources.Add("Cost Resource");
            costResource.Set(Rsc.Type, ResourceType.Cost);

            // adding new resource assignments
            var workResourceAssignment = project.ResourceAssignments.Add(task1, workResource);
            workResourceAssignment.Set(Asn.Start, new DateTime(2020, 2, 5, 8, 0, 0));
            workResourceAssignment.Set(Asn.Work, project.GetWork(8));
            workResourceAssignment.Set(Asn.Finish, new DateTime(2020, 2, 5, 17, 0, 0));
            var costResourceAssignment = project.ResourceAssignments.Add(task2, costResource);
            costResourceAssignment.Set(Asn.Start, new DateTime(2020, 2, 6, 8, 0, 0));
            costResourceAssignment.Set(Asn.Work, project.GetWork(8));
            costResourceAssignment.Set(Asn.Finish, new DateTime(2020, 2, 6, 17, 0, 0));

            // save project in the one of available formats
            // here we are saving it in Microsoft Project XML file format.
            project.Save(OutDir + "ProjectCreation_out.xml", SaveFileFormat.XML);

            // ExEnd:ProjectCreation
        }

        [Test]
        public void CreateResourceAssignments()
        {
            try
            {
                // ExStart:CreateResourceAssignments
                // ExFor: Project.ResourceAssignments
                // ExSummary: Shows how to work with resource assignments.
                var project = new Project();

                // Add new task and resource
                var task = project.RootTask.Children.Add("Task");
                var resource = project.Resources.Add("Rsc");

                // Assign the resource desired task
                project.ResourceAssignments.Add(task, resource);

                // ExEnd:CreateResourceAssignments
                project.Save(OutDir + "CreateResourceAssignments_out.pdf", SaveFileFormat.PDF);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void SaveProjectDataAsTemplate()
        {
            try
            {
                // ExStart:SaveProjectDataAsTemplate
                // ExFor: Project.SaveAsTemplate(String)
                // ExFor: Project.SaveAsTemplate(Stream)
                // ExFor: Project.SaveAsTemplate(String,SaveTemplateOptions)
                // ExFor: Project.SaveAsTemplate(Stream,SaveTemplateOptions)
                // ExSummary: Shows how to save project as a template.
                var project = new Project(DataDir + "Project2.mpp");
                var projectFileInfo = Project.GetProjectFileInfo(DataDir + "Project2.mpp");

                if (FileFormat.MPP14 == projectFileInfo.ProjectFileFormat)
                {
                    Console.WriteLine("Project file format is ok");
                }

                var options = new SaveTemplateOptions
                {
                    RemoveActualValues = true,
                    RemoveBaselineValues = true
                };

                project.SaveAsTemplate(OutDir + "SaveProjectDataAsTemplate_out.mpt", options);

                var templateFileInfo = Project.GetProjectFileInfo(OutDir + "SaveProjectDataAsTemplate_out.mpt");
                if (FileFormat.MPT14 == templateFileInfo.ProjectFileFormat)
                {
                    Console.WriteLine("Template FileFormat is ok");
                }

                // ExEnd:SaveProjectDataAsTemplate
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test, Explicit, Category("Printing")]
        public void PrintLargeFiles()
        {
            // ExStart:PrintLargeFiles
            // ExFor: Project.Print(PrintOptions)
            // ExSummary: Shows how to print a project by using of print options.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new PrintOptions
            {
                Timescale = Timescale.ThirdsOfMonths
            };
            if (project.GetPageCount(Timescale.ThirdsOfMonths) <= 280)
            {
                project.Print(options);
            }

            // ExEnd:PrintLargeFiles
        }

        [Test, Explicit, Category("Printing")]
        public void PrintPrinterSettings()
        {
            // ExStart:PrintPrinterSettings
            // ExFor: Project.Print(PrinterSettings)
            // ExSummary: Shows how to use printer settings to print the project.
            var project = new Project(DataDir + "Project2.mpp");

            // Print first two pages
            var settings = new PrinterSettings
            {
                PrintRange = PrintRange.SomePages,
                FromPage = 1,
                ToPage = 2
            };

            project.Print(settings);

            // ExEnd:PrintPrinterSettings
        }

        [Test, Explicit, Category("Printing")]
        public void PrintPrinterSettingsAndDocumentName()
        {
            // ExStart:PrintPrinterSettingsAndDocumentName
            // ExFor: Project.Print(PrinterSettings,String)
            // ExSummary: Shows how to use printer settings and a document name to print the project.
            var project = new Project(DataDir + "Project2.mpp");

            // Print first two pages
            var settings = new PrinterSettings
            {
                PrintRange = PrintRange.SomePages,
                FromPage = 1,
                ToPage = 2
            };

            project.Print(settings, "Document #1");

            // ExEnd:PrintPrinterSettingsAndDocumentName
        }

        [Test, Explicit, Category("Printing")]
        public void PrintPrintOptionsAndPrinterSettings()
        {
            // ExStart:PrintPrintOptionsAndPrinterSettings
            // ExFor: Project.Print(PrinterSettings,PrintOptions)
            // ExSummary: Shows how to use printer options and settings to print the project.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new PrintOptions
            {
                Timescale = Timescale.Months
            };

            // Print first two pages
            var settings = new PrinterSettings
            {
                PrintRange = PrintRange.SomePages,
                FromPage = 1,
                ToPage = 2
            };

            project.Print(settings, options);

            // ExEnd:PrintPrintOptionsAndPrinterSettings
        }

        [Test, Explicit, Category("Printing")]
        public void PrintProjectUsingCustomPrinter()
        {
            // ExStart:PrintProjectUsingCustomPrinter
            // ExFor: Project.Print(String)
            // ExSummary: Shows how to print the project on the selected printer.
            var project = new Project(DataDir + "Project2.mpp");

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (!printer.ToUpperInvariant().Contains("Microsoft Print to PDF".ToUpperInvariant()))
                {
                    continue;
                }

                project.Print(printer);
                break;
            }

            // ExEnd:PrintProjectUsingCustomPrinter
        }

        [Test, Explicit, Category("Printing")]
        public void PrintTheProject()
        {
            // ExStart:PrintTheProject
            // ExFor: Project.Print
            // ExSummary: Shows how to print a project.
            var project = new Project(DataDir + "Project2.mpp");
            project.Print();

            // ExEnd:PrintTheProject
        }

        [Test]
        public void CreateExtendedAttributes()
        {
            try
            {
                // ExStart:CreateExtendedAttributes
                // ExFor: Project.ExtendedAttributes
                // ExSummary: Shows how to work with extended attributes.
                var project = new Project(DataDir + "Blank2010.mpp");

                var definition = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Text1);

                // If the Custom field doesn't exist in Project, create it
                if (definition == null)
                {
                    definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, "My text field");
                    project.ExtendedAttributes.Add(definition);
                }

                // Generate Extended Attribute from definition
                var attribute = definition.CreateExtendedAttribute();
                attribute.TextValue = "Text attribute value";

                // Add extended attribute to task
                var task = project.RootTask.Children.Add("Task 1");
                task.ExtendedAttributes.Add(attribute);

                project.Save(OutDir + "CreateExtendedAttributes_out.mpp", SaveFileFormat.MPP);

                // ExEnd:CreateExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.Write(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ConfigureGanttChart()
        {
            try
            {
                // ExStart:ConfigureGanttChart
                // ExFor: Project.Tables
                // ExSummary: Shows how to configure Gantt Chart properties.
                var project = new Project(DataDir + "Project5.mpp");
                var task = project.RootTask.Children.Add("New Activity");

                // Define new custom attribute
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, null);
                project.ExtendedAttributes.Add(definition);

                // Add custom text attribute to created task.
                task.ExtendedAttributes.Add(definition.CreateExtendedAttribute("Activity attribute"));

                // Customize table by adding text attribute field
                var field = new TableField
                {
                    Field = Field.TaskText1,
                    Width = 20,
                    Title = "Custom attribute",
                    AlignTitle = StringAlignment.Center,
                    AlignData = StringAlignment.Center
                };

                var table = project.Tables.ToList()[0];
                table.TableFields.Insert(3, field);

                project.Save(OutDir + @"ConfigureGantChart_out.mpp", new MPPSaveOptions { WriteViewData = true });
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }

            // ExEnd:ConfigureGanttChart
        }

        [Test]
        public void SaveWithDefaultGanttChartView()
        {
            try
            {
                // ExStart:SaveWithDefaultGanttChartView
                // ExFor: Project.Views
                // ExSummary: Shows how to set a default project view.
                var project = new Project(DataDir + "Project5.mpp");

                View view = null;
                foreach (var v in project.Views)
                {
                    if (v.Name == "&Gantt Chart")
                    {
                        view = v;
                    }
                }

                // set default view
                project.DefaultView = view;

                project.Save(OutDir + @"SaveGantChartView_out.mpp", new MPPSaveOptions { WriteViewData = true });

                // ExEnd:SaveWithDefaultGanttChartView
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void RenumberSelectedTasksWBSCodes()
        {
            // ExStart: RenumberSelectedTasksWBSCodes
            // ExFor: Project.RenumberWBSCode(System.Collections.Generic.List{System.Int32})
            // ExFor: Project.SelectAllChildTasks
            // ExSummary: Shows how to renumber selected tasks' WBS codes.
            var project = new Project(DataDir + "RenumberExample.mpp");

            List<Task> tasks = project.RootTask.SelectAllChildTasks().ToList();

            Console.WriteLine("WBS codes before: ");

            // output: ""; "1"; "2"; "4"
            foreach (var task in tasks)
            {
                Console.WriteLine("\"" + task.Get(Tsk.WBS) + "\"" + "; ");
            }

            project.RenumberWBSCode(new List<int> { 1, 2, 3 });

            Console.WriteLine("\nWBS codes after: ");

            // output: ""; "1"; "2"; "3"
            foreach (var task in tasks)
            {
                Console.WriteLine("\"" + task.Get(Tsk.WBS) + "\"" + "; ");
            }

            // ExEnd:RenumberSelectedTasksWBSCodes
        }

        [Test]
        public void RenumberSelectedTasksWBSCodes2()
        {
            // ExStart: RenumberSelectedTasksWBSCodes
            // ExFor: Project.RenumberWBSCode()
            // ExSummary: Shows how to renumber tasks' WBS codes.
            var project = new Project(DataDir + "RenumberExample.mpp");

            List<Task> tasks = project.RootTask.SelectAllChildTasks().ToList();

            Console.WriteLine("WBS codes before: ");

            // output: ""; "1"; "2"; "4"
            foreach (var task in tasks)
            {
                Console.WriteLine("\"" + task.Get(Tsk.WBS) + "\"" + "; ");
            }

            project.RenumberWBSCode();

            Console.WriteLine("\nWBS codes after: ");

            // output: ""; "1"; "2"; "3"
            foreach (var task in tasks)
            {
                Console.WriteLine("\"" + task.Get(Tsk.WBS) + "\"" + "; ");
            }

            // ExEnd:RenumberSelectedTasksWBSCodes
        }

        [Test]
        public void WorkingWithOutlineCodes()
        {
            try
            {
                // ExStart:ReadOutlineCodes
                // ExFor: Project.OutlineCodes
                // ExSummary: Shows how to read outline codes.
                var project = new Project(DataDir + "OutlineCodes.mpp");

                foreach (var ocd in project.OutlineCodes)
                {
                    Console.WriteLine("Alias = " + ocd.Alias);
                    Console.WriteLine(ocd.AllLevelsRequired ? "It contains property: must have all levels" : "It does not contain property: must have all levels");
                    Console.WriteLine(ocd.Enterprise ? "It is an enterprise custom outline code." : "It is not an enterprise custom outline code.");
                    Console.WriteLine("Reference to another custom field for which this outline code definition is an alias is = " + ocd.EnterpriseOutlineCodeAlias);
                    Console.WriteLine("Field Id = " + ocd.FieldId);
                    Console.WriteLine("Field Name = " + ocd.FieldName);
                    Console.WriteLine("Phonetic Alias = " + ocd.PhoneticAlias);
                    Console.WriteLine("Guid = " + ocd.Guid);

                    // Display outline code masks
                    foreach (var outlineMask in ocd.Masks)
                    {
                        Console.WriteLine("Level of a mask = " + outlineMask.Level);
                        Console.WriteLine("Mask = " + outlineMask);
                    }

                    // Display out line code values
                    foreach (var outlineMask1 in ocd.Values)
                    {
                        Console.WriteLine("Description of outline value = " + outlineMask1.Description);
                        Console.WriteLine("Value Id = " + outlineMask1.ValueId);
                        Console.WriteLine("Value = " + outlineMask1.Value);
                        Console.WriteLine("Type = " + outlineMask1.Type);
                    }
                }

                // ExEnd:ReadOutlineCodes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void GetNumberOfPagesForViews()
        {
            // ExStart:GetNumberOfPagesForViews
            // ExFor: Project.GetPageCount(PresentationFormat)
            // ExFor: Project.GetPageCount(PresentationFormat,Timescale)
            // ExSummary: Shows how to get count of pages by presentation format and timescale.
            var project = new Project(DataDir + "GetNumberOfPagesForViews.mpp");

            // Get number of pages for Days (by default), Months and ThirdsOfMonths
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage));
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days));
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months));
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths));

            // ExEnd:GetNumberOfPagesForViews
        }

        [Test]
        public void CreateProjectFromStreamWithLoadOptions()
        {
            // ExStart:CreateProjectFromStreamWithLoadOptions
            // ExFor: Project.#ctor(Stream,LoadOptions)
            // ExSummary: Shows how to load the project from a stream by using <see cref="Aspose.Tasks.LoadOptions"/> instance.
            using (var stream = new FileStream(DataDir + "PasswordProtectedProject.mpp", FileMode.Open))
            {
                var options = new LoadOptions
                {
                    Password = "password"
                };
                var project = new Project(stream, options);
                Console.WriteLine(project.Get(Prj.Name));
            }

            // ExEnd:CreateProjectFromStreamWithLoadOptions
        }

        [Test]
        public void CreateProjectFromFileWithLoadOptions()
        {
            // ExStart:CreateProjectFromFileWithLoadOptions
            // ExFor: Project.#ctor(String,LoadOptions)
            // ExSummary: Shows how to load the project from a file by using <see cref="Aspose.Tasks.LoadOptions"/> instance.
            var options = new LoadOptions
            {
                Password = "password"
            };
            var project = new Project(DataDir + "PasswordProtectedProject.mpp", options);
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:CreateProjectFromFileWithLoadOptions
        }

        [Test]
        public void CreateEmptyProjectSaveMPP()
        {
            try
            {
                // ExStart:CreateEmptyProjectSaveMPP
                // ExFor: Project.#ctor
                // ExFor: Project.Save(String,SaveFileFormat)
                // ExSummary: Shows how to create a project and save it into MPP format without passing of an MPP template file.
                var project = new Project();

                // The project will be saved into MPP by using internal MPP template.
                project.Save(OutDir + "CreateEmptyProjectSaveMPP_out.mpp", SaveFileFormat.MPP);

                // ExEnd:CreateEmptyProjectSaveMPP
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ReadProjectFileFromStream()
        {
            try
            {
                // ExStart:ReadProjectFileFromStream
                // ExFor: Project.#ctor(Stream)
                // ExSummary: Shows how to read XML project file from a stream.
                using (Stream stream = new FileStream(DataDir + "Project.xml", FileMode.Open))
                {
                    var project = new Project(stream);
                    project.Save(OutDir + "ReadProjectFileFromStream_out.xml", SaveFileFormat.XML);
                }

                // ExEnd:ReadProjectFileFromStream
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ReadProjectFiles()
        {
            // ExStart:ReadProjectFiles
            // ExFor: Project.#ctor(String)
            // ExSummary: Shows how to read a MPP file.
            var project = new Project(DataDir + "ReadProjectFiles.mpp");
            project.Save(OutDir + "ReadProjectFiles_out.mpp", SaveFileFormat.XML);

            // ExEnd:ReadProjectFiles
        }

        [Test]
        public void WorkingWithEncodings()
        {
            // ExStart:WorkingWithEncodings
            // ExFor: Project.#ctor(StreamReader)
            // ExSummary: Shows how to read MPX files with specific encoding.
            using (var streamReader = new StreamReader(DataDir + "EUC-KR-encoding.mpx", System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                var project = new Project(streamReader);
                Console.WriteLine(project.RootTask.Children.ToList()[0].Get(Tsk.Name));
                project.Save(OutDir + "WorkingWithEncodings_out.mpx", SaveFileFormat.MPX);
            }

            // ExEnd:WorkingWithEncodings
        }

        [Test]
        public void SaveToStreamWithOptions()
        {
            // ExStart:CreateEmptyProjectToSaveToStreamWithImageOptions
            // ExFor: Project.Save(Stream, SaveOptions)
            // ExSummary: Shows how to save project into a stream as an image and to control image options.
            var project = new Project();

            using (var stream = new FileStream(OutDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                var options = new ImageSaveOptions(SaveFileFormat.PNG);

                // by using of ImageSaveOptions we save the project into image format
                project.Save(stream, options);
            }

            // ExEnd:CreateEmptyProjectToSaveToStreamWithImageOptions
        }

        [Test]
        public void GetNumberOfPages()
        {
            // ExStart:GetNumberOfPages
            // ExFor: Project.GetPageCount()
            // ExFor: Project.GetPageCount(Timescale)
            // ExSummary: Shows how to get page count for different timescales.
            var project = new Project(DataDir + "GetNumberOfPages.mpp");

            // Get number of pages, Timescale.Months, Timescale.ThirdsOfMonths
            var pageCount = project.GetPageCount();
            Console.WriteLine("Page count: " + pageCount);
            pageCount = project.GetPageCount(Timescale.Months);
            Console.WriteLine("Page count (Month): " + pageCount);
            pageCount = project.GetPageCount(Timescale.ThirdsOfMonths);
            Console.WriteLine("Page count (Thirds of Months): " + pageCount);

            // ExEnd:GetNumberOfPages
        }

        [Test]
        public void GetNumberOfPages2()
        {
            // ExStart:GetNumberOfPagesBySaveOptions
            // ExFor: Project.GetPageCount(SaveOptions)
            // ExSummary: Shows how to get page count for specific save options.
            var project = new Project(DataDir + "GetNumberOfPages.mpp");
            var options = new HtmlSaveOptions
                              {
                                  IncludeProjectNameInPageHeader = false,
                                  IncludeProjectNameInTitle = false,
                                  PageSize = PageSize.A4,
                                  Timescale = Timescale.Days,
                                  StartDate = project.Get(Prj.StartDate).Date,
                                  EndDate = project.Get(Prj.FinishDate).Date
                              };

            Console.WriteLine(project.GetPageCount(options));

            // ExEnd:GetNumberOfPagesBySaveOptions
        }

        [Test]
        public void CalculateCriticalPath()
        {
            // ExStart:CalculateCriticalPath
            // ExFor: Project.CriticalPath
            // ExSummary: Shows how to calculate a critical path of the project.
            var project = new Project(DataDir + "CalculateCriticalPath.mpp")
            {
                CalculationMode = CalculationMode.Automatic
            };

            var subtask1 = project.RootTask.Children.Add("1");
            var subtask2 = project.RootTask.Children.Add("2");
            project.TaskLinks.Add(subtask1, subtask2, TaskLinkType.FinishToStart);

            project.RootTask.Children.Add("3");

            // Display the critical path now
            foreach (var task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id) + "  " + task.Get(Tsk.Name));
                Console.WriteLine(task.Get(Tsk.Start));
                Console.WriteLine(task.Get(Tsk.Finish) + "\n");
            }

            // ExEnd:CalculateCriticalPath
        }

        [Test]
        public void ProjectDisplayOptionsUsage()
        {
            // ExStart:ProjectDisplayOptionsUsage
            // ExFor: Project.DisplayOptions
            // ExSummary: Shows how to tune project's display options.
            var project = new Project(DataDir + "Blank2010.mpp");

            // Set a value indicating whether to show warnings when Project identifies a possible scheduling conflict with a manually scheduled task.
            // This option is available for Project 2010 version and later.
            project.DisplayOptions.ShowTaskScheduleWarnings = false;

            // ExEnd:ProjectDisplayOptionsUsage
        }

        [Test]
        public void EmbeddedObjectsCreatedInsideApplication()
        {
            try
            {
                // ExStart:EmbeddedObjectsCreatedInsideApplication
                // ExFor: Project.OleObjects
                // ExSummary: Shows how to extract an embedded OLE objects.
                IDictionary<string, string> formatExt = new Dictionary<string, string>
                {
                    { "RTF", "_rtfFile_out.rtf" },
                    { "MSWordDoc", "_wordFile_out.docx" },
                    { "ExcelML12", "_excelFile_out.xlsx" }
                };

                var project = new Project(DataDir + "Embedded.mpp");

                foreach (var oleObject in project.OleObjects)
                {
                    if (string.IsNullOrEmpty(oleObject.FileFormat) || !formatExt.ContainsKey(oleObject.FileFormat))
                    {
                        continue;
                    }

                    var path = OutDir + "EmbeddedContent_" + formatExt[oleObject.FileFormat];
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        stream.Write(oleObject.Content, 0, oleObject.Content.Length);
                    }
                }

                // ExEnd:EmbeddedObjectsCreatedInsideApplication
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void GetProjectDefaultWeekWorkingDays()
        {
            // ExStart:GetProjectDefaultWeekWorkingDays
            // ExFor: Project.DefaultWeekWorkingDays
            // ExSummary: Shows how to get default week working day.
            var project = new Project(DataDir + "Project2003.mpp");
            foreach (var weekDay in project.DefaultWeekWorkingDays)
            {
                Console.WriteLine("From: " + weekDay.FromDate);
                Console.WriteLine("From: " + weekDay.ToDate);
                Console.WriteLine("Day type: " + weekDay.DayType);
                Console.WriteLine("Is day working: " + weekDay.DayWorking);
            }

            // ExEnd:GetProjectDefaultWeekWorkingDays
        }

        [Test]
        public void ProjectRemoveInvalidAssignments()
        {
            // ExStart:ProjectRemoveInvalidAssignments
            // ExFor: Project.RemoveInvalidResourceAssignments
            // ExSummary: Shows how to remove invalid assignments.
            var project = new Project(DataDir + "InvalidResourceAssignments.mpp");
            var invalid = 0;

            // ReSharper disable once LoopCanBeConvertedToQuery //ExSkip
            foreach (var ra in project.ResourceAssignments)
            {
                if (ra.Get(Asn.Resource) == null)
                {
                    invalid++;
                }
            }

            Console.WriteLine("Count of invalid assignments (before): " + invalid);

            // remove invalid assignments
            project.RemoveInvalidResourceAssignments();

            Console.WriteLine("Count of invalid assignments (after): " + invalid);

            // ExEnd:ProjectRemoveInvalidAssignments
        }

        [Test]
        public static void ReadFilterCriteriaData()
        {
            // ExStart:ReadFilterCriteriaData
            // ExFor: Project.TaskFilters
            // ExSummary: Shows how to read project task filters.
            var project = new Project(DataDir + "Project2003.mpp");

            var filter = project.TaskFilters.ToList()[1];
            Console.WriteLine(filter.Criteria.CriteriaRows.Count);
            Console.WriteLine(filter.Criteria.Operation.ToString());

            var criteria1 = filter.Criteria.CriteriaRows[0];
            Console.WriteLine(criteria1.Test.ToString());
            Console.WriteLine(criteria1.Field.ToString());
            Console.WriteLine(criteria1.Values[0].ToString());

            var criteria2 = filter.Criteria.CriteriaRows[1];
            Console.WriteLine(criteria2.Operation.ToString());
            Console.WriteLine(criteria2.CriteriaRows.Count);

            var criteria21 = criteria2.CriteriaRows[0];
            Console.WriteLine(criteria21.Test.ToString());
            Console.WriteLine(criteria21.Field.ToString());
            Console.WriteLine(criteria21.Values[0].ToString());

            var criteria22 = criteria2.CriteriaRows[1];
            Console.WriteLine(criteria22.Test.ToString());
            Console.WriteLine(criteria22.Field.ToString());
            Console.WriteLine(criteria22.Values[0].ToString());
            Console.WriteLine(filter.Criteria);

            // ExEnd:ReadFilterCriteriaData
        }

        [Test]
        public void ReadFilterDefinitionData()
        {
            // ExStart:ReadFilterDefinitionData
            // ExFor: Project.ResourceFilters
            // ExSummary: Shows how to read task/resource filter definitions.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");
            List<Filter> taskFilters = project.TaskFilters.ToList();
            Console.WriteLine("Task Filters Count: " + taskFilters.Count);
            Console.WriteLine("All Tasks: " + taskFilters[0].Name);
            Console.WriteLine("Task Item: " + taskFilters[0].FilterType);
            Console.WriteLine("Task Filters Show In Menu: " + taskFilters[0].ShowInMenu);
            Console.WriteLine("Task filter ShowRelatedSummaryRows: " + taskFilters[0].ShowRelatedSummaryRows);

            // Access resource filters
            List<Filter> rscFilters = project.ResourceFilters.ToList();
            Console.WriteLine("Project.ResourceFilters count: " + rscFilters.Count);
            Console.WriteLine("Resource Filter Item Type: Item.ResourceType: " + rscFilters[0].FilterType);
            Console.WriteLine("Resource filter ShowInMenu" + rscFilters[0].ShowInMenu);
            Console.WriteLine("Resource filter ShowRelatedSummaryRows: " + rscFilters[0].ShowRelatedSummaryRows);

            // ExEnd:ReadFilterDefinitionData
        }

        [Test]
        public void GetPageCountOnStartAndEndDates()
        {
            // ExStart: GetPageCountOnStartAndEndDates
            // ExFor: Project.GetPageCount(PageSize,Timescale,DateTime,DateTime)
            // ExSummary: Shows how to get count of pages by page size, timescale, start and finish dates.
            var project = new Project(DataDir + "GetNumberOfPages.mpp");
            var pageCount = project.GetPageCount(
                PageSize.A3,
                Timescale.Months,
                project.Get(Prj.StartDate) - TimeSpan.FromDays(10),
                project.Get(Prj.FinishDate) + TimeSpan.FromDays(30));

            Console.WriteLine(pageCount);

            // ExEnd:GetPageCountOnStartAndEndDates
        }

        [Test]
        public void GetPageCountOnStartAndEndDates2()
        {
            // ExStart: GetPageCountForDefaultProjectDates
            // ExFor: Project.GetPageCount(PageSize,Timescale)
            // ExSummary: Shows how to get count of pages by a page size and a timescale.
            var project = new Project(DataDir + "GetNumberOfPages.mpp");
            var pageCount = project.GetPageCount(PageSize.A3, Timescale.Months);

            Console.WriteLine(pageCount);

            // ExEnd:GetPageCountForDefaultProjectDates
        }

        [Test]
        public void ProjectRecalculateResourceFields()
        {
            // ExStart:ProjectRecalculateResourceFields
            // ExFor: Project.RecalculateResourceFields
            // ExSummary: Shows how to recalculate common resource fields.
            var project = new Project
            {
                CalculationMode = CalculationMode.None
            };

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1d, TimeUnitType.Day));
            task.Set(Tsk.Finish, new DateTime(2020, 3, 26, 17, 0, 0));

            var resource1 = project.Resources.Add("Res1");
            resource1.Set(Rsc.Id, 2);
            resource1.Set(Rsc.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            resource1.Set(Rsc.Finish, new DateTime(2020, 3, 26, 17, 0, 0));
            var resource2 = project.Resources.Add("Res2");
            resource2.Set(Rsc.Id, 1);
            resource2.Set(Rsc.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            resource2.Set(Rsc.Finish, new DateTime(2020, 3, 26, 17, 0, 0));

            var resourceAssignment1 = project.ResourceAssignments.Add(task, resource1);
            resourceAssignment1.Set(Asn.Start, new DateTime(2020, 3, 25, 8, 0, 0));
            resourceAssignment1.Set(Asn.Finish, new DateTime(2020, 3, 27, 17, 0, 0));

            var resourceAssignment2 = project.ResourceAssignments.Add(task, resource2);
            resourceAssignment2.Set(Asn.Start, new DateTime(2020, 3, 24, 8, 0, 0));
            resourceAssignment2.Set(Asn.Finish, new DateTime(2020, 3, 24, 17, 0, 0));

            Console.WriteLine("Resource 1 Id (before): " + resource1.Get(Rsc.Id));
            Console.WriteLine("Resource 1 Start (before): " + resource1.Get(Rsc.Start));
            Console.WriteLine("Resource 1 Finish (before): " + resource1.Get(Rsc.Finish));
            Console.WriteLine("Resource 2 Id (before): " + resource1.Get(Rsc.Id));
            Console.WriteLine("Resource 2 Start (before): " + resource1.Get(Rsc.Start));
            Console.WriteLine("Resource 2 Finish (before): " + resource1.Get(Rsc.Finish));

            // Recalculates Id, Start and Finish of resources
            project.RecalculateResourceFields();

            Console.WriteLine("Resource 1 Id (after): " + resource1.Get(Rsc.Id));
            Console.WriteLine("Resource 1 Start (after): " + resource1.Get(Rsc.Start));
            Console.WriteLine("Resource 1 Finish (after): " + resource1.Get(Rsc.Finish));
            Console.WriteLine("Resource 2 Id (after): " + resource2.Get(Rsc.Id));
            Console.WriteLine("Resource 2 Start (after): " + resource2.Get(Rsc.Start));
            Console.WriteLine("Resource 2 Finish (after): " + resource2.Get(Rsc.Finish));

            // ExEnd:ProjectRecalculateResourceFields
        }

        [Test]
        public void ProjectRecalculateResourceStartFinish()
        {
            // ExStart:ProjectRecalculateResourceStartFinish
            // ExFor: Project.RecalculateResourceStartFinish
            // ExSummary: Shows how to recalculate resource start/finish dates.
            var project = new Project
            {
                CalculationMode = CalculationMode.None
            };

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1d, TimeUnitType.Day));
            task.Set(Tsk.Finish, new DateTime(2020, 3, 26, 17, 0, 0));

            var resource = project.Resources.Add("Res1");
            resource.Set(Rsc.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            resource.Set(Rsc.Finish, new DateTime(2020, 3, 26, 17, 0, 0));

            var resourceAssignment = project.ResourceAssignments.Add(task, resource);
            resourceAssignment.Set(Asn.Start, new DateTime(2020, 3, 25, 8, 0, 0));
            resourceAssignment.Set(Asn.Finish, new DateTime(2020, 3, 27, 8, 0, 0));

            Console.WriteLine("Resource Start (before): " + resource.Get(Rsc.Start));
            Console.WriteLine("Resource Finish (before): " + resource.Get(Rsc.Finish));

            // Recalculates Start and Finish of resources
            project.RecalculateResourceStartFinish();

            Console.WriteLine("Resource Start (after): " + resource.Get(Rsc.Start));
            Console.WriteLine("Resource Finish (after): " + resource.Get(Rsc.Finish));

            // ExEnd:ProjectRecalculateResourceStartFinish
        }

        [Test]
        public void ProjectRecalculateWithValidation()
        {
            // ExStart:ProjectRecalculateWithValidation
            // ExFor: Project.Recalculate(Boolean)
            // ExSummary: Shows how to recalculate the project with post validation.
            var project = new Project();
            var task = project.RootTask.Children.Add("t1");
            task.Set(Tsk.CommitmentStart, new DateTime(2017, 6, 19, 8, 0, 0));
            task.Set(Tsk.CommitmentFinish, new DateTime(2017, 6, 18, 17, 0, 0));

            try
            {
                // recalculate the project with post validation
                project.Recalculate(true);
            }
            catch (TaskValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:ProjectRecalculateWithValidation
        }

        [Test]
        public void RescheduleProjectFromStartDate()
        {
            // ExStart:RescheduleProjectFromStartDate
            // ExFor: Project.Recalculate
            // ExSummary: Shows how to reschedule the project from start date instead of the finish one.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.ScheduleFromStart, true);
            project.Set(Prj.StartDate, new DateTime(2014, 1, 1));

            // Now all tasks dates (Start, Finish, EarlyStart, EarlyFinish, LateStart, LateFinish) are calculated. To get the critical path we need to calculate slacks (can be invoked in separate thread, but only after calculation of all early/late dates)
            project.Recalculate();

            foreach (var task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id));
                Console.WriteLine(task.Get(Tsk.Name));
            }

            // ExEnd:RescheduleProjectFromStartDate
        }

        [Test]
        public static void UpdateProjectAndRescheduleUncompletedWork()
        {
            // ExStart:UpdateProjectAndRescheduleUncompletedWork
            // ExFor: Project.UpdateProjectWorkAsComplete(DateTime,bool)
            // ExFor: Project.UpdateProjectWorkAsComplete(DateTime,bool,List{Aspose.Tasks.Task})
            // ExFor: Project.RescheduleUncompletedWorkToStartAfter(DateTime)
            // ExFor: Project.RescheduleUncompletedWorkToStartAfter(DateTime,List{Aspose.Tasks.Task})
            // ExSummary: Shows how to update the project and reschedule uncompleted work.
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2014, 1, 27, 8, 0, 0));

            // Add new tasks
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");
            task2.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task3 = project.RootTask.Children.Add("Task 3");
            task3.Set(Tsk.Duration, task2.ParentProject.GetDuration(24, TimeUnitType.Hour));
            var task4 = project.RootTask.Children.Add("Task 4");
            task4.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task5 = project.RootTask.Children.Add("Task 5");
            task5.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));

            // Add links between tasks
            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);
            var link23 = project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart);

            // One day lag
            link23.LinkLag = 4800;
            project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart);

            // Add new tasks
            var task6 = project.RootTask.Children.Add("Task 6");
            var task7 = project.RootTask.Children.Add("Task 7");
            task7.Set(Tsk.Duration, task7.ParentProject.GetDuration(24, TimeUnitType.Hour));
            var task8 = project.RootTask.Children.Add("Task 8");
            task8.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task9 = project.RootTask.Children.Add("Task 9");
            task9.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task10 = project.RootTask.Children.Add("Task 10");

            // Add links between tasks
            project.TaskLinks.Add(task6, task7, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task7, task8, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task8, task9, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task9, task10, TaskLinkType.FinishToStart);
            task6.Set(Tsk.IsManual, true);
            task7.Set(Tsk.IsManual, true);
            task8.Set(Tsk.IsManual, true);
            task9.Set(Tsk.IsManual, true);
            task10.Set(Tsk.IsManual, true);

            // Save project before and after updating work as completed 
            project.Save(OutDir + "RescheduleUncompletedWork_not updated_out.xml", SaveFileFormat.XML);

            // Save project after updating project work as complete only for specified tasks
            project.UpdateProjectWorkAsComplete(new DateTime(2014, 1, 28, 17, 0, 0), false, new List<Task> { task10 });
            project.Save(OutDir + "RescheduleUncompletedWork_specific_updated_out.xml", SaveFileFormat.XML);

            // Save project after updating all project work as complete
            project.UpdateProjectWorkAsComplete(new DateTime(2014, 1, 28, 17, 0, 0), false);
            project.Save(OutDir + "RescheduleUncompletedWork_updated_out.xml", SaveFileFormat.XML);

            // Save project after rescheduling uncompleted work only for specified tasks
            project.RescheduleUncompletedWorkToStartAfter(new DateTime(2014, 2, 8, 8, 0, 0), new List<Task> { task10 });
            project.Save(OutDir + "RescheduleUncompletedWork_specific_rescheduled_out.xml", SaveFileFormat.XML);

            // Save project after rescheduling uncompleted work
            project.RescheduleUncompletedWorkToStartAfter(new DateTime(2014, 2, 7, 8, 0, 0));
            project.Save(OutDir + "RescheduleUncompletedWork_rescheduled_out.xml", SaveFileFormat.XML);

            // ExEnd:UpdateProjectAndRescheduleUncompletedWork
        }

        [Test]
        public void WorkWithBaselineSaveTime()
        {
            // ExStart:WorkWithBaselineSaveTime
            // ExFor: Project.SetBaselineSaveTime(BaselineType,DateTime)
            // ExFor: Project.GetBaselineSaveTime(BaselineType)
            // ExSummary: Shows how to read/write project's baseline save time.
            var project = new Project();
            var baselineSave = project.GetBaselineSaveTime(BaselineType.Baseline);
            Console.WriteLine("Baseline save time before: " + baselineSave);

            // set baseline save time
            project.SetBaselineSaveTime(BaselineType.Baseline, DateTime.Today);

            var baselineSaveNew = project.GetBaselineSaveTime(BaselineType.Baseline);
            Console.WriteLine("Baseline save time after: " + baselineSaveNew);

            // ExEnd:WorkWithBaselineSaveTime
        }

        [Test]
        public void AddWBSCodes()
        {
            // ExStart:AddWBSCodes
            // ExFor: Project.WBSCodeDefinition
            // ExSummary: Shows how to add WBS codes.
            var project = new Project
            {
                WBSCodeDefinition = new WBSCodeDefinition()
            };
            project.WBSCodeDefinition.GenerateWBSCode = true;
            project.WBSCodeDefinition.VerifyUniqueness = true;
            project.WBSCodeDefinition.CodePrefix = "CRS-";

            var mask = new WBSCodeMask
            {
                Length = 2,
                Separator = "-",
                Sequence = WBSSequence.OrderedNumbers
            };
            project.WBSCodeDefinition.CodeMaskCollection.Add(mask);

            mask = new WBSCodeMask
            {
                Length = 1,
                Separator = "-",
                Sequence = WBSSequence.OrderedUppercaseLetters
            };
            project.WBSCodeDefinition.CodeMaskCollection.Add(mask);

            var tsk = project.RootTask.Children.Add("Task 1");
            tsk.Children.Add("Task 2");

            project.Recalculate();

            project.Save(OutDir + @"AddWBSCodes_out.xml", SaveFileFormat.XML);

            // ExEnd:AddWBSCodes
        }

        [Test]
        public void DetermineProjectVersion()
        {
            // ExStart:DetermineProjectVersion
            // ExFor: Project.Get``1(Key{``0,PrjKey})
            // ExSummary: Shows how to check a project version.
            var project = new Project(DataDir + "DetermineProjectVersion.mpp");

            // Display project version
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion));
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());

            // ExEnd:DetermineProjectVersion
        }

        [Test]
        public void ReadingPasswordProtectedProjectFile()
        {
            // ExStart:ReadingPasswordProtectedProjectFile
            // ExFor: Project.#ctor(String,String)
            // ExSummary: Shows how to read password protected MPP files.
            var project = new Project(DataDir + "PasswordProtectedProject.mpp", "password");
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:ReadingPasswordProtectedProjectFile
        }

        [Test]
        public void ReadingPasswordProtectedProjectFile2()
        {
            // ExStart:ReadingPasswordProtectedProjectStream2
            // ExFor: Project.#ctor(Stream,String)
            // ExSummary: Shows how to read password protected MPP files from a stream.
            using (var stream = new FileStream(DataDir + "PasswordProtectedProject.mpp", FileMode.Open))
            {
                var project = new Project(stream, "password");
                Console.WriteLine(project.Get(Prj.Name));
            }

            // ExEnd:ReadingPasswordProtectedProjectStream2
        }

        [Test]
        public void RenderTaskUsageViewWithDetails()
        {
            // ExStart:RenderTaskUsageViewWithDetails
            // ExFor: Project.DefaultView
            // ExSummary: Shows how to work with default view of a project.
            var project = new Project(DataDir + "TaskUsageViewWithDetails.mpp");

            // Get Default view
            UsageView view = (TaskUsageView)project.DefaultView;

            // Details header column will not be displayed
            view.DisplayDetailsHeaderColumn = false;
            view.RepeatDetailsHeaderOnAllRows = false;
            view.AlignDetailsData = StringAlignment.Near;
            project.Save(OutDir + "task usage1_out.pdf", SaveFileFormat.PDF);

            // Display details header column
            view.DisplayDetailsHeaderColumn = true;

            // Repeat details header on all assignments rows
            view.RepeatDetailsHeaderOnAllRows = true;
            view.AlignDetailsData = StringAlignment.Far;
            project.Save(OutDir + "task usage2_out.pdf", SaveFileFormat.PDF);

            // ExEnd:RenderTaskUsageViewWithDetails
        }

        [Test]
        public void ReadResourceGroupDefinitionData()
        {
            // ExStart:ReadResourceGroupDefinitionData
            // ExFor: Project.ResourceGroups
            // ExSummary: Shows how to read resource groups.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");

            Console.WriteLine("Resource Groups Count: " + project.ResourceGroups.Count);
            var resGroup = project.TaskGroups.ToList()[1];
            Console.WriteLine("Resource Group Name: " + resGroup.Name);
            Console.WriteLine("Resource Group Criteria count: " + resGroup.GroupCriteria.Count);
            Console.WriteLine("\n************* Retrieving Resource Group's Criterion information *************");
            var resCriterion = resGroup.GroupCriteria.ToList()[0];
            Console.WriteLine("Resource Criterion Field: " + resCriterion.Field);
            Console.WriteLine("Resource Criterion GroupOn: " + resCriterion.GroupOn);
            Console.WriteLine("Resource Criterion Cell Color: " + resCriterion.CellColor);
            Console.WriteLine("Resource Criterion Pattern: " + resCriterion.Pattern);

            Console.WriteLine("\n*********** Retrieving Resource Criterion's Font Information ***********");
            Console.WriteLine("Resource Font Name: " + resCriterion.Font.Name);
            Console.WriteLine("Resource Font Size: " + resCriterion.Font.Size);
            Console.WriteLine("Resource Font Style: " + resCriterion.Font.Style);
            Console.WriteLine("Resource Ascending/Descending: " + resCriterion.Ascending);

            // ExEnd:ReadResourceGroupDefinitionData
        }

        [Test]
        public void ReadTaskGroupDefinitionData()
        {
            // ExStart:ReadTaskGroupDefinitionData
            // ExFor: Project.TaskGroups
            // ExSummary: Shows how to read task groups.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");

            Console.WriteLine("Task Groups Count: " + project.TaskGroups.Count);
            var taskGroup = project.TaskGroups.ToList()[1];
            Console.WriteLine("Task Group Name: " + taskGroup.Name);
            Console.WriteLine("Task Group Criteria count: " + taskGroup.GroupCriteria.Count);
            Console.WriteLine("\n************* Retrieving Task Group's Criterion information *************");
            var taskCriterion = taskGroup.GroupCriteria.ToList()[0];
            Console.WriteLine("Task Criterion Field: " + taskCriterion.Field);
            Console.WriteLine("Task Criterion GroupOn: " + taskCriterion.GroupOn);
            Console.WriteLine("Task Criterion Cell Color: " + taskCriterion.CellColor);
            Console.WriteLine("Task Criterion Pattern: " + taskCriterion.Pattern);

            if (taskGroup == taskCriterion.ParentGroup)
            {
                Console.WriteLine("Parent Group is equal to task Group.");
            }

            Console.WriteLine("\n*********** Retrieving Criterion's Font Information ***********");
            Console.WriteLine("Font Name: " + taskCriterion.Font.Name);
            Console.WriteLine("Font Size: " + taskCriterion.Font.Size);
            Console.WriteLine("Font Style: " + taskCriterion.Font.Style);
            Console.WriteLine("Ascending/Descending: " + taskCriterion.Ascending);

            // ExEnd:ReadTaskGroupDefinitionData
        }

        [Test]
        public void SetAttributesForNewTasks()
        {
            // ExStart:SetAttributesForNewTasks
            // ExFor: Project.Set``1(Key{``0,PrjKey},``0)
            // ExFor: Project.Set(Aspose.Tasks.Key{System.DateTime,Aspose.Tasks.PrjKey},System.DateTime)
            // ExSummary: Shows how to set task's attributes.
            var project = new Project();
            project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);
            project.Save(OutDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);

            // ExEnd:SetAttributesForNewTasks
        }

        [Test]
        public void ReadProjectMetaProperties()
        {
            // ExStart:ReadProjectMetaProperties
            // ExFor: Project.CustomProps
            // ExFor: Project.BuiltInProps
            // ExSummary: Shows how to read project meta properties (obsolete API).
            var project = new Project(DataDir + "ReadProjectInfo.mpp");

            // custom properties are available through the typed collection
            foreach (var property in project.CustomProps)
            {
                Console.WriteLine(property.Type);
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }

            // built-in properties are available directly
            Console.WriteLine(project.BuiltInProps.Author);
            Console.WriteLine(project.BuiltInProps.Title);

            // or as an item of built-in property collection
            foreach (var property in project.BuiltInProps)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }

            // ExEnd:ReadProjectMetaProperties
        }

        [Test]
        public void ImportDataFromXMLFileFormats()
        {
            // ExStart:ImportDataFromXMLFileFormats
            // ExFor: Project.GetProjectFileInfo(String)
            // ExSummary: Shows how to read project file info were read from an XML file.
            var info = Project.GetProjectFileInfo(DataDir + "Project.xml");
            Console.WriteLine("CanRead: " + info.CanRead);
            Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
            Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);

            // ExEnd:ImportDataFromXMLFileFormats
        }

        [Test]
        public void ImportDataFromXMLFileFormats2()
        {
            // ExStart:ImportDataFromXMLFileFormats
            // ExFor: Project.GetProjectFileInfo(Stream)
            // ExSummary: Shows how to read project file info of XML file read from a stream.
            using (var stream = new FileStream(DataDir + "Project.xml", FileMode.Open))
            {
                var info = Project.GetProjectFileInfo(stream);
                Console.WriteLine("CanRead: " + info.CanRead);
                Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
                Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);
            }

            // ExEnd:ImportDataFromXMLFileFormats
        }

        [Test, Category("Database")]
        public void ImportProjectFromPrimaveraDB()
        {
            try
            {
                // ExStart:ImportProjectFromPrimaveraDB
                // ExFor: Project.#ctor(DbSettings)
                // ExSummary: Shows how to import a project from a Primavera database by using database settings.
                var sb = new SqlConnectionStringBuilder
                {
                    DataSource = "192.168.56.3,1433",
                    Encrypt = true,
                    TrustServerCertificate = true,
                    InitialCatalog = "PrimaveraEDB",
                    NetworkLibrary = "DBMSSOCN",
                    UserID = "privuser",
                    Password = "***",
                    ConnectTimeout = 2 // ExSkip
                };

                // Initialize a new instance of the PrimaveraDbSettings class with connection string and project id
                var settings = new PrimaveraDbSettings(sb.ConnectionString, 4502);

                // Initialize a new instance of the Project class
                var project = new Project(settings);
                Console.WriteLine(project.Get(Prj.Name));

                // ExEnd:ImportProjectFromPrimaveraDB
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");
            }
            catch (TasksReadingException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void IgnoreInvalidCharactersDuringLoadingProjectFromStream()
        {
            LoadProjectFromStream(GetModifiedXml(DataDir));
            var xml = GetModifiedXml(DataDir);
            File.WriteAllText(OutDir + "IgnoreInvalidCharacters_out.xml", xml);
            LoadProjectFromFile(OutDir + "IgnoreInvalidCharacters_out.xml");
        }

        // ExStart:IgnoreInvalidCharactersDuringLoadingProjectFromStream
        // ExFor: Project.#ctor(String,ParseErrorCallback)
        // ExFor: ParseErrorCallback
        // ExFor: ParseErrorArgs
        // ExFor: ParseErrorArgs.Exception
        // ExFor: ParseErrorArgs.FieldName
        // ExFor: ParseErrorArgs.FieldType
        // ExFor: ParseErrorArgs.InvalidValue
        // ExSummary: Shows how to read a project from a stream with XML file with invalid characters.
        public static void LoadProjectFromFile(string pathToModifiedXml)
        {
            // open the file which contains XML with broken timespans
            var project = new Project(pathToModifiedXml, CustomDurationHandlerForFile2);
            Console.WriteLine(project.Get(Prj.Name));
        }

        public static object CustomDurationHandlerForFile2(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Console.WriteLine("Object field: {0}, Object field type: {1}, Invalid value: {2}", args.FieldName, args.FieldType, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var newValue = Duration.ParseTimeSpan(duration);
            Console.WriteLine("New value : {0}", newValue);
            return newValue;
        }

        // ExEnd:IgnoreInvalidCharactersDuringLoadingProjectFromFile

        // ExStart:IgnoreInvalidCharactersDuringLoadingProjectFromStream
        // ExFor: Project.#ctor(Stream, ParseErrorCallback)
        // ExSummary: Shows how to read a project from XML file with invalid characters.
        public static void LoadProjectFromStream(string brokenXmlData)
        {
            // open the stream which contains XML with broken timespans
            byte[] bytes = Encoding.UTF8.GetBytes(brokenXmlData);
            using (var stream = new MemoryStream(bytes))
            {
                var project = new Project(stream, CustomDurationHandlerForStream2);
                Console.WriteLine(project.Get(Prj.Name));
            }
        }

        public static object CustomDurationHandlerForStream2(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Debug.Print("Object field : {0}, Invalid value : {1}", args.FieldName, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var newValue = Duration.ParseTimeSpan(duration);
            Debug.Print("New value : {0}", newValue);
            return newValue;
        }
        
        // ExEnd:IgnoreInvalidCharactersDuringLoadingProjectFromStream

        [Test]
        public void ReadXMLFileWithMultipleProjects1()
        {
            // ExStart:ReadXMLFileWithMultipleProjects
            // ExFor: Project.#ctor(String,PrimaveraXmlReadingOptions)
            // ExSummary: Shows how to read a project from a Primavera XML file with multiple projects by using Primavera XML reading options.
            var options = new PrimaveraXmlReadingOptions
            {
                ProjectUid = 4557
            };

            // Returns project with special Uid
            var project = new Project(DataDir + "Project.xml", options);
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:ReadXMLFileWithMultipleProjects
        }

        [Test]
        public void ReadXMLFileWithMultipleProjects2()
        {
            // ExStart:ReadXMLStreamWithMultipleProjects
            // ExFor: Project.#ctor(Stream,PrimaveraXmlReadingOptions)
            // ExSummary: Shows how to read a project from a stream with Primavera XML file with multiple projects.
            var options = new PrimaveraXmlReadingOptions
            {
                ProjectUid = 4557
            };
            using (var stream = new FileStream(DataDir + "Project.xml", FileMode.Open, FileAccess.Read))
            {
                // Returns project with special Uid
                var project = new Project(stream, options);
                Console.WriteLine(project.Get(Prj.Name));
            }

            // ExEnd:ReadXMLStreamWithMultipleProjects
        }

        [Test]
        public void ReadXMLFileWithMultipleProjects3()
        {
            byte[] brokenXmlFileBytes = Encoding.UTF8.GetBytes(GetModifiedXml2(DataDir));

            // ExStart:ReadBrokenPrimaveraXmlStreamWithMultipleProjects
            // ExFor: Project.#ctor(Stream,ParseErrorCallback,PrimaveraXmlReadingOptions)
            // ExSummary: Shows how to read a project from a stream with Primavera XML file with error parsing.
            var options = new PrimaveraXmlReadingOptions
            {
                ProjectUid = 4557
            };
            using (var stream = new MemoryStream(brokenXmlFileBytes))
            {
                // Returns project with special Uid
                var project = new Project(stream, CustomDurationHandlerForStream, options);
                Console.WriteLine(project.Get(Prj.Name));
            }

            // ExEnd:ReadBrokenPrimaveraXmlStreamWithMultipleProjects
        }

        [Test]
        public void ReadXMLFileWithMultipleProjects4()
        {
            var xml = GetModifiedXml2(DataDir);
            File.WriteAllText(OutDir + "IgnoreInvalidCharacters_out.xml", xml);

            // ExStart:ReadBrokenPrimaveraXmlFileWithMultipleProjects
            // ExFor: Project.#ctor(String,ParseErrorCallback,PrimaveraXmlReadingOptions)
            // ExSummary: Shows how to read a project from a Primavera XML file with error parsing.
            var options = new PrimaveraXmlReadingOptions
            {
                ProjectUid = 4557
            };

            // Returns project with special Uid
            var project = new Project(OutDir + "IgnoreInvalidCharacters_out.xml", CustomDurationHandlerForFile, options);
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:ReadXMLFileWithMultipleProjects
        }

        [Test]
        public void CreateEmptyProjectToSaveToWithStreamOptions()
        {
            try
            {
                // ExStart:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
                // ExFor: Project.Save(Stream, MPPSaveOptions)
                // ExSummary: Shows how to save project into a stream as an MPP file by using MPP save options.
                using (var stream = new FileStream(OutDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
                {
                    var project = new Project();
                    var options = new MPPSaveOptions();

                    // by using of MPPSaveOptions we save it in MPP format
                    project.Save(stream, options);
                }

                // ExEnd:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void CreateEmptyProjectToSaveWithFileFormat()
        {
            try
            {
                // ExStart:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
                // ExFor: Project.Save(String,SaveOptions)
                // ExFor: Project.Save(String,MPPSaveOptions)
                // ExSummary: Shows how to save project as an MPP file.
                var project = new Project();
                var options = new MPPSaveOptions();
                project.Save(OutDir + "EmptyProjectSaveStream_out.xml", options);

                // ExEnd:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ReadCalendarProps()
        {
            // ExStart:ReadCalendarProps
            // ExFor: Project.Calendars
            // ExSummary: Shows how to read project calendars.
            var project = new Project(DataDir + "Project_GeneralCalendarProperties.xml");

            foreach (var calendar in project.Calendars)
            {
                if (calendar.Name == null)
                {
                    continue;
                }

                Console.WriteLine("UID : " + calendar.Uid + " Name: " + calendar.Name);

                // Show if it is has a base calendar
                Console.Write("Base Calendar : ");
                Console.WriteLine(calendar.IsBaseCalendar ? "Self" : calendar.BaseCalendar.Name);

                // Get Time in hours on each working day
                foreach (var wd in calendar.WeekDays)
                {
                    var ts = wd.GetWorkingTime();
                    Console.WriteLine("Day Type: " + wd.DayType + " Hours: " + ts);
                }
            }

            // ExEnd:ReadCalendarProps
        }

        [Test]
        public void SaveCostOverviewReport()
        {
            // ExStart:SaveCostOverviewReport
            // ExFor: Project.SaveReport(String,ReportType)
            // ExSummary: Shows how to save the project project report in PDF format.
            var project = new Project(DataDir + "OzBuild 16 Orig.mpp");
            project.SaveReport(OutDir + "CostOverview_out.pdf", ReportType.CostOverview);

            // ExEnd:SaveCostOverviewReport
        }

        [Test]
        public void ApplyCalculationModeManual()
        {
            // ExStart:ApplyCalculationModeManual
            // ExFor: Project.CalculationMode
            // ExSummary: Shows how to use project calculation mode.
            var project = new Project
            {
                CalculationMode = CalculationMode.Manual
            };

            // Set project start date and add new tasks
            project.Set(Prj.StartDate, new DateTime(2015, 4, 15));
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");

            // The necessary properties are set in manual mode
            Console.WriteLine("Task1.Id Equals 1 : {0} ", task1.Get(Tsk.Id).Equals(1));
            Console.WriteLine("Task1 OutlineLevel Equals 1 : {0} ", task1.Get(Tsk.OutlineLevel).Equals(1));
            Console.WriteLine("Task1 Start Equals 15/04/2015 08:00 AM : {0} ", task1.Get(Tsk.Start).Equals(new DateTime(2015, 4, 15, 8, 0, 0)));
            Console.WriteLine("Task1 Finish Equals 15/04/2015 05:00 PM : {0} ", task1.Get(Tsk.Finish).Equals(new DateTime(2015, 4, 15, 17, 0, 0)));
            Console.WriteLine("Task1 Duration Equals 1 day : {0} ", task1.Get(Tsk.Duration).ToString().Equals("1 day"));
            Console.WriteLine("Task2 Start Equals 15/04/2015 08:00 AM : {0} ", task2.Get(Tsk.Start).Equals(new DateTime(2015, 4, 15, 8, 0, 0)));
            Console.WriteLine("Task2 Finish Equals 15/04/2015 05:00 PM : {0} ", task2.Get(Tsk.Finish).Equals(new DateTime(2015, 4, 15, 17, 0, 0)));
            Console.WriteLine("Task2 Duration Equals 1 day : {0} ", task2.Get(Tsk.Duration).ToString().Equals("1 day"));

            // When we link two tasks together their dates are not recalculated in manual mode
            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            // Task 2 Start has not been changed
            Console.WriteLine("Task1 Start Equals Task2 Start : {0} ", task1.Get(Tsk.Start).Equals(task2.Get(Tsk.Start)));
            Console.WriteLine("Task1 Finish Equals Task2 Finish : {0} ", task1.Get(Tsk.Finish).Equals(task2.Get(Tsk.Finish)));

            // ExEnd:ApplyCalculationModeManual
        }

        [Test]
        public void ReadVbaProjectInformation()
        {
            // ExStart:ReadVbaProjectInformation
            // ExFor: Project.VbaProject
            // ExSummary: Shows how to read VBA project information.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("VbaProject.Name " + project.VbaProject.Name);
            Console.WriteLine("VbaProject.Description " + project.VbaProject.Description);
            Console.WriteLine("VbaProject.CompilationArguments" + project.VbaProject.CompilationArguments);
            Console.WriteLine("VbaProject.HelpContextId" + project.VbaProject.HelpContextId);
            Console.WriteLine("VbaProject.HelpFile" + project.VbaProject.HelpFile);

            // ExEnd:ReadVbaProjectInformation
        }

        public static object CustomDurationHandlerForStream(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Debug.Print("Object field : {0}, Invalid value : {1}", args.FieldName, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var newValue = Duration.ParseTimeSpan(duration);
            Debug.Print("New value : {0}", newValue);
            return newValue;
        }

        public static object CustomDurationHandlerForFile(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Debug.Print("Object field : {0}, Invalid value : {1}", args.FieldName, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var newValue = Duration.ParseTimeSpan(duration);
            Debug.Print("New value : {0}", newValue);
            return newValue;
        }

        public static string GetModifiedXml2(string dataDir)
        {
            // Open valid xml file and modify it
            using (TextReader reader = new StreamReader(dataDir + "Project.xml"))
            {
                var xml = reader.ReadToEnd();
                var regex = new Regex("PT(\\d+)H(\\d+)M(\\d+)S");
                return regex.Replace(xml, "**$1Hrs$2Mins$3Secs**");
            }
        }

        [Test]
        public void CreateEmptyProjectToSaveToStreamFormat()
        {
            // ExStart:CreateEmptyProjectToSaveToStream
            // ExFor: Project.Save(Stream, SaveFileFormat);
            // ExSummary: Shows how to save project into a stream as an XML MS Project file.
            var project = new Project();

            using (var stream = new FileStream(OutDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                // Write the stream into XML format
                project.Save(stream, SaveFileFormat.XML);
            }

            // ExEnd:CreateEmptyProjectToSaveToStream
        }

        [Test]
        public void CreateTaskBaseline()
        {
            // ExStart:CreateTaskBaseline
            // ExFor: Project.SetBaseline(BaselineType)
            // ExSummary: Shows how to create baselines for a whole project.
            var project = new Project();

            // Adding tasks
            project.RootTask.Children.Add("Task");
            project.RootTask.Children.Add("Task2");

            // Set baseline for specified tasks
            project.SetBaseline(BaselineType.Baseline);

            // ExEnd:CreateTaskBaseline
        }

        [Test]
        public void CreateTaskBaselineForTasks()
        {
            // ExStart:CreateTaskBaselineForTasks
            // ExFor: Project.SetBaseline(BaselineType,IEnumerable{Aspose.Tasks.Task})
            // ExSummary: Shows how to create set baselines for specific tasks.
            var project = new Project();

            // Adding tasks
            var task = project.RootTask.Children.Add("Task");
            var task2 = project.RootTask.Children.Add("Task2");

            // Set baseline for specified tasks
            project.SetBaseline(BaselineType.Baseline, new[] { task, task2 });

            // ExEnd:CreateTaskBaselineForTasks
        }

        [Test]
        public void AddNewTask()
        {
            // ExStart:AddNewTask
            // ExFor: Project.RootTask
            // ExSummary: Shows how to add a task into a project by using the root project task. 
            var project = new Project();

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.DurationFormat, TimeUnitType.Day);
            task.Set(Tsk.Start, new DateTime(2012, 8, 23, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour));
            task.Set(Tsk.ActualStart, new DateTime(2012, 8, 23, 8, 0, 0));

            project.Save(OutDir + "AddNewTask_out.xml", SaveFileFormat.XML);

            // ExEnd:AddNewTask        
        }

        [Test]
        public void CreateTaskLinks()
        {
            // ExStart:CreateTaskLinks
            // ExFor: Project.TaskLinks
            // ExSummary: Shows how to create task links.
            var project = new Project();

            // Add new tasks
            var pred = project.RootTask.Children.Add("Task 1");
            var succ = project.RootTask.Children.Add("Task 2");

            // Link tasks
            project.TaskLinks.Add(pred, succ);

            foreach (var link in project.TaskLinks)
            {
                Console.WriteLine("Predecessor Task: " + link.PredTask);
                Console.WriteLine("Successor Task: " + link.SuccTask);
                Console.WriteLine("LagFormat: " + link.LagFormat);
                Console.WriteLine("LinkType: " + link.LinkType);
                Console.WriteLine("LinkLag: " + link.LinkLag);
                Console.WriteLine("CrossProjectName: " + link.CrossProjectName);
                Console.WriteLine("IsCrossProject: " + link.IsCrossProject);
            }

            // ExEnd:CreateTaskLinks
        }

        [Test]
        public static void WorkWithPredecessors()
        {
            // ExStart:WorkWithPredecessors
            // ExFor: Project.GetPredecessors(Task)
            // ExSummary: Shows how to get predecessors for the specific task.
            var project = new Project(DataDir + "GetPredecessorSuccessorTasks.mpp");
            var task = project.RootTask.Children.GetById(10);

            var predecessors = project.GetPredecessors(task);

            // Display names of predecessor and successor tasks
            foreach (var predecessor in predecessors)
            {
                Console.WriteLine("Predecessor " + predecessor.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor " + predecessor.SuccTask.Get(Tsk.Name));
            }

            // ExEnd:WorkWithPredecessors
        }

        // ExStart:CreateResources
        // ExFor: Project.Resources
        // ExSummary: Shows how to create project resources.
        [Test] // ExSkip
        public void CreateResources()
        {
            var project = new Project(DataDir + "project-sort.mpp");

            // Add a resource
            project.Resources.Add("Rsc");

            List<Resource> resources = project.Resources.ToList();
            resources.Sort(new RscNameComparer());

            foreach (var rsc in resources)
            {
                Console.WriteLine(rsc);
            }

            project.Save(OutDir + "CreateResources_out.xml", SaveFileFormat.XML);
        }

        private class RscNameComparer : IComparer<Resource>
        {
            public int Compare(Resource x, Resource y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }

                if (x == null)
                {
                    return -1;
                }

                if (y == null)
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(x.Get(Rsc.Name)))
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(y.Get(Rsc.Name)))
                {
                    return -1;
                }

                return string.Compare(x.Get(Rsc.Name), y.Get(Rsc.Name), StringComparison.Ordinal);
            }
        }

        // ExEnd:CreateResources

        public static string GetModifiedXml(string dataDir)
        {
            // Open valid xml file and modify it
            using (TextReader reader = new StreamReader(dataDir + "IgnoreInvalidCharacters.xml"))
            {
                var xml = reader.ReadToEnd();
                var regex = new Regex("PT(\\d+)H(\\d+)M(\\d+)S");
                return regex.Replace(xml, "**$1Hrs$2Mins$3Secs**");
            }
        }
    }
}
