using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simulator.Generators;

namespace UnitTests
{
    [TestClass]
    public class LinearCongruentialGeneratorTests
    {
        public LinearCongruentialGenerator Generator { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Generator = new LinearCongruentialGenerator();
        }

        [TestMethod]
        public void Test_4_9_4_7()
        {
            // Arrange
            int a = 4;
            int M = 9;
            int c = 4;
            int x0 = 7;

            float[] expectedResult = {
                x0, 5, 6, 1, 8,
                0, 4, 2, 3, 7
            };

            // Act
            float[] result = Generator.Generate(a, c, M, x0);

            // Assert
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                float f1 = expectedResult[i];
                float f2 = result[i];
                Assert.AreEqual(f1, f2);
            }
        }
    }
}
