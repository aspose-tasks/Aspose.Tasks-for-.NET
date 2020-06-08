namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExRate : ApiExampleBase
    {
        [Test]
        public void WorkWithRate()
        {
            // ExStart
            // ExFor: Rate
            // ExFor: Rate.CostPerUse
            // ExFor: Rate.OvertimeRate
            // ExFor: Rate.OvertimeRateFormat
            // ExFor: Rate.RatesFrom
            // ExFor: Rate.RatesTo
            // ExFor: Rate.RateTable
            // ExFor: Rate.StandardRate
            // ExFor: Rate.StandardRateFormat
            // ExSummary: Shows how to work with resource rates.
            var project = new Project(DataDir + "Project1.mpp");
            
            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);
            resource.Set(Rsc.Work, project.GetDuration(2d, TimeUnitType.Hour));
            resource.Set(Rsc.StandardRate, 20m);

            var rate1 = resource.Rates.Add(new DateTime(2019, 1, 1, 8, 0, 0));
            rate1.RateTable = RateType.A;
            rate1.RatesFrom = new DateTime(2019, 1, 1, 8, 0, 0);
            rate1.RatesTo = new DateTime(2019, 11, 11, 17, 0, 0);
            rate1.StandardRate = 5m;
            rate1.StandardRateFormat = RateFormatType.Hour;
            rate1.OvertimeRate = 10m;
            rate1.OvertimeRateFormat = RateFormatType.Hour;

            var rate2 = resource.Rates.Add(new DateTime(2019, 11, 12, 8, 0, 0));
            rate2.RatesTo = new DateTime(2019, 12, 31, 17, 0, 0);
            rate2.StandardRate = 10m;
            rate2.StandardRateFormat = RateFormatType.Hour;
            rate2.CostPerUse = 2m;
            
            // work with the project...
            
            // ExEnd
        }
    }
}