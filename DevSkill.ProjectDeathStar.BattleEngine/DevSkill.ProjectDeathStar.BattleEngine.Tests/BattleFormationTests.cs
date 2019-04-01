using Autofac.Extras.Moq;
using DevSkill.ProjectDeathStar.BattleEngine;
using NUnit.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DevSkill.ProjectDeathStar.BattleEngine.Tests
{

    [TestFixture, ExcludeFromCodeCoverage]
    public class BattleFormationTests
    {
        public Battleship BattleShip { get; private set; }

        [SetUp]
        public void Setup()
        {



        }
        //SetFormationRow(Ship selectedShip, uint amountOfShips, uint rowPosition)

        [Test]
        public void SetFormation_InvalidInput_SetsRowWithSpecifiedQuntaty()
        {


            using (var mock = AutoMock.GetLoose())
            {

                //Arrange

                BattleFormation battleFormation = new BattleFormation("Foramtion 1");
                //var raven = Battleship.CreateBattleship("Raven");
                var shipmock = mock.Mock<Ship>();

                var ship = shipmock.Object;
                //Act
                battleFormation.SetFormationRow(ship, 2000, 4);

                //Assert
                Assert.AreSame(battleFormation.Rows[4].SelectedShip, ship);

            }
        }

        [Test]
        public void SetFormation_GivenInvalidRowPosition_ThrowException()
        {

            using (var mock = AutoMock.GetLoose())
            {
                BattleFormation battleFormation = new BattleFormation("Foramtion 2");
                //var raven = Battleship.CreateBattleship("Raven");
                var shipmock = mock.Mock<Ship>();

                var ship = shipmock.Object;
                //Act
                // battleFormation.SetFormationRow(ship, 2000, 7);

                //Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Catch<Exception>(() => battleFormation.SetFormationRow(ship, 200, 7),
                        "Expected exception is missing");
                    Assert.AreEqual("Invalid Row Position", ex.Message, "Wrong error message");

                });

            }
        }
        [Test]
        public void CreateBattleFormation_CheckInitializationValue_ReturnsCorrectInstance()
        {

            using (var mock = AutoMock.GetLoose())
            {

                var name = "Formation 2";

                //Act
                // battleFormation.SetFormationRow(ship, 2000, 7);
                BattleFormation battleFormation = new BattleFormation(name);

                //Assert
               Assert.AreEqual(name, battleFormation.Name);           
                Assert.IsNull(battleFormation.GeneralInCharge);

            }
        }
       

        [Test]
        public void ActivateFormation_ProvideProperValue_SuccessfullyActivated()
        {

            using (var mock = AutoMock.GetLoose())
            {

                var name = "Formation 2";
                BattleFormation battleFormation = new BattleFormation(name);
                var generalMock = mock.Create<General>();

                //Act
                battleFormation.ActivateFormation(generalMock);


                //Assert
                Assert.AreEqual(generalMock, battleFormation.GeneralInCharge);
                Assert.IsTrue( battleFormation.IsActive);
                

            }
        }

        [Test]
        public void ActivateFormation_ProvideNullValue_ThrowsException()
        {

            using (var mock = AutoMock.GetLoose())
            {
                //arrange
                var name = "Formation 2";
                BattleFormation battleFormation = new BattleFormation(name);
                var generalMock = mock.Create<General>();

                //Act

                //Assert
                
                     Assert.Throws<ArgumentNullException>(() => battleFormation.ActivateFormation(null),
                        null, "assignedGeneral");

            }
        }
        [Test]
        public void BattleFormation_CheckInTotalFormationLength_ReturnTotalLength()
        {

            using (var mock = AutoMock.GetLoose())
            {

                var name = "Formation 2";


                //Act        
                BattleFormation battleFormation = new BattleFormation(name);

                //Assert

                Assert.AreEqual(6, battleFormation.Rows.Length);


            }
        }

        [Test]
        public void BattleFormation_GivenInvalidFormationLength_ThrowException()
        {

            using (var mock = AutoMock.GetLoose())
            {

                var name = "Formation 2";

                //Act        
                BattleFormation battleFormation = new BattleFormation(name);

                //Assert

                Assert.AreNotEqual(7, battleFormation.Rows.Length, "Invalid Formation Length");


            }
        }
        //[Test]
        //public void SetFormationRow_AssignShipToFormationRow_SuccessfullyAssigned()
        //{

        //    using (var mock = AutoMock.GetLoose())
        //    {

        //        var name = "Formation 2";
        //        BattleFormation battleFormation = new BattleFormation(name);
        //        var shipMock=mock
        //        //Act        
        //        battleFormation.SetFormationRow(BattleShip, 1000, 3);
                
        //        //Assert

        //        Assert.AreNotEqual(7, battleFormation.Rows.Length, "Invalid Formation Length");


        //    }
        //}


    }
}