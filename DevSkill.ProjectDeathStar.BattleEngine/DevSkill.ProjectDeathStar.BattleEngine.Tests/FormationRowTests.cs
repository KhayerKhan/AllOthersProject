using Autofac.Extras.Moq;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    class FormationRowTests
    {
        [SetUp]
        public void Setup()
        {



        }
        [Test]
        public void FormationRow_WhenCalled_SetSelectedShipAndAmount()
        {


            using (var mock = AutoMock.GetLoose())
            {
                //arrange
                
                var formationRow = new FormationRow(, 10000);

                var shipmock = mock.Mock<Ship>();


                //act


                //assert


            }
        }


    }
}
