using Autofac.Extras.Moq;
using DevSkill.ProjectDeathStar.BattleEngine;
using NUnit.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DevSkill.ProjectDeathStar.BattleEngine.Tests
{

    [TestFixture, ExcludeFromCodeCoverage]
    public class BattleShipTests
    {
        public Battleship BattleShip { get; private set; }

        [SetUp]
        public void Setup()
        {



        }

        [Test]
        public void InstallWeapon_SetWeaponInSlot_SetWeaponInCorrectSlot()
        {


            using (var mock = AutoMock.GetLoose())
            {

                //Arrange

                var raven = Battleship.CreateBattleship("Raven");
                var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Large);

                //Act

                raven.InstallWeapon(cannon, 3);

                //Assert
                Assert.AreEqual(raven.WeaponSlots[3], cannon);

            }
        }

        [Test]
        public void CreateBattleship_GivenProperNameOfShip_CreatesCorrectShip()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var raven = Battleship.CreateBattleship("Raven");

                // Assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual("Raven", raven.Name, "Name mismatch.");
                    Assert.AreEqual(8, raven.WeaponSlots.Length, "Weapon slot mismatch");
                });

            }
        }
       
        //[MethodName]_[Scenario]_[ExpectedBehaviour]

        [Test]
        public void CreateBattleship_GivenInvalidShipname_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act


                // Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Throws<Exception>(() => Battleship.CreateBattleship("Raven2"),
                        "Expected exception is missing");
                    Assert.AreEqual("Invalid ship name", ex.Message, "Wrong error message");
                });
            }
        }

        [Test]
        public void CalculateTotalDamage_SetTwoWeaponsInDifferentSlots_GivesSummationOfWeaponsDamagePower()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                var raven = Battleship.CreateBattleship("Raven");
                mock.Mock<IWeapon>().Setup(x => x.KineticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ThermalDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ElectromagneticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ExplosiveDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.Type).Returns(WeaponType.Large);

                var cannon = mock.Create<IWeapon>();
                var cannon2 = mock.Create<IWeapon>();

                raven.InstallWeapon(cannon, 3);
                raven.InstallWeapon(cannon2, 4);

                // Act
                uint result = raven.CalculateTotalDamage();

                // Assert
                Assert.AreEqual(4000, result);
            }
        }
        [Test]
        public void InstallWeapon_InvalidWeapon_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var raven = Battleship.CreateBattleship("Raven");
                var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Doomsday);
                //var cannon = mock.Create<IWeapon>();
              

                raven.InstallWeapon(cannon, 3);
               

                // Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Throws<Exception>(() => raven.InstallWeapon(cannon, 3),
                        "Expected exception is missing");
                    Assert.AreEqual("Invalid ship name", ex.Message, "Wrong error message");
                });
            }
        }
    }
}