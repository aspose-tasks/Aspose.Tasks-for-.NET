namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExRateCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithRateCollection()
        {
            // ExStart
            // ExFor: RateCollection
            // ExFor: RateCollection.Add(DateTime)
            // ExFor: RateCollection.Add(DateTime,RateType)
            // ExFor: RateCollection.Count
            // ExFor: RateCollection.GetEnumerator
            // ExFor: RateCollection.IsReadOnly
            // ExFor: RateCollection.Item(RateType)
            // ExFor: RateCollection.ParentResource
            // ExFor: RateCollection.Remove(Rate)
            // ExFor: RateCollection.ToList
            // ExFor: RateCollection.ToList(RateType)
            // ExFor: RateByDateCollection
            // ExFor: RateType
            // ExSummary: Shows how to work with rate collections.
            var project = new Project(DataDir + "Project1.mpp");

            var resource = project.Resources.Add("Test Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);
            resource.Set(Rsc.Work, project.GetDuration(2d, TimeUnitType.Hour));
            resource.Set(Rsc.StandardRate, 20m);

            var rate1 = resource.Rates.Add(new DateTime(2019, 1, 1, 8, 0, 0));
            rate1.RatesTo = new DateTime(2019, 11, 11, 17, 0, 0);
            rate1.StandardRate = 5m;
            rate1.StandardRateFormat = RateFormatType.Hour;

            var rate2 = resource.Rates.Add(new DateTime(2019, 11, 12, 8, 0, 0), RateType.B);
            rate2.RatesTo = new DateTime(2019, 12, 31, 17, 0, 0);
            rate2.StandardRate = 10m;
            rate2.StandardRateFormat = RateFormatType.Hour;

            Console.WriteLine("Print rates of '{0}' resource: ", resource.Rates.ParentResource.Get(Rsc.Name));
            Console.WriteLine("Count of rates: {0}", resource.Rates.Count);
            Console.WriteLine("Is rate collection read-only: {0}", resource.Rates.IsReadOnly);
            foreach (KeyValuePair<RateType, RateByDateCollection> sortedRates in resource.Rates)
            {
                foreach (KeyValuePair<DateTime, Rate> pair in sortedRates.Value)
                {
                    var rate = pair.Value;
                    Console.WriteLine("Rates From: " + rate.RatesFrom);
                    Console.WriteLine("Rates To: " + rate.RatesTo);
                    Console.WriteLine("Rate Table: " + rate.RateTable);
                    Console.WriteLine();
                }
            }

            // get the latest rate by index access
            var rateToUpdate = resource.Rates[RateType.B][new DateTime(2019, 11, 12, 8, 0, 0)];
            rateToUpdate.RatesTo = new DateTime(2020, 12, 31, 17, 0, 0);
            Console.WriteLine("Rates From: " + rateToUpdate.RatesFrom);
            Console.WriteLine("Rates To: " + rateToUpdate.RatesTo);

            // ...
            // work with rates
            // ...

            // remove all rates of type A
            List<Rate> rates = resource.Rates.ToList(RateType.A);
            for (var i = 0; i < rates.Count; i++)
            {
                var rateToRemove = rates[i];
                resource.Rates.Remove(rateToRemove);
            }

            // transform the rate collection into a flat list
            Console.WriteLine("Iterate over the rates after remove the A-typed values: ");
            List<Rate> list = resource.Rates.ToList();
            foreach (var rt in list)
            {
                Console.WriteLine("Rates From: " + rt.RatesFrom);
                Console.WriteLine("Rates To: " + rt.RatesTo);
                Console.WriteLine("Rate Table: " + rt.RateTable);
            }

            // ExEnd
        }
    }
}