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
        public void GetResourceCosts()
        {
            //ExStart:GetResourceCosts
            //ExFor: Rsc.Cost
            //ExFor: Rsc.ACWP
            //ExFor: Rsc.BCWS
            //ExFor: Rsc.BCWP
            //ExSummary: Shows how to read resource costs.
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
            }
            //ExEnd:GetResourceCosts
        }
        
        [Test]
        public void GetResourceOvertime()
        {
            //ExStart:GetResourceOvertime
            //ExFor: Rsc.OvertimeCost
            //ExFor: Rsc.OvertimeWork
            //ExFor: Rsc.OvertimeRateFormat
            //ExSummary: Shows how to read resource overtime values.
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
            //ExEnd:GetResourceOvertime
        }
        
        [Test]
        public void GetResourcePercentWorkComplete()
        {
            //ExStart:GetResourcePercentWorkComplete
            //ExFor: Rsc.PercentWorkComplete
            //ExSummary: Shows how to read resource percent work complete.
            var project = new Project(DataDir + "ResourcePercentWorkComplete.mpp");

            // Display work percentage completion for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.PercentWorkComplete));
                }
            }
            //ExEnd:GetResourcePercentWorkComplete
        }
        
        [Test]
        public void GetResourceWorkVariance()
        {
            //ExStart:GetResourceWorkVariance
            //ExFor: Rsc.WorkVariance
            //ExSummary: Shows how to read resource work variance.
            var project = new Project(DataDir + "WorkVariance.mpp");

            foreach (var assignment in project.ResourceAssignments)
            {
                var resource = assignment.Get(Asn.Resource);

                var workVariance = resource.Get(Rsc.WorkVariance);

                Console.WriteLine(workVariance);
            }
            //ExEnd:GetResourceWorkVariance
        }
        
        [Test]
        public void GetSetResourceCalendar()
        {
            //ExStart:GetSetResourceCalendar
            //ExFor: Rsc.Calendar
            //ExSummary: Shows how to get/set a resource calendar.
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
            //ExEnd:GetSetResourceCalendar
        }
        
        [Test]
        public void SetResourceMetaProperties()
        {
            try
            {
                //ExStart:SetResourceMetaProperties
                //ExFor: Rsc.EMailAddress
                //ExFor: Rsc.WindowsUserAccount
                //ExSummary: Shows how to set resource's meta properties.
                var project = new Project(DataDir + "Project.mpp");
                   
                // Add resource and set resource meta data
                var resource = project.Resources.Add("Rsc 1");
                resource.Set(Rsc.EMailAddress, "1@gmail.com");
                resource.Set(Rsc.WindowsUserAccount, "user_acc1");
                //ExEnd:SetResourceMetaProperties
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
                //ExStart:ReadWriteGeneralResourceProperties
                //ExFor: Rsc.StandardRate
                //ExFor: Rsc.OvertimeRate
                //ExSummary: Shows how to read/write resource rates.
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

                project.Save(OutDir + "UpdateResourceData_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ReadWriteGeneralResourceProperties
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void WriteResourceGroup()
        {
            try
            {
                //ExStart:WriteResourceGroup
                //ExFor: Rsc.Group
                //ExSummary: Shows how to set a resource group.
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

                project.Save(OutDir + "UpdateResourceData_out.mpp", SaveFileFormat.MPP);
                //ExEnd:WriteResourceGroup
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadBudgetWorkAndCost()
        {
            //ExStart:ReadBudgetWorkAndCost
            //ExFor: Rsc.BudgetWork
            //ExFor: Rsc.BudgetCost
            //ExSummary: Shows how to read budget work/cost values of a resource.
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
            //ExEnd:ReadBudgetWorkAndCost
        }
    }
}