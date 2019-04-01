using Autofac.Extras.Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace Tests
{
    [TestFixture,ExcludeFromCodeCoverage]

    public class RavenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using(var mock=AutoMock.GetLoose())
            {

            }
        }
    }
}