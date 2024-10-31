namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExAvailabilityPeriod : ApiExampleBase
    {
        // ExStart
        // ExFor: AvailabilityPeriod
        // ExFor: AvailabilityPeriod.AvailableFrom
        // ExFor: AvailabilityPeriod.AvailableTo
        // ExFor: AvailabilityPeriod.AvailableUnits
        // ExSummary: Shows how to create availability periods for a resource.
        [Test] // ExSkip
        public void WorkWithAvailabilityPeriod()
        {
            var project = new Project();
            var resource = project.Resources.Add("Work Resource");

            // Add availability periods to new resource
            IEnumerable<AvailabilityPeriod> periods = GetPeriods();
            foreach (var period in periods)
            {
                resource.AvailabilityPeriods.Add(period);
            }

            foreach (var period in resource.AvailabilityPeriods)
            {
                Console.WriteLine("Available From: " + period.AvailableFrom);
                Console.WriteLine("Available To: " + period.AvailableTo);
                Console.WriteLine("Available Units: " + period.AvailableUnits);
                Console.WriteLine();
            }
        }

        private static IEnumerable<AvailabilityPeriod> GetPeriods()
        {
            var periods = new List<AvailabilityPeriod>(2);
            var period = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2011, 12, 12),
                AvailableTo = new DateTime(2013, 12, 12),
                AvailableUnits = 0.99
            };

            periods.Add(period);

            var period2 = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2013, 12, 12),
                AvailableTo = new DateTime(2015, 12, 12),
                AvailableUnits = 0.94
            };
            periods.Add(period2);
            return periods;
        }

        // ExEnd
    }
}