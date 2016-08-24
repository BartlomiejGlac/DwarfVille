using System;
using DwarfVille.DomainLogic.Buildings.MiningDistrict;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Dwarfs;
using Moq;
using NUnit.Framework;

namespace DwarfVille.Tests.Buildings.MiningDistrict.Shafts
{    
    [TestFixture]
    public class ShaftTests
    {
        private Shaft _subject;
        private Mock<IDigable> _digableMock;

        [SetUp]
        public void SetUp()
        {
            _digableMock= new Mock<IDigable>();
            _subject = new Shaft(_digableMock.Object);
        }

        [Test]
        public void ShouldThrowsShaftWasDestroyedExceptionWhenShaftWasDestroyedAndAddingNewWorkerToShaft()
        {
            // given
            var theDwarf = new Mock<IWorkable>();
            _subject.DestroyShaft();
            // when
            Action when = () => {_subject.AssignDwarf(theDwarf.Object); };

            // then
            Assert.Throws<ShaftWasDestroyedException>(when.Invoke);
        }

        [Test]
        public void ShouldKillAllAssignedWorkerWhenDestroyShaft()
        {
            // given
            var theDwarf = new Mock<IWorkable>();
            var anotherDwarf = new Mock<IWorkable>();
            _subject.AssignDwarf(theDwarf.Object);
            _subject.AssignDwarf(anotherDwarf.Object);

            // when
            _subject.DestroyShaft();

            // then
            theDwarf.Verify(i=>i.KillMe(), Times.Once);
            anotherDwarf.Verify(i=>i.KillMe(), Times.Once);
        }
        [Test]
        public void ShouldDigIntoDiggableElementWhenDigIntoWall()
        {
            // given
            _digableMock.Setup(i => i.Dig()).Returns(MaterialType.Mithrill);

            // when
            var result =_subject.DigIntoWall();

            // then
            Assert.That(result, Is.EqualTo(MaterialType.Mithrill));
        }
        [Test]
        public void ShouldAssignWorkerToShaftWhenShaftIsNotDestroyed()
        {
            // given
            var theDwarf = new Mock<IWorkable>();

            // when
            _subject.AssignDwarf(theDwarf.Object);

            // then
            Assert.That(_subject.NumberOfWorkers, Is.EqualTo(1));
        }
    }
}
