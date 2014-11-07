//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;
using System.Collections.Generic;

namespace WritingUpdatedResourceData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            string file = dataDir+ "project.mpp"; // Test file with one rsc to update
            // File to write test project
            string resultFile = dataDir+ "output.mpp";
            ProjectReader reader = new ProjectReader();
            // Read file with one rsc
            Project project = reader.Read(file); // Attached project

            // Add new resource
            Resource rsc = GetTestResource();

            project.Resources.Add(rsc);

            project.CalcResourceIds();
            project.CalcResourceUids();

            // Add several resources again
            int count = 5;
            for (int i = 0; i < count; i++)
            {
                Resource res = GetTestResource();
                res.Name += (i + 1).ToString();
                if (i == 4)

                { res.Type = ResourceType.Material; res.MaterialLabel = "Label for material"; }
                project.Resources.Add(res);
            }

            project.CalcResourceIds();
            project.CalcResourceUids();

            // Add new rate to new resource
            rsc.Rates = new List<Rate>();
            Rate rate = GetTestRate();
            rsc.Rates.Add(rate);

            // Add availability periods to new resource
           List<AvailabilityPeriod> periods = GetTestAvailPeriods();
            rsc.AvailabilityPeriods = periods;

            // Update existent rescource
            string newName = "Updated name";
            string newEmail = "Updated@mail";
            decimal newRate = new decimal(123.45);

            Resource resource = project.GetResourceByUid(1);
            resource.Name = newName;
            resource.EmailAddress = newEmail;
            resource.StandardRate = newRate;

            //Save the Project
            project.Save(dataDir+ "Project.Mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP);
            
            
        }

        public static Resource GetTestResource()
        {
            Resource rsc = new Resource("New resource ");
            rsc.StandardRate = new decimal(50);
            rsc.StandardRateFormat = RateFormatType.Hour;
            rsc.OvertimeRate = new decimal(70);
            rsc.OvertimeRateFormat = RateFormatType.Hour;
            rsc.MaxUnits = 1;
            rsc.AccrueAt = CostAccrualType.End;
            rsc.EmailAddress = "email@d.com";
            rsc.Initials = "R.S.C.";
            rsc.Type = ResourceType.Work;
            rsc.Hyperlink = "link.org";
            rsc.HyperlinkAddress = "http://www.microsoft.com";
            rsc.HyperlinkSubAddress = "subaddress";
            rsc.Group = "Group";
            rsc.Code = "Rsc Code";
            rsc.NtAccount = "NtAccount";
            return rsc;
        }
        public static Rate GetTestRate()
        {
            Rate r = new Rate();
            r.StandardRate = 99;
            r.StandardRateFormat = RateFormatType.Day;
            r.RatesFrom = new DateTime(2011, 11, 11);
            r.RatesTo = new DateTime(2012, 11, 11);
            r.OvertimeRate = 19;
            r.OvertimeRateFormat = RateFormatType.Hour;
            r.RateTable = RateType.A;
            return r;
        }
        public static List<AvailabilityPeriod> GetTestAvailPeriods()
        {
            List<AvailabilityPeriod> arr = new List<AvailabilityPeriod>(2);
            AvailabilityPeriod a = new AvailabilityPeriod();
            a.AvailableFrom = new DateTime(2011, 12, 12);
            a.AvailableTo = new DateTime(2013, 12, 12);
            a.AvailableUnits = 0.99; arr.Add(a);
            a = new AvailabilityPeriod();
            a.AvailableFrom = new DateTime(2013, 12, 12);
            a.AvailableTo = new DateTime(2015, 12, 12);
            a.AvailableUnits = 0.94; arr.Add(a);
            return arr;
        }

       
    }
}