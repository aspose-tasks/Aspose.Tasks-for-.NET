namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using RiskAnalysis;

    [TestFixture]
    public class ExRiskItemStatistics : ApiExampleBase
    {
        [Test]
        public void WorkWithRiskItemStatistics()
        {
            //ExStart
            //ExFor: RiskItemStatistics
            //ExFor: RiskItemStatistics.ExpectedValue
            //ExFor: RiskItemStatistics.GetPercentile(Int32)
            //ExFor: RiskItemStatistics.ItemType
            //ExFor: RiskItemStatistics.Maximum
            //ExFor: RiskItemStatistics.Minimum
            //ExFor: RiskItemStatistics.StandardDeviation
            //ExFor: RiskItemStatistics.ToString
            //ExSummary: Shows how to calculate statistic of risks.
            var settings = new RiskAnalysisSettings();
            settings.IterationsCount = 200;

            var project = new Project(DataDir + "Software Development Plan-1.mpp");
            var task = project.RootTask.Children.GetById(17);

            // Initialize a risk pattern
            var pattern = new RiskPattern(task);
            // Select a distribution type for the random number generator to generate possible values from (only two types currently supported, namely normal and uniform)            
            // For more details see here: https://en.wikipedia.org/wiki/Normal_distribution)
            pattern.Distribution = ProbabilityDistributionType.Normal;
            // Set the percentage of the most likely task duration which can happen in the best possible project scenario 
            // The default value is 75, which means that if the estimated specified task duration is 4 days then the optimistic duration will be 3 days
            pattern.Optimistic = 70;
            // Set the percentage of the most likely task duration which can happen in the worst possible project scenario 
            // The default value is 125, which means that if the estimated specified task duration is 4 days then the pessimistic duration will be 5 days.
            pattern.Pessimistic = 130;
            // Set a confidence level that correspond to the percentage of the time the actual values will be within optimistic and pessimistic estimates. 
            // You can think of it as a value of standard deviation: the more uncertain about your estimates you are, the more the value of standard deviation used in random number generator is
            pattern.ConfidenceLevel = ConfidenceLevel.CL75;
            settings.Patterns.Add(pattern);
            
            // Analyze the project risks
            var analyzer = new RiskAnalyzer(settings);
            var analysisResult = analyzer.Analyze(project);
            RiskItemStatistics statistics = analysisResult
                .GetRiskItems(RiskItemType.EarlyFinish)
                .Get(project.RootTask);

            Console.WriteLine("Short statistic: " + statistics);
            Console.WriteLine();
            Console.WriteLine("Statistic details: ");
            Console.WriteLine("Item Type: {0}", statistics.ItemType);
            Console.WriteLine("Expected value: {0}", statistics.ExpectedValue);
            Console.WriteLine("StandardDeviation: {0}", statistics.StandardDeviation);
            Console.WriteLine("10% Percentile: {0}", statistics.GetPercentile(10));
            Console.WriteLine("50% Percentile: {0}", statistics.GetPercentile(50));
            Console.WriteLine("90% Percentile: {0}", statistics.GetPercentile(90));
            Console.WriteLine("Minimum: {0}", statistics.Minimum);
            Console.WriteLine("Maximum: {0}", statistics.Maximum);
            //ExEnd
        }
    }
}