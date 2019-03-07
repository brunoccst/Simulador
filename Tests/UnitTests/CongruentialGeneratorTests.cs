using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simulator.Generators;

namespace UnitTests
{
    [TestClass]
    public class CongruentialGeneratorTests
    {
        public CongruentialGenerator Generator { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Generator = new CongruentialGenerator();
        }

        [TestMethod]
        public void Test_3_11_4()
        {
            // Arrange
            int a = 3;
            int M = 11;
            int x0 = 4;

            float[] expectedResult = { 1 };

            // Act
            float[] result = Generator.Generate(a, M, x0);

            // Assert
            foreach (float f1 in result)
            {
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
