using Autofac.Extras.Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine.Tests
{


    [TestFixture, ExcludeFromCodeCoverage]
    class PlanetTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatePlanet_GivenProperNameOfPlanet_CreateInstance()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange

                //act
                var pandora = Planet.CreatePlanet("Pandora"); 
                //assert
                Assert.AreEqual("Pandora", pandora.Name);
            }
        }

        [Test]
        public void CreatePlanet_GivenInvlidNameOfPlanet_ThrowException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange
                var name = "XYZ";

                //act
               // var pandora = Planet.CreatePlanet(name);
                //assert
                Assert.Multiple(() =>
                {
    
                var ex = Assert.Throws<ArgumentException>(() => { var pandora = Planet.CreatePlanet(name); });
                Assert.AreEqual("Invalid Planet", ex.Message);     
    
                });

            }
        }


    }
}
