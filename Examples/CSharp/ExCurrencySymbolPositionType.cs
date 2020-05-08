namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExCurrencySymbolPositionType : ApiExampleBase
    {
        [Test]
        public void WorkWithCurrencySymbolPositionType()
        {
            // ExStart
            // ExFor: CurrencySymbolPositionType
            // ExSummary: Shows how to specify the placement of the currency symbol (CurrencySymbolPositionType.Before).
            var project = new Project(DataDir + "Project2.mpp");
            // set the placement of the currency symbol
            // Before, no space ($0).
            project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.Before);
            // work with the project...
            // ExEnd
        }
    }
}