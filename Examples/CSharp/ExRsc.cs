namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Util;

    [TestFixture]
    public class ExRsc : ApiExampleBase
    {
        [Test]
        public void GetSetAccrueAt()
        {
            // ExStart
            // ExFor: Rsc.AccrueAt
            // ExSummary: Shows how to read/write Rsc.AccrueAt property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.AccrueAt, CostAccrualType.End);

            Console.WriteLine("Accrue At: " + resource.Get(Rsc.AccrueAt));

            // ExEnd
        }

        [Test]
        public void GetSetActiveDirectoryGuid()
        {
            // ExStart
            // ExFor: Rsc.ActiveDirectoryGuid
            // ExSummary: Shows how to read/write Rsc.ActiveDirectoryGuid property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActiveDirectoryGuid, "8aede269-c574-4a8b-aa74-32bc877a2aef");

            Console.WriteLine("Active Directory Guid: " + resource.Get(Rsc.ActiveDirectoryGuid));

            // ExEnd
        }

        [Test]
        public void GetSetActualCost()
        {
            // ExStart
            // ExFor: Rsc.ActualCost
            // ExSummary: Shows how to read/write Rsc.ActualCost property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActualCost, 10m);

            Console.WriteLine("Actual Cost: " + resource.Get(Rsc.ActualCost));

            // ExEnd
        }

        [Test]
        public void GetSetActualOvertimeCost()
        {
            // ExStart
            // ExFor: Rsc.ActualOvertimeCost
            // ExSummary: Shows how to read/write Rsc.ActualOvertimeCost property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActualOvertimeCost, 10m);

            Console.WriteLine("Actual Overtime Cost: " + resource.Get(Rsc.ActualOvertimeCost));

            // ExEnd
        }

        [Test]
        public void GetSetActualOvertimeWork()
        {
            // ExStart
            // ExFor: Rsc.ActualOvertimeWork
            // ExSummary: Shows how to read/write Rsc.ActualOvertimeWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActualOvertimeWork, project.GetWork(1));

            Console.WriteLine("Actual Overtime Work: " + resource.Get(Rsc.ActualOvertimeWork));

            // ExEnd
        }

        [Test]
        public void GetSetActualOvertimeWorkProtected()
        {
            // ExStart
            // ExFor: Rsc.ActualOvertimeWorkProtected
            // ExSummary: Shows how to read/write Rsc.ActualOvertimeWorkProtected property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActualOvertimeWorkProtected, project.GetWork(1));

            Console.WriteLine("Actual Overtime Work Protected: " + resource.Get(Rsc.ActualOvertimeWorkProtected));

            // ExEnd
        }

        [Test]
        public void GetSetActualWork()
        {
            // ExStart
            // ExFor: Rsc.ActualWork
            // ExSummary: Shows how to read/write Rsc.ActualWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActualWork, project.GetWork(1));

            Console.WriteLine("Actual Work: " + resource.Get(Rsc.ActualWork));

            // ExEnd
        }

        [Test]
        public void GetSetActualWorkProtected()
        {
            // ExStart
            // ExFor: Rsc.ActualWorkProtected
            // ExSummary: Shows how to read/write Rsc.ActualWorkProtected property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.ActualWorkProtected, project.GetWork(1));

            Console.WriteLine("Actual Work Protected: " + resource.Get(Rsc.ActualWorkProtected));

            // ExEnd
        }

        [Test]
        public void GetSetAssignmentOwner()
        {
            // ExStart
            // ExFor: Rsc.AssignmentOwner
            // ExSummary: Shows how to read/write Rsc.AssignmentOwner property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.AssignmentOwner, "John");

            Console.WriteLine("Assignment Owner: " + resource.Get(Rsc.AssignmentOwner));

            // ExEnd
        }

        [Test]
        public void GetSetAssignmentOwnerGuid()
        {
            // ExStart
            // ExFor: Rsc.AssignmentOwnerGuid
            // ExSummary: Shows how to read/write Rsc.AssignmentOwnerGuid property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.AssignmentOwnerGuid, "aad9ac22-9f06-4196-906b-916acebcc1c2");

            Console.WriteLine("Assignment Owner Guid: " + resource.Get(Rsc.AssignmentOwnerGuid));

            // ExEnd
        }

        [Test]
        public void GetSetAvailableFrom()
        {
            // ExStart
            // ExFor: Rsc.AvailableFrom
            // ExSummary: Shows how to read/write Rsc.AvailableFrom property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.AvailableFrom, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Available From: " + resource.Get(Rsc.AvailableFrom));

            // ExEnd
        }

        [Test]
        public void GetSetAvailableTo()
        {
            // ExStart
            // ExFor: Rsc.AvailableTo
            // ExSummary: Shows how to read/write Rsc.AvailableTo property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.AvailableTo, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Available To: " + resource.Get(Rsc.AvailableTo));

            // ExEnd
        }

        [Test]
        public void GetSetBookingType()
        {
            // ExStart
            // ExFor: Rsc.BookingType
            // ExSummary: Shows how to read/write Rsc.BookingType property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.BookingType, BookingType.Committed);

            Console.WriteLine("Booking Type: " + resource.Get(Rsc.BookingType));

            // ExEnd
        }

        [Test]
        public void GetSetCanLevel()
        {
            // ExStart
            // ExFor: Rsc.CanLevel
            // ExSummary: Shows how to read/write Rsc.CanLevel property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.CanLevel, true);

            Console.WriteLine("Can Level: " + resource.Get(Rsc.CanLevel));

            // ExEnd
        }

        [Test]
        public void GetSetCode()
        {
            // ExStart
            // ExFor: Rsc.Code
            // ExSummary: Shows how to read/write Rsc.Code property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Code, "555292");

            Console.WriteLine("Code: " + resource.Get(Rsc.Code));

            // ExEnd
        }

        [Test]
        public void GetSetCostCenter()
        {
            // ExStart
            // ExFor: Rsc.CostCenter
            // ExSummary: Shows how to read/write Rsc.CostCenter property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.CostCenter, "Center");

            Console.WriteLine("Cost Center: " + resource.Get(Rsc.CostCenter));

            // ExEnd
        }

        [Test]
        public void GetSetCostPerUse()
        {
            // ExStart
            // ExFor: Rsc.CostPerUse
            // ExSummary: Shows how to read/write Rsc.CostPerUse property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.CostPerUse, 9);

            Console.WriteLine("Cost Per Use: " + resource.Get(Rsc.CostPerUse));

            // ExEnd
        }

        [Test]
        public void GetSetCostVariance()
        {
            // ExStart
            // ExFor: Rsc.CostVariance
            // ExSummary: Shows how to read/write Rsc.CostVariance property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.CostVariance, 10);

            Console.WriteLine("Cost Variance: " + resource.Get(Rsc.CostVariance));

            // ExEnd
        }

        [Test]
        public void GetSetCreated()
        {
            // ExStart
            // ExFor: Rsc.Created
            // ExSummary: Shows how to read/write Rsc.Created property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Created, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Created: " + resource.Get(Rsc.Created));

            // ExEnd
        }

        [Test]
        public void GetSetFinish()
        {
            // ExStart
            // ExFor: Rsc.Finish
            // ExSummary: Shows how to read/write Rsc.Finish property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Finish, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Finish: " + resource.Get(Rsc.Finish));

            // ExEnd
        }

        [Test]
        public void GetSetGuid()
        {
            // ExStart
            // ExFor: Rsc.Guid
            // ExSummary: Shows how to read/write Rsc.Guid property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Guid, "1385689c-2dd1-4114-935b-054beb6fbbbe");

            Console.WriteLine("Guid: " + resource.Get(Rsc.Guid));

            // ExEnd
        }

        [Test]
        public void GetSetHyperlink()
        {
            // ExStart
            // ExFor: Rsc.Hyperlink
            // ExFor: Rsc.HyperlinkAddress
            // ExFor: Rsc.HyperlinkSubAddress
            // ExSummary: Shows how to read/write resources hyperlink properties.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Hyperlink, "aspose.com");
            resource.Set(Rsc.HyperlinkAddress, "products.aspose.com");
            resource.Set(Rsc.HyperlinkSubAddress, "/total/net");

            Console.WriteLine("Hyperlink: " + resource.Get(Rsc.Hyperlink));
            Console.WriteLine("Hyperlink Address: " + resource.Get(Rsc.HyperlinkAddress));
            Console.WriteLine("Hyperlink Sub Address: " + resource.Get(Rsc.HyperlinkSubAddress));

            // ExEnd
        }

        [Test]
        public void GetSetId()
        {
            // ExStart
            // ExFor: Rsc.Id
            // ExSummary: Shows how to read/write Rsc.Id property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Id, 987);

            Console.WriteLine("Id: " + resource.Get(Rsc.Id));

            // ExEnd
        }

        [Test]
        public void GetSetInactive()
        {
            // ExStart
            // ExFor: Rsc.Inactive
            // ExSummary: Shows how to read/write Rsc.Inactive property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Inactive, true);

            Console.WriteLine("Inactive: " + resource.Get(Rsc.Inactive));

            // ExEnd
        }

        [Test]
        public void GetSetInitials()
        {
            // ExStart
            // ExFor: Rsc.Initials
            // ExSummary: Shows how to read/write Rsc.Initials property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Initials, "R");

            Console.WriteLine("Initials: " + resource.Get(Rsc.Initials));

            // ExEnd
        }

        [Test]
        public void GetSetIsBudget()
        {
            // ExStart
            // ExFor: Rsc.IsBudget
            // ExSummary: Shows how to read/write Rsc.IsBudget property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.IsBudget, true);

            Console.WriteLine("Is Budget: " + resource.Get(Rsc.IsBudget));

            // ExEnd
        }

        [Test]
        public void GetSetIsCostResource()
        {
            // ExStart
            // ExFor: Rsc.IsCostResource
            // ExSummary: Shows how to read/write Rsc.IsCostResource property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.IsCostResource, true);

            Console.WriteLine("Is Cost Resource: " + resource.Get(Rsc.IsCostResource));

            // ExEnd
        }

        [Test]
        public void GetSetIsEnterprise()
        {
            // ExStart
            // ExFor: Rsc.IsEnterprise
            // ExSummary: Shows how to read/write Rsc.IsEnterprise property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.IsEnterprise, true);

            Console.WriteLine("Is Enterprise: " + resource.Get(Rsc.IsEnterprise));

            // ExEnd
        }

        [Test]
        public void GetSetIsGeneric()
        {
            // ExStart
            // ExFor: Rsc.IsGeneric
            // ExSummary: Shows how to read/write Rsc.IsGeneric property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.IsGeneric, true);

            Console.WriteLine("Is Generic: " + resource.Get(Rsc.IsGeneric));

            // ExEnd
        }

        [Test]
        public void GetSetIsNull()
        {
            // ExStart
            // ExFor: Rsc.IsNull
            // ExSummary: Shows how to read/write Rsc.IsNull property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.IsNull, true);

            Console.WriteLine("Is Null: " + resource.Get(Rsc.IsNull));

            // ExEnd
        }

        [Test]
        public void GetSetIsTeamAssignmentPool()
        {
            // ExStart
            // ExFor: Rsc.IsTeamAssignmentPool
            // ExSummary: Shows how to read/write Rsc.IsTeamAssignmentPool property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.IsTeamAssignmentPool, true);

            Console.WriteLine("Is Team Assignment Pool: " + resource.Get(Rsc.IsTeamAssignmentPool));

            // ExEnd
        }

        [Test]
        public void GetSetMaterialLabel()
        {
            // ExStart
            // ExFor: Rsc.MaterialLabel
            // ExSummary: Shows how to read/write Rsc.MaterialLabel property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.MaterialLabel, "kg");

            Console.WriteLine("Material Label: " + resource.Get(Rsc.MaterialLabel));

            // ExEnd
        }

        [Test]
        public void GetSetMaxUnits()
        {
            // ExStart
            // ExFor: Rsc.MaxUnits
            // ExSummary: Shows how to read/write Rsc.MaxUnits property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.MaxUnits, 2);

            Console.WriteLine("Max Units: " + resource.Get(Rsc.MaxUnits));

            // ExEnd
        }

        [Test]
        public void GetSetName()
        {
            // ExStart
            // ExFor: Rsc
            // ExFor: Rsc.Name
            // ExFor: RscKey
            // ExSummary: Shows how to read/write Rsc.Name property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Name, "John Smith");

            Console.WriteLine("Name: " + resource.Get(Rsc.Name));

            // ExEnd
        }

        [Test]
        public void GetSetNotes()
        {
            // ExStart
            // ExFor: Rsc.Notes
            // ExSummary: Shows how to read/write Rsc.Notes property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Notes, "Resource Notes");

            Console.WriteLine("Notes: " + resource.Get(Rsc.Notes));

            // ExEnd
        }

        [Test]
        public void GetSetNotesRTF()
        {
            // ExStart
            // ExFor: Rsc.NotesRTF
            // ExSummary: Shows how to read/write Rsc.NotesRTF property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            const string RTF = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset134 SimSun;}{\f1\fnil\fcharset0 Calibri;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang9\f0\fs22\'d4\'e7\'c9\'cf\'ba\'c3\f1\par
}
 "; // 早上好

            resource.Set(Rsc.NotesRTF, RTF);

            Console.WriteLine("Notes R T F: " + resource.Get(Rsc.NotesRTF));

            // ExEnd
        }

        [Test]
        public void GetSetNotesText()
        {
            // ExStart
            // ExFor: Rsc.NotesText
            // ExSummary: Shows how to read/write Rsc.NotesText property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.NotesText, "Notes");

            Console.WriteLine("Notes Text: " + resource.Get(Rsc.NotesText));

            // ExEnd
        }

        [Test]
        public void GetSetPeakUnits()
        {
            // ExStart
            // ExFor: Rsc.PeakUnits
            // ExSummary: Shows how to read/write Rsc.PeakUnits property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.PeakUnits, 2);

            Console.WriteLine("Peak Units: " + resource.Get(Rsc.PeakUnits));

            // ExEnd
        }

        [Test]
        public void GetSetPhonetics()
        {
            // ExStart
            // ExFor: Rsc.Phonetics
            // ExSummary: Shows how to read/write Rsc.Phonetics property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Phonetics, "Phonetics");

            Console.WriteLine("Phonetics: " + resource.Get(Rsc.Phonetics));

            // ExEnd
        }

        [Test]
        public void GetSetRegularWork()
        {
            // ExStart
            // ExFor: Rsc.RegularWork
            // ExSummary: Shows how to read/write Rsc.RegularWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.RegularWork, project.GetWork(1));

            Console.WriteLine("Regular Work: " + resource.Get(Rsc.RegularWork));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingCost()
        {
            // ExStart
            // ExFor: Rsc.RemainingCost
            // ExSummary: Shows how to read/write Rsc.RemainingCost property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.RemainingCost, 2);

            Console.WriteLine("Remaining Cost: " + resource.Get(Rsc.RemainingCost));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingOvertimeCost()
        {
            // ExStart
            // ExFor: Rsc.RemainingOvertimeCost
            // ExSummary: Shows how to read/write Rsc.RemainingOvertimeCost property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.RemainingOvertimeCost, 3);

            Console.WriteLine("Remaining Overtime Cost: " + resource.Get(Rsc.RemainingOvertimeCost));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingOvertimeWork()
        {
            // ExStart
            // ExFor: Rsc.RemainingOvertimeWork
            // ExSummary: Shows how to read/write Rsc.RemainingOvertimeWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.RemainingOvertimeWork, project.GetWork(1));

            Console.WriteLine("Remaining Overtime Work: " + resource.Get(Rsc.RemainingOvertimeWork));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingWork()
        {
            // ExStart
            // ExFor: Rsc.RemainingWork
            // ExSummary: Shows how to read/write Rsc.RemainingWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.RemainingWork, project.GetWork(1));

            Console.WriteLine("Remaining Work: " + resource.Get(Rsc.RemainingWork));

            // ExEnd
        }

        [Test]
        public void GetSetStandardRateFormat()
        {
            // ExStart
            // ExFor: Rsc.StandardRateFormat
            // ExFor: RateFormatType
            // ExSummary: Shows how to read/write Rsc.StandardRateFormat property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.StandardRateFormat, RateFormatType.Hour);

            Console.WriteLine("Standard Rate Format: " + resource.Get(Rsc.StandardRateFormat));

            // ExEnd
        }

        [Test]
        public void GetSetStart()
        {
            // ExStart
            // ExFor: Rsc.Start
            // ExSummary: Shows how to read/write Rsc.Start property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Start, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Start: " + resource.Get(Rsc.Start));

            // ExEnd
        }

        [Test]
        public void GetSetType()
        {
            // ExStart
            // ExFor: Rsc.Type
            // ExSummary: Shows how to read/write Rsc.Type property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Type, ResourceType.Work);

            Console.WriteLine("Type: " + resource.Get(Rsc.Type));

            // ExEnd
        }

        [Test]
        public void GetSetUid()
        {
            // ExStart
            // ExFor: Rsc.Uid
            // ExSummary: Shows how to read/write Rsc.Uid property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Uid, 99);

            Console.WriteLine("Uid: " + resource.Get(Rsc.Uid));

            // ExEnd
        }

        [Test]
        public void GetSetWork()
        {
            // ExStart
            // ExFor: Rsc.Work
            // ExSummary: Shows how to read/write Rsc.Work property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Work, project.GetWork(1));

            Console.WriteLine("Work: " + resource.Get(Rsc.Work));

            // ExEnd
        }

        [Test]
        public void GetSetWorkgroup()
        {
            // ExStart
            // ExFor: Rsc.Workgroup
            // ExSummary: Shows how to read/write Rsc.Workgroup property.
            var project = new Project();

            var resource = project.Resources.Add("Resource");

            resource.Set(Rsc.Workgroup, WorkGroupType.Email);

            Console.WriteLine("Workgroup: " + resource.Get(Rsc.Workgroup));

            // ExEnd
        }

        [Test]
        public void GetResourceCosts()
        {
            // ExStart:GetResourceCosts
            // ExFor: Rsc.Cost
            // ExFor: Rsc.ACWP
            // ExFor: Rsc.BCWS
            // ExFor: Rsc.BCWP
            // ExFor: Rsc.CV
            // ExFor: Rsc.SV
            // ExSummary: Shows how to read resource costs.
            var project = new Project(DataDir + "ResourceCosts.mpp");

            // Display all resources costs
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) == null)
                {
                    continue;
                }

                Console.WriteLine(res.Get(Rsc.Cost));
                Console.WriteLine(res.Get(Rsc.ACWP));
                Console.WriteLine(res.Get(Rsc.BCWS));
                Console.WriteLine(res.Get(Rsc.BCWP));

                // CV = BCWP - ACWP
                Console.WriteLine(res.Get(Rsc.CV));

                // SV = BCWP - BCWS
                Console.WriteLine(res.Get(Rsc.SV));
            }

            // ExEnd:GetResourceCosts
        }

        [Test]
        public void GetResourceOvertime()
        {
            // ExStart:GetResourceOvertime
            // ExFor: Rsc.OvertimeCost
            // ExFor: Rsc.OvertimeWork
            // ExFor: Rsc.OvertimeRateFormat
            // ExSummary: Shows how to read resource overtime values.
            var project = new Project(DataDir + "ResourceOvertime.mpp");

            // Display overtime related parameters for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) == null)
                {
                    continue;
                }

                Console.WriteLine(res.Get(Rsc.OvertimeCost));
                Console.WriteLine(res.Get(Rsc.OvertimeWork).ToString());
                Console.WriteLine(res.Get(Rsc.OvertimeRateFormat).ToString());
            }

            // ExEnd:GetResourceOvertime
        }

        [Test]
        public void GetResourcePercentWorkComplete()
        {
            // ExStart:GetResourcePercentWorkComplete
            // ExFor: Rsc.PercentWorkComplete
            // ExSummary: Shows how to read resource percent work complete.
            var project = new Project(DataDir + "ResourcePercentWorkComplete.mpp");

            // Display work percentage completion for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.PercentWorkComplete));
                }
            }

            // ExEnd:GetResourcePercentWorkComplete
        }

        [Test]
        public void GetResourceWorkVariance()
        {
            // ExStart:GetResourceWorkVariance
            // ExFor: Rsc.WorkVariance
            // ExSummary: Shows how to read resource work variance.
            var project = new Project(DataDir + "WorkVariance.mpp");

            foreach (var assignment in project.ResourceAssignments)
            {
                var resource = assignment.Get(Asn.Resource);

                var workVariance = resource.Get(Rsc.WorkVariance);

                Console.WriteLine(workVariance);
            }

            // ExEnd:GetResourceWorkVariance
        }

        [Test]
        public void GetSetResourceCalendar()
        {
            // ExStart:GetSetResourceCalendar
            // ExFor: Rsc.Calendar
            // ExSummary: Shows how to get/set a resource calendar.
            var project = new Project(DataDir + "ResourceCalendar.mpp");
            var res = project.Resources.Add("Resource1");

            // Add standard calendar and assign to resource
            var cal = project.Calendars.Add("Resource1");
            res.Set(Rsc.Calendar, cal);

            // Display base calendar name for all resources
            foreach (var resource in project.Resources)
            {
                if (resource.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(resource.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }

            // ExEnd:GetSetResourceCalendar
        }

        [Test]
        public void SetResourceMetaProperties()
        {
            try
            {
                // ExStart:SetResourceMetaProperties
                // ExFor: Rsc.EMailAddress
                // ExFor: Rsc.WindowsUserAccount
                // ExSummary: Shows how to set resource's meta properties.
                var project = new Project(DataDir + "Project.mpp");

                // Add resource and set resource meta data
                var resource = project.Resources.Add("Rsc 1");
                resource.Set(Rsc.EMailAddress, "1@gmail.com");
                resource.Set(Rsc.WindowsUserAccount, "user_acc1");

                // ExEnd:SetResourceMetaProperties
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadWriteGeneralResourceProperties()
        {
            try
            {
                // ExStart:ReadWriteGeneralResourceProperties
                // ExFor: Rsc.StandardRate
                // ExFor: Rsc.OvertimeRate
                // ExFor: Rsc.Group
                // ExSummary: Shows how to work resources rates and groups.
                var project = new Project(DataDir + "UpdateResourceData.mpp");

                // Add resource and set some properties
                var resource = project.Resources.Add("Rsc");
                resource.Set(Rsc.Start, new DateTime(2020, 4, 1, 8, 0, 0));
                resource.Set(Rsc.StandardRate, 30);
                resource.Set(Rsc.OvertimeRate, 45);
                resource.Set(Rsc.Group, "Workgroup1");

                Console.WriteLine("Resource Start: " + resource.Get(Rsc.Start));
                Console.WriteLine("Resource Standard Rate: " + resource.Get(Rsc.StandardRate));
                Console.WriteLine("Resource Overtime Rate: " + resource.Get(Rsc.OvertimeRate));
                Console.WriteLine("Resource Group: " + resource.Get(Rsc.Group));

                project.Save(OutDir + "UpdateResourceData_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:ReadWriteGeneralResourceProperties
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadBudgetWorkAndCost()
        {
            // ExStart:ReadBudgetWorkAndCost
            // ExFor: Rsc.BudgetWork
            // ExFor: Rsc.BudgetCost
            // ExSummary: Shows how to read budget work/cost values of a resource.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            // Display budget work and budget cost for project summary task
            Console.WriteLine("projSummary.BudgetWork = " + project.RootTask.Get(Tsk.BudgetWork));
            Console.WriteLine("projSummary.BudgetCost = " + project.RootTask.Get(Tsk.BudgetCost));

            // Display resource budget work
            var rsc = project.Resources.GetByUid(6);
            Console.WriteLine("Resource BudgetWork = " + rsc.Get(Rsc.BudgetWork));

            // Display resource budget cost
            rsc = project.Resources.GetByUid(7);
            Console.WriteLine("Resource BudgetCost = " + rsc.Get(Rsc.BudgetCost));

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);
            foreach (var task in collector.Tasks)
            {
                // Display assignment budget work and budget cost
                foreach (var assignment in task.Assignments)
                {
                    var resource = assignment.Get(Asn.Resource);
                    if (resource == null)
                    {
                        continue;
                    }

                    if (resource.Get(Rsc.Type) == ResourceType.Work)
                    {
                        Console.WriteLine("Assignment BudgetWork = " + assignment.Get(Asn.BudgetWork));
                    }
                    else
                    {
                        Console.WriteLine("Assignment BudgetCost = " + assignment.Get(Asn.BudgetCost));
                    }
                }
            }

            // ExEnd:ReadBudgetWorkAndCost
        }
    }
}