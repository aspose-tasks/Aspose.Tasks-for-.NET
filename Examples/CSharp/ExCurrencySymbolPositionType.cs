namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExCurrencySymbolPositionType : ApiExampleBase
    {
        [Test]
        public void WorkWithCurrencySymbolPositionType()
        {
            {
                // ExStart
                // ExFor: CurrencySymbolPositionType
                // ExFor: CurrencySymbolPositionType.Before
                // ExSummary: Shows how to specify the placement of the currency symbol (CurrencySymbolPositionType.Before).
                var project = new Project(DataDir + "Project2.mpp");
                // set the placement of the currency symbol
                // Before, no space ($0).
                project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.Before);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CurrencySymbolPositionType.BeforeWithSpace
                // ExSummary: Shows how to specify the placement of the currency symbol (CurrencySymbolPositionType.BeforeWithSpace).
                var project = new Project(DataDir + "Project2.mpp");
                // set the placement of the currency symbol
                // Before, with space ($ 0).
                project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.BeforeWithSpace);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CurrencySymbolPositionType.After
                // ExSummary: Shows how to specify the placement of the currency symbol (CurrencySymbolPositionType.After).
                var project = new Project(DataDir + "Project2.mpp");
                // set the placement of the currency symbol
                // After, no space (0$).
                project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.After);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CurrencySymbolPositionType.AfterWithSpace
                // ExSummary: Shows how to specify the placement of the currency symbol (CurrencySymbolPositionType.AfterWithSpace).
                var project = new Project(DataDir + "Project2.mpp");
                // set the placement of the currency symbol
                // After, with space (0 $).
                project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.AfterWithSpace);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CurrencySymbolPositionType.Undefined
                // ExSummary: Shows how to specify the placement of the currency symbol (CurrencySymbolPositionType.Undefined).
                var project = new Project(DataDir + "Project2.mpp");
                // set the placement of the currency symbol
                project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.Undefined);
                // work with the project...
                // ExEnd
            }
        }
    }
}