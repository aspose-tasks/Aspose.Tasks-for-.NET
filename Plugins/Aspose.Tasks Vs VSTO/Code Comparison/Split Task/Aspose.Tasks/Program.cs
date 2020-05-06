using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"E:\Aspose\Aspose Vs VSTO\Aspose.Tasks VS VSTO Projects\Sample Files\MyProject.mpp";

            Project MyProject = new Project(FileName);
            ResourceAssignment MyResource = MyProject.ResourceAssignments[0];
            MyResource.SplitTask(DateTime.Parse("01.11.13 08:00"), DateTime.Parse("09.11.13 08:00"), MyProject.Calendar);
        }
    }
}
