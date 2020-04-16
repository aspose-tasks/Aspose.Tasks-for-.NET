namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using RiskAnalysis;

    [TestFixture]
    public class ExRiskPatternCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithRiskPatternCollection()
        {
            //ExStart
            //ExFor: RiskPatternCollection
            //ExFor: RiskPatternCollection.Add(RiskPattern)
            //ExFor: RiskPatternCollection.Clear
            //ExFor: RiskPatternCollection.Contains(RiskPattern)
            //ExFor: RiskPatternCollection.CopyTo(RiskPattern[],Int32)
            //ExFor: RiskPatternCollection.Count
            //ExFor: RiskPatternCollection.GetEnumerator
            //ExFor: RiskPatternCollection.IsReadOnly
            //ExFor: RiskPatternCollection.Item(Task)
            //ExFor: RiskPatternCollection.Remove(RiskPattern)
            //ExSummary: Shows how to work with risk pattern collections.
            var settings = new RiskAnalysisSettings();
            // Set number of iterations for Monte Carlo simulation (the default value is 100).
            settings.IterationsCount = 200;

            var project = new Project(DataDir + "Software Development Plan-1.mpp");
            var task1 = project.RootTask.Children.GetById(17);
            var task2 = project.RootTask.Children.GetById(18);
            
            // as far as RiskPatternCollection is not a read-only
            Console.WriteLine("Is pattern collection read-only?: " + settings.Patterns.IsReadOnly);

            // one can add new patterns 
            var pattern1 = new RiskPattern(task1);
            pattern1.Distribution = ProbabilityDistributionType.Normal;
            pattern1.Optimistic = 60;
            pattern1.Pessimistic = 140;
            pattern1.ConfidenceLevel = ConfidenceLevel.CL75;
            var pattern2 = new RiskPattern(task2);
            pattern2.Distribution = ProbabilityDistributionType.Normal;
            pattern2.Optimistic = 70;
            pattern2.Pessimistic = 130;
            pattern2.ConfidenceLevel = ConfidenceLevel.CL75;

            settings.Patterns.Add(pattern1);
            settings.Patterns.Add(pattern2);

            // iterate over added patterns
            Console.WriteLine("Patterns count: " + settings.Patterns.Count);
            foreach (var pattern in settings.Patterns)
            {
                Console.WriteLine("Task: " + pattern.Task);
                Console.WriteLine("Distribution: " + pattern.Distribution);
                Console.WriteLine("Optimistic: " + pattern.Optimistic);
                Console.WriteLine("Pessimistic: " + pattern.Pessimistic);
                Console.WriteLine("Confidence Level: " + pattern.ConfidenceLevel);
                Console.WriteLine();
            }
            
            // edit the pattern in the collection by using index access
            settings.Patterns[task1].Optimistic = 70;
            settings.Patterns[task1].Optimistic = 140;
            
            // check patterns after edits
            Console.WriteLine("Print edited patterns: ");
            foreach (var pattern in settings.Patterns)
            {
                Console.WriteLine("Task: " + pattern.Task);
                Console.WriteLine("Distribution: " + pattern.Distribution);
                Console.WriteLine("Optimistic: " + pattern.Optimistic);
                Console.WriteLine("Pessimistic: " + pattern.Pessimistic);
                Console.WriteLine("Confidence Level: " + pattern.ConfidenceLevel);
                Console.WriteLine();
            }
            
            // we can remove the pattern
            Console.WriteLine("Removing the first pattern...");
            settings.Patterns.Remove(pattern1);
            // check that pattern not in the collection
            Console.WriteLine("Is collection contains the first pattern?: " + settings.Patterns.Contains(pattern1));
            
            Assert.IsFalse(settings.Patterns.Contains(pattern1)); //ExSkip

            // one can clear the collection in two ways
            bool deleteOneByOne = true;
            if (deleteOneByOne)
            {
                // copy patterns into the array and delete them one by one
                RiskPattern[] patterns = new RiskPattern[settings.Patterns.Count];
                settings.Patterns.CopyTo(patterns, 0);
                foreach (var pattern in patterns)
                {
                    settings.Patterns.Remove(pattern);
                }
            }
            else
            {
                // or one can clear a pattern collection completely
                settings.Patterns.Clear();
            }
            //ExEnd
        }
    }
}