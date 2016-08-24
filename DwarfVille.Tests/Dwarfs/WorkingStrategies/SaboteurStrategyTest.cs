using System.Linq;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Dwarfs.WorkingStrategies;
using DwarfVille.DomainLogic.Probability;
using Moq;
using NUnit.Framework;

namespace DwarfVille.Tests.Dwarfs.WorkingStrategies
{    
    [TestFixture]
    public class SaboteurStrategyTest
    {
        private SaboteurStrategy _subject;
        private Mock<IShaft> _shaftMock;

        [SetUp]
        public void SetUp()
        {
            _shaftMock= new Mock<IShaft>();
            _subject = new SaboteurStrategy();
        }

        [Test]
        public void ShouldDestroyShaftAlways()
        {
            // given

            // when
            _subject.WorkOn(_shaftMock.Object);

            // then
            _shaftMock.Verify(i => i.DestroyShaft(), Times.Once);
        }
        
    }
}
