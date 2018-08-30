using NUnit.Framework;
using Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTests
{
    [TestFixture]
    public class TortiseAndHareRaceTests
    {
        [Test]
        public void Race_GivenSpeed1Of100Speed2Of10DistanceOf1000SleepOf500AndGetupOf40_ShouldReturnTheTortoiseWonTheRaceTheHareIsSleepingFor91Minutes()
        {
            //Arrange
            var speed1 = 100;
            var speed2 = 10;
            var distance = 1000;
            var sleep = 500;
            var getup = 40;

            var sut = new TortiseAndHareRace();
            //Act
            var actual = sut.StartRace(speed1, speed2, distance, sleep, getup);
            //Assert
            var expected = "The tortoise won the race. The hare is sleeping for 91 minutes.";
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Race_GivenSpeed1Of100Speed2Of10DistanceOf1500SleepOf500AndGetupOf100_ShouldReturnTheHareAndTheTortoiseTiedTheHareIsSleepingFor135Minutes()
        {
            //Arrange
            var speed1 = 100;
            var speed2 = 10;
            var distance = 1500;
            var sleep = 500;
            var getup = 100;

            var sut = new TortiseAndHareRace();
            //Act
            var actual = sut.StartRace(speed1, speed2, distance, sleep, getup);
            //Assert
            var expected = "The hare and the tortoise tied. The hare is sleeping for 135 minutes.";
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Race_GivenSpeed1Of100Speed2Of10DistanceOf1200SleepOf500AndGetupOf100_ShouldReturnTheHareWonTheRaceTheHareSleepingFor105Minutes()
        {
            //Arrange
            var speed1 = 100;
            var speed2 = 10;
            var distance = 1200;
            var sleep = 500;
            var getup = 100;

            var sut = new TortiseAndHareRace();
            //Act
            var actual = sut.StartRace(speed1, speed2, distance, sleep, getup);
            //Assert
            var expected = "The hare won the race. The hare is sleeping for 105 minutes.";
            Assert.AreEqual(actual, expected);
        }
    }
}
