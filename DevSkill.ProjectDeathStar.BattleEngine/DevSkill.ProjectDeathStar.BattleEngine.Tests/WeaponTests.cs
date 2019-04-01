using Autofac.Extras.Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    class WeaponTests
    {
        [SetUp]
        public void SetUp()
        {


        }
        [Test]
        public void CreateWeapon_GivenProperNameOfWeapon_CreateCorrectWeapon()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange

                // var Mock = mock.Mock<IWeapon>();

                //act

                var cannon1 = Weapon.CreateWeapon("Cannon", WeaponType.Large);

                //assert
                Assert.AreEqual(cannon1.Name, "Cannon");
            }
        }
        [Test]
        public void CreateWeapon_ProvideInvlidWeaponName_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange

                var name = "xyz";
                //act

                //assert
                Assert.Multiple(() =>
                {

                    var ex = Assert.Throws<ArgumentException>(() => { Weapon.CreateWeapon(name, WeaponType.Large); });
                    Assert.AreEqual("Invalid Weapon", ex.Message);

                });

            }
        }

        [Test]
        public void CreateLaser_ProvideInvlidWeaponSize_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange

                var name = "Laser";
               
                //act

                //assert
                Assert.Multiple(() =>
                {

                    var ex = Assert.Throws<ArgumentException>(() => { Weapon.CreateWeapon(name, WeaponType.Doomsday); });
                    Assert.AreEqual("Invalid Size", ex.Message);

                });

            }
        }
    }
}
