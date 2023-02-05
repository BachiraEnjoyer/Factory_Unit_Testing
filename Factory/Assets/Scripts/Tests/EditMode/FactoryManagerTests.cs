using FluentAssertions;
using NUnit.Framework;
using PlayerInput;
using UnityEngine;

namespace Tests.EditMode
{
    public class FactoryManagerTests
    {
        [Test]
        public void WhenLeftMouseButtonClicked_Then3BotsSpawned()
        {
            //arrange

            var factoryManager = new GameObject().AddComponent<FactoryManager>();
            var botManager = new FakeBotManager();
            
            factoryManager.SetDependencies(new FakeInput(), botManager);
            //act

            factoryManager.HandleInput();

            //assert

            botManager.SpawnedBots.Should().Be(3);
        }
    }
}