using FluentAssertions;
using Moq;
using NSubstitute;
using NUnit.Framework;
using PlayerInput;
using UnityEngine;

namespace Tests.EditMode
{
    public class FactoryManagerTests
    {
        [Test]
        public void WhenLeftMouseButtonClicked_Then3BotsSpawned_Vanilla()
        {
            //arrange

            var factoryStub = new GameObject().AddComponent<FactoryManager>();
            var botsMock = new FakeBotManager();

            factoryStub.SetDependencies(new FakeInput(), botsMock);
            //act

            factoryStub.HandleInput();

            //assert
            botsMock.SpawnedBots.Should().Be(3);
        }


        [Test]
        public void WhenLeftMouseButtonClicked_Then3BotsSpawned_Moq()
        {
            //arrange
            var input = Mock.Of<IInput>(x => x.LeftMouseButtonPressed() == true);

            var factoryStub = new GameObject().AddComponent<FactoryManager>();
           
            
            var botsMock = new Mock<IBotManager>();
            
            factoryStub.SetDependencies(input, botsMock.Object);
            //act

            factoryStub.HandleInput();

            //assert
            botsMock.Verify(x => x.TrySpawnBot(It.IsAny<Vector2Int>()), Times.Exactly(3));
        }


        [Test]
        public void WhenLeftMouseButtonClicked_Then3BotsSpawned_NSubstitute()
        {
            //arrange

            var input = Substitute.For<IInput>();
            input.LeftMouseButtonPressed().Returns(true);

            var factoryStub = new GameObject().AddComponent<FactoryManager>();
            var botsMock = Substitute.For<IBotManager>();

            factoryStub.SetDependencies(input, botsMock);
            //act

            factoryStub.HandleInput();

            //assert
            botsMock.Received(3).TrySpawnBot(Arg.Any<Vector2Int>());
        }
    }
}