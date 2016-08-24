using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Probability;
using Moq;
using NUnit.Framework;

namespace DwarfVille.Tests.Buildings.MiningDistrict.Walls
{    
    [TestFixture]
    public class TheWallTest
    {
        private static object[] ShouldRecieveMithrillTestCases =
        {
            new TestCaseData(0m).SetName("WhenProbabilityIs0"),
            new TestCaseData(3.5m).SetName("WhenProbabilityIs3.5"),
            new TestCaseData(5m).SetName("WhenProbabilityIs5"),
        };

        [TestCaseSource("ShouldRecieveMithrillTestCases")]
        public void ShouldRecieveMithrill(decimal probability)
        {
            // given
            var random = new Mock<IProbabilityGenerator>();
            var wally = new TheWall(random.Object);
            random.Setup(i => i.Generate(0 ,101)).Returns(5);

            // when
            var material = wally.Dig();

            // then
            Assert.That(material, Is.EqualTo(MaterialType.Mithrill));
        }
    }
}
