namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExGridline : ApiExampleBase
    {
        [Test]
        public void WorkWithGridline()
        {
            // ExStart:WorkWithGridline
            // ExFor: Gridline
            // ExFor: Gridline.#ctor
            // ExFor: Gridline.Color
            // ExFor: Gridline.GridlineType
            // ExFor: Gridline.Pattern
            // ExSummary: Shows how to work with gridlines while save in visual formats. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.PNG);

            var gridline = new Gridline
            {
                // set the type of gridline (<see cref="P:Aspose.Tasks.Visualization.Gridline.GridlineType" />).
                GridlineType = GridlineType.GanttRow, 
                // set the <see cref="T:Aspose.Tasks.Visualization.LinePattern" /> of a gridline
                Pattern = LinePattern.Dashed
            };
            
            options.Gridlines = new List<Gridline>();
            options.Gridlines.Add(gridline);

            project.Save(OutDir + "PrintProjectPagesToSeparateFiles_out.png", options);

            // ExEnd:WorkWithGridline
        }

        [Test]
        public void EqualsGridline()
        {
            // ExStart:EqualsGridline
            // ExFor: Gridline.Equals(Object)
            // ExSummary: Shows how to check an equality of gridlines. 
            var gridline1 = new Gridline();
            var gridline2 = new Gridline();

            // the equality of gridlines is checked against to gridline type.
            Console.WriteLine("Gridline 1 Type: " + gridline1.GridlineType);
            Console.WriteLine("Gridline 2 Type: " + gridline2.GridlineType);
            Console.WriteLine("Are gridlines equal: " + gridline1.Equals(gridline2));
            
            // change the type
            gridline1.GridlineType = GridlineType.BarRows;
            Console.WriteLine("Gridline 1 Type: " + gridline1.GridlineType);
            Console.WriteLine("Are gridlines equal: " + gridline1.Equals(gridline2));
            // ExEnd:EqualsGridline
        }

        [Test]
        public void GetHashCodeGridline()
        {
            // ExStart:GetHashCodeGridline
            // ExFor: Gridline.GetHashCode
            // ExSummary: Shows how to get hash code of a gridline.
            var gridline1 = new Gridline();
            var gridline2 = new Gridline();
            
            // the hash code of a gridline is based on internal GUID field. 
            Console.WriteLine("Gridline 1 Hash Code: {0}", gridline1.GetHashCode());
            Console.WriteLine("Gridline 2 Hash Code: {0}", gridline2.GetHashCode());

            // ExEnd:GetHashCodeGridline
        }
    }
}