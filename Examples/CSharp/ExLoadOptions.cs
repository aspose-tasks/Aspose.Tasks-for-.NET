using System.Threading;

namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Text.RegularExpressions;
    using NUnit.Framework;

    [TestFixture]
    public class ExLoadOptions : ApiExampleBase
    {
        [Test]
        public void WorkWithLoadOptionsAndPassword()
        {
            // ExStart
            // ExFor: LoadOptions
            // ExFor: LoadOptions.Password
            // ExSummary: Shows how to load the password-protected project using <see cref="Aspose.Tasks.LoadOptions"/> instance.
            using (var stream = new FileStream(DataDir + "PasswordProtectedProject.mpp", FileMode.Open))
            {
                var options = new LoadOptions
                {
                    Password = "password"
                };
                var project = new Project(stream, options);
                Console.WriteLine(project.Get(Prj.Name));
            }

            // ExEnd
        }

        [Test]
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")] // ExSkip
        public void WorkWithLoadOptionsAndPrimaveraOptions()
        {
            // ExStart
            // ExFor: LoadOptions.PrimaveraReadOptions
            // ExFor: PrimaveraReadOptions.PreserveUids
            // ExFor: PrimaveraReadOptions.UndefinedConstraintHandlingBehavior
            // ExSummary: Shows how to load Primavera project with the specified Id using <see cref="LoadOptions" />.
            var loadOptions = new LoadOptions();

            var primaveraOptions = new PrimaveraReadOptions()
            {
                ProjectUid = 3882,
                UndefinedConstraintHandlingBehavior = UndefinedConstraintHandlingBehavior.None,
                PreserveUids = true
            };

            // set Primavera reading options
            loadOptions.PrimaveraReadOptions = primaveraOptions;

            var project = new Project(DataDir + "PrimaveraProject.xml", loadOptions);
            Console.WriteLine("Project Name: " + project.Get(Prj.Name));

            // work with the project...
            // ExEnd
        }

        [Test]
        public void WorkWithLoadOptionsWithCancellationToken()
        {
            // ExStart
            // ExFor: LoadOptions.CancellationToken
            // ExSummary: Shows how to pass CancellationToken to cancel long-running Project loading operation.
            var loadOptions = new LoadOptions();

            CancellationTokenSource cts = new CancellationTokenSource();
            loadOptions.CancellationToken = cts.Token;

            // cts can be passed to another thread where method cts.Cancel() can be called to cancel project loading operation.
            // cts.Cancel();
            var project = new Project(DataDir + "PrimaveraProject.xml", loadOptions);
            // ExEnd
        }

        // ExStart
        // ExFor: LoadOptions.ErrorHandler
        // ExSummary: Shows how to load Primavera project using <see cref="LoadOptions" /> with error handling.
        [Test] // ExSkip
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")] // ExSkip
        public void WorkWithLoadOptionsAndPrimaveraOptionsAndErrorHandler()
        {
            var loadOptions = new LoadOptions();

            var primaveraOptions = new PrimaveraReadOptions
            {
                ProjectUid = 3882
            };

            // set primavera reading options
            loadOptions.PrimaveraReadOptions = primaveraOptions;
            loadOptions.ErrorHandler = CustomDurationHandlerForFile;

            var project = new Project(DataDir + "PrimaveraProject.xml", loadOptions);

            // work with the project...
        }

        private static object CustomDurationHandlerForFile(object sender, ParseErrorArgs args)
        {
            var regex = new Regex("[*]{2}(\\d+)Hrs(\\d+)Mins(\\d+)Secs[*]{2}");
            if (args.FieldType != typeof(TimeSpan))
            {
                throw args.Exception;
            }

            Console.WriteLine("Object field: {0}, Object field type: {1}, Invalid value: {2}", args.FieldName, args.FieldType, args.InvalidValue);
            var duration = regex.Replace(args.InvalidValue, "PT$1H$2M$3S");
            var value = Duration.ParseTimeSpan(duration);
            Console.WriteLine("New value : {0}", value);
            return value;
        }

        // ExEnd
    }
}