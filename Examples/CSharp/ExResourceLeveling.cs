using System;
using System.Collections.Generic;
using Aspose.Tasks.Leveling;

namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExResourceLeveling : ApiExampleBase
    {
        [Test]
        public void ResourceLeveler_LevelAll()
        {
            // ExStart:ResourceLeveler_LevelAll
            // ExFor: ResourceLeveler.LevelAll()
            // ExFor: LevelingResult
            // ExFor: ResourceLeveler.ClearLeveling(Project)
            // ExSummary: Shows how to level all project's resources using default options.

            var project = new Project(DataDir + "Software Development Plan.mpp");

            var levelingResult = ResourceLeveler.LevelAll(project);

            foreach (var task in levelingResult.AffectedTasks)
            {
                Console.WriteLine("Task affected by the leveling operation: " + task.Name);
            }

            project.Save(OutDir + "Software Development Plan.leveled.mpp");
            ResourceLeveler.ClearLeveling(project);

            Console.WriteLine("Leveling cleared");

            // ExEnd
        }

        [Test]
        public void ResourceLeveler_LevelResources()
        {
            // ExStart:ResourceLeveler_LevelResources
            // ExFor: ResourceLeveler.LevelResources(Project,LevelingOptions)
            // ExFor: LevelingOptions
            // ExFor: LevelingOptions.MessageLevel
            // ExFor: LevelingOptions.MessageHandler
            // ExFor: IMessageHandler
            // ExSummary: Shows how to level specific resource, customize leveling options and examine leveling algorithm messages.

            var project = new Project(DataDir + "Software Development Plan.mpp");

            var levelingOptions = new LevelingOptions();
            levelingOptions.StartDate = new DateTime(2013, 3, 10);
            levelingOptions.FinishDate = new DateTime(2013, 4, 30);
            levelingOptions.Resources = new List<Resource> { project.Resources.GetById(7) };
            levelingOptions.MessageLevel = MessageLevel.Information;
            levelingOptions.MessageHandler = new LevelingMessageHandler();

            ResourceLeveler.LevelResources(project, levelingOptions);

            // ExEnd
        }

        private sealed class LevelingMessageHandler : IMessageHandler
        {
            public void Message(MessageLevel level, string message)
            {
                Console.WriteLine("[{0}] : {1}", level, message);
            }
        }
    }
}