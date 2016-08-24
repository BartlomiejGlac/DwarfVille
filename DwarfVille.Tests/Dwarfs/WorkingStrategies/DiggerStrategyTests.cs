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
    public class DiggerStrategyTests
    {
        private const int MinValue = 0;
        private const int MaxValue = 3;

        private DiggerStrategy _subject;
        private Mock<IProbabilityGenerator> _probabilityGeneratorMock;
        private Mock<IShaft> _shaftMock;

        [SetUp]
        public void SetUp()
        {
            _probabilityGeneratorMock = new Mock<IProbabilityGenerator>();
            _shaftMock= new Mock<IShaft>();
            _subject = new DiggerStrategy(_probabilityGeneratorMock.Object);
        }

        [Test]
        public void ShouldCommunicateWithProbabilityGeneratorUsingMinValue0AndMaxValue3()
        {
            // given
            

            // when
            _subject.WorkOn(_shaftMock.Object);

            // then
            _probabilityGeneratorMock.Verify(i => i.Generate(MinValue, MaxValue));
        }

        [Test]
        public void ShouldNotDigInTheWallNTimesWhenProbabilityGeneratorReturs0()
        {
            // given
            _probabilityGeneratorMock.Setup(i => i.Generate(MinValue, MaxValue)).Returns(0);

            // when
            _subject.WorkOn(_shaftMock.Object);

            // then
            _shaftMock.Verify(i => i.DigIntoWall(), Times.Never);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void ShouldDigInTheWallNTimesWhenProbabilityGeneratorRetursN(int howManyTimesToDig)
        {
            // given
            _probabilityGeneratorMock.Setup(i => i.Generate(MinValue, MaxValue)).Returns(howManyTimesToDig);

            // when
            _subject.WorkOn(_shaftMock.Object);

            // then
            _shaftMock.Verify(i=>i.DigIntoWall(), Times.AtLeast(howManyTimesToDig));
        }


        [Test]
        public void ShouldAddMitrhillToBackPackWhenThereWillBeOnDigAttemptAndShaftWillReturnMitrhill()
        {
            // given
            _probabilityGeneratorMock.Setup(i => i.Generate(MinValue, MaxValue)).Returns(1);
            _shaftMock.Setup(i => i.DigIntoWall()).Returns(MaterialType.Mithrill);

            // when
            var result = _subject.WorkOn(_shaftMock.Object);

            // then
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First(), Is.EqualTo(MaterialType.Mithrill));
        }
    }
}
