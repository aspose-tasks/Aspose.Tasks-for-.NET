namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using RiskAnalysis;

    [TestFixture]
    public class ExRiskItemStatisticsCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithRiskItemStatisticsCollection()
        {
            //ExStart
            //ExFor: RiskAnalysis.RiskItemStatisticsCollection
            //ExFor: RiskAnalysis.RiskItemStatisticsCollection.Get(Task)
            //ExFor: RiskAnalysis.RiskItemStatisticsCollection.GetEnumerator
            //ExSummary: Shows how to work with collection of risk statistics.
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
            
            var analyzer = new RiskAnalyzer(settings);
            var analysisResult = analyzer.Analyze(project);
            
            // iterate over all statistic items
            RiskItemStatisticsCollection statistics = analysisResult
                .GetRiskItems(RiskItemType.EarlyFinish);

            foreach (var statistic in statistics)
            {
                Console.WriteLine("Short statistic: " + statistic);
                Console.WriteLine();
                Console.WriteLine("Statistic details: ");
                Console.WriteLine("Item Type: {0}", statistic.ItemType);
                Console.WriteLine("Expected value: {0}", statistic.ExpectedValue);
                Console.WriteLine("StandardDeviation: {0}", statistic.StandardDeviation);
                Console.WriteLine("10% Percentile: {0}", statistic.GetPercentile(10));
                Console.WriteLine("50% Percentile: {0}", statistic.GetPercentile(50));
                Console.WriteLine("90% Percentile: {0}", statistic.GetPercentile(90));
                Console.WriteLine("Minimum: {0}", statistic.Minimum);
                Console.WriteLine("Maximum: {0}", statistic.Maximum);
            }
            
            // or get a specific stats
            var itemStatistics = analysisResult
                .GetRiskItems(RiskItemType.EarlyFinish)
                .Get(project.RootTask);

            Console.WriteLine("Print the specific statistic: ");
            Console.WriteLine("Expected value: {0}", itemStatistics.ExpectedValue);
            Console.WriteLine("StandardDeviation: {0}", itemStatistics.StandardDeviation);
            Console.WriteLine("10% Percentile: {0}", itemStatistics.GetPercentile(10));
            Console.WriteLine("50% Percentile: {0}", itemStatistics.GetPercentile(50));
            Console.WriteLine("90% Percentile: {0}", itemStatistics.GetPercentile(90));
            Console.WriteLine("Minimum: {0}", itemStatistics.Minimum);
            Console.WriteLine("Maximum: {0}", itemStatistics.Maximum);
            //ExEnd
        }
    }
}