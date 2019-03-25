//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Simulator.Generators;

//namespace UnitTests
//{
//    [TestClass]
//    public class CongruentialGeneratorTests
//    {
//        public CongruentialGenerator Generator { get; set; }

//        [TestInitialize]
//        public void Initialize()
//        {
//            Generator = new CongruentialGenerator();
//        }

//        [TestMethod]
//        public void Test_3_11_4()
//        {
//            // Arrange
//            int a = 3;
//            int M = 11;
//            int x0 = 4;

//            float[] expectedResult = {
//                x0, 1, 3, 9, 5, 4,
//                1, 3, 9, 5, 4, 1
//            };

//            // Act
//            float[] result = Generator.Generate(a, M, x0);

//            // Asserts
//            Assert.AreEqual(expectedResult.Length, result.Length);
//            for (int i = 0; i < result.Length; i++)
//            {
//                float f1 = expectedResult[i];
//                float f2 = result[i];
//                Assert.AreEqual(f1, f2);
//            }
//        }
//    }
//}
