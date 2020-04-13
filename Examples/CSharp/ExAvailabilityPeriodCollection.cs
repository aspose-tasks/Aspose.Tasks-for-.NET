namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExAvailabilityPeriodCollection : ApiExampleBase
    {
        //ExStart
        //ExFor: AvailabilityPeriodCollection
        //ExFor: AvailabilityPeriodCollection.Add(AvailabilityPeriod)
        //ExFor: AvailabilityPeriodCollection.Clear
        //ExFor: AvailabilityPeriodCollection.Contains(AvailabilityPeriod)
        //ExFor: AvailabilityPeriodCollection.CopyTo(AvailabilityPeriod[],System.Int32)
        //ExFor: AvailabilityPeriodCollection.Count
        //ExFor: AvailabilityPeriodCollection.GetEnumerator
        //ExFor: AvailabilityPeriodCollection.IndexOf(AvailabilityPeriod)
        //ExFor: AvailabilityPeriodCollection.Insert(System.Int32,AvailabilityPeriod)
        //ExFor: AvailabilityPeriodCollection.IsReadOnly
        //ExFor: AvailabilityPeriodCollection.Item(System.Int32)
        //ExFor: AvailabilityPeriodCollection.ParentResource
        //ExFor: AvailabilityPeriodCollection.Remove(AvailabilityPeriod)
        //ExFor: AvailabilityPeriodCollection.RemoveAt(System.Int32)
        //ExSummary: Shows how to work with availability period collection of resource.
        [Test] //ExSkip
        public void WorkWithAvailabilityPeriodCollection()
        {
            var project = new Project(DataDir + "UpdateResourceData.mpp");
            var resource = project.Resources.GetById(1);
            
            resource.AvailabilityPeriods.Clear();

            // Add availability periods (2012 and 2014 years) to the new resource
            IEnumerable<AvailabilityPeriod> periods = this.GetPeriods();
            foreach (AvailabilityPeriod period in periods)
            {
                if (!resource.AvailabilityPeriods.IsReadOnly)
                {
                    resource.AvailabilityPeriods.Add(period);
                }
            }
            
            var period2013 = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2013, 1, 1),
                AvailableTo = new DateTime(2013, 12, 12),
                AvailableUnits = 0.81
            };

            if (!resource.AvailabilityPeriods.Contains(period2013))
            {
                resource.AvailabilityPeriods.Insert(1, period2013);
            }

            Console.WriteLine("Count of availability periods: " + resource.AvailabilityPeriods.Count);
            foreach (AvailabilityPeriod period in resource.AvailabilityPeriods)
            {
                Console.WriteLine("Available From: " + period.AvailableFrom);
                Console.WriteLine("Available To: " + period.AvailableTo);
                Console.WriteLine("Available Units: " + period.AvailableUnits);
                Console.WriteLine();
            }

            AvailabilityPeriod[] periodsToCopy = new AvailabilityPeriod[resource.AvailabilityPeriods.Count];
            resource.AvailabilityPeriods.CopyTo(periodsToCopy, 0);

            var otherResource = project.Resources.GetById(2);
            otherResource.AvailabilityPeriods.Clear();
            foreach (var period in periodsToCopy)
            {
                otherResource.AvailabilityPeriods.Add(period);
            }
            
            var period2015 = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2015, 1, 1),
                AvailableTo = new DateTime(2015, 12, 12),
                AvailableUnits = 0.50
            };
            
            var period2016 = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2016, 1, 1),
                AvailableTo = new DateTime(2016, 12, 12),
                AvailableUnits = 0.53
            };

            if (otherResource.AvailabilityPeriods.IndexOf(period2015) < 0)
            {
                otherResource.AvailabilityPeriods.Add(period2015);
            }
            
            if (otherResource.AvailabilityPeriods.IndexOf(period2016) < 0)
            {
                otherResource.AvailabilityPeriods.Add(period2016);
            }
            
            // update available units for period of 2014 year
            otherResource
                .AvailabilityPeriods[otherResource.AvailabilityPeriods.Count - 2]
                .AvailableUnits = 0.90;

            // remove period of 2013
            otherResource.AvailabilityPeriods.Remove(period2013);
            
            // remove period of 2011
            otherResource.AvailabilityPeriods.RemoveAt(0);
            
            Console.WriteLine("Print resource availability periods of the resource: " + otherResource.Get(Rsc.Name));
            Console.WriteLine("Count of availability periods: " + resource.AvailabilityPeriods.Count);
            foreach (AvailabilityPeriod period in resource.AvailabilityPeriods)
            {
                Console.WriteLine("Available From: " + period.AvailableFrom);
                Console.WriteLine("Available To: " + period.AvailableTo);
                Console.WriteLine("Available Units: " + period.AvailableUnits);
                Console.WriteLine();
            }
        }
        
        private IEnumerable<AvailabilityPeriod> GetPeriods()
        {
            var periods = new List<AvailabilityPeriod>();
            var period = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2012, 1, 1),
                AvailableTo = new DateTime(2012, 12, 12),
                AvailableUnits = 0.99
            };
            periods.Add(period);
            
            var period2 = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2014, 1, 1),
                AvailableTo = new DateTime(2014, 12, 12),
                AvailableUnits = 0.94
            };
            periods.Add(period2);
            return periods;
        }
        //ExEnd
    }
}