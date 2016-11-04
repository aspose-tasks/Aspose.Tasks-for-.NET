using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    public class ReadFilterCriteriaData
    {
        public static void Run()
        {
            // ExStart:ReadFilterCriteriaData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            Project project = new Project(dataDir + "Project2003.mpp");

            Filter filter = project.TaskFilters.ToList()[1];
            Console.WriteLine(filter.Criteria.CriteriaRows.Count);
            Console.WriteLine(filter.Criteria.Operation.ToString());
            
            FilterCriteria criteria1 = filter.Criteria.CriteriaRows[0];
            Console.WriteLine(criteria1.Test.ToString());
            Console.WriteLine(criteria1.Field.ToString());
            Console.WriteLine(criteria1.Values[0].ToString());            
            
            FilterCriteria criteria2 = filter.Criteria.CriteriaRows[1];
            Console.WriteLine(criteria2.Operation.ToString());
            Console.WriteLine(criteria2.CriteriaRows.Count);            
            
            FilterCriteria criteria21 = criteria2.CriteriaRows[0];
            Console.WriteLine(criteria21.Test.ToString());
            Console.WriteLine(criteria21.Field.ToString());
            Console.WriteLine(criteria21.Values[0].ToString());            
            
            FilterCriteria criteria22 = criteria2.CriteriaRows[1];
            Console.WriteLine(criteria22.Test.ToString());
            Console.WriteLine(criteria22.Field.ToString());
            Console.WriteLine(criteria22.Values[0].ToString());            
            Console.WriteLine(filter.Criteria);
            // ExEnd:ReadFilterCriteriaData
        }
    }
}