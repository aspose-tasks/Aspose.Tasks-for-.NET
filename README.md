# .NET API to Manipulate Project Files

[Aspose.Tasks for .NET](https://products.aspose.com/tasks/net) is a C# library that assists developers in generating, editing, rendering & conversion of Project files without needing Microsoft Project®.

Aspose.Tasks for .NET on premise API enables you to work with projects, formulas, calendars, calendar exceptions, tasks, task links, task baselines, project resources, resource assignments, currencies, handling exceptions, reporting services, and project risk analysis (Monte Carlo Simulation).

<p align="center">

  <a title="Download complete Aspose.Tasks for .NET source code" href="https://github.com/aspose-tasks/Aspose.Tasks-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for live demos hosted at https://products.aspose.app/tasks/family.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features
[Plugins](Plugins)  | Plugins related to Aspose.Tasks for .NET



## Project File Processing via .NET

- Set project schedule type, start date & finish date.
- Modify project standard rate, overtime rate, task type, fixed cost accrual etc.
- Manage [project extended attributes](https://docs.aspose.com/tasks/net/working-with-extended-attributes-of-a-project/).
- Define [project calendar](https://docs.aspose.com/tasks/net/creating-updating-and-removing-calendar/) and weekdays.
- Task baseline scheduling and duration.
- Work with task constraints.
- Apply links among tasks.
- Create task milestone, estimated critical or effort driven tasks.
- Manage resource cost and variance.
- Assignment [cost](https://docs.aspose.com/tasks/net/managing-task-costs/) and [budget](https://docs.aspose.com/tasks/net/assignment-budget/).
- Encode MPX files.
- Comprehensive project reporting (15+ types of reports).

## Read & Write Project Formats

**Microsoft Project:** MPP, MPT, MPX, XML

## Save Projects As

**Primavera:** P6 XML, PM XER
**Microsoft Office:** XLSX
**Fixed Layout:** PDF
**Images:** JPEG, PNG, BMP, TIFF, SVG
**Text:** TXT
**Others:** HTML

## Platform Independence

You can use Aspose.Tasks for .NET to build any type of a 32-bit or 64-bit .NET application including ASP.NET, WCF, WinForms, WPF etc. It is possible to use Aspose.Tasks for .NET via COM Interop from ASP, Perl, PHP and Python. You can also use Aspose.Tasks for .NET to build applications with Mono.

## Get Started with Aspose.Tasks for .NET

Are you ready to give Aspose.Tasks for .NET a try? Simply execute `Install-Package Aspose.Tasks` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.Tasks for .NET and want to upgrade the version, please execute `Update-Package Aspose.Tasks` to get the latest version.

## Convert Microsoft Project MPP File to Primavera MPX Format

```csharp
Project project = new Project(dir + "template.mpp");

// save project in desired format
project.Save(dir + "output.xml", SaveFileFormat.MPX);
```

## Create a Project from Scratch

```csharp
// create project instance
Project project = new Project();

// add task, sub task and save project
Task task = project.RootTask.Children.Add("Summary1");
Task subtask = task.Children.Add("Subtask1");

project.Save(dir + "output.xml", SaveFileFormat.XML);
```
------------
##### [Demos](https://products.aspose.app/tasks/family):
- [Conversion](https://products.aspose.app/tasks/conversion)
- [Viewer](https://products.aspose.app/tasks/viewer)
- [Metadata](https://products.aspose.app/tasks/metadata)
- [Downloader](https://products.aspose.app/tasks/downloader)
------------
[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/tasks/net) | [Docs](https://docs.aspose.com/tasks/net/) | [Demos](https://products.aspose.app/tasks/family) | [API Reference](https://apireference.aspose.com/tasks/net) | [Examples](https://github.com/aspose-tasks/Aspose.Tasks-for-.NET) | [Blog](https://blog.aspose.com/category/tasks/) | [Free Support](https://forum.aspose.com/c/tasks) |  [Temporary License](https://purchase.aspose.com/temporary-license)
