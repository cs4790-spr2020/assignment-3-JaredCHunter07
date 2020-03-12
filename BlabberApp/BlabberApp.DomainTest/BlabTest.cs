using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabTest
    {
        [TestMethod]
        public void TestSetGetMessage()
        {
            // Arrange
            Blab harness = new Blab();
            string expected = "It's a me, testio!";
            harness.Message = "It's a me, testio!";
            // Act
            string actual = harness.Message;
            // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }

        [TestMethod]
        public void TestSetGetUserId()
        {
            // Arrange
            Blab harness = new Blab();
            string expected = "e1fc18c6-19e0-4445-be3a-d87860c4f204";
            harness.UserID = "e1fc18c6-19e0-4445-be3a-d87860c4f204";
            // Act
            string actual = harness.UserID;
            // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }

        [TestMethod]
        public void TestSetGetSysId()
        {
            Blab harness = new Blab();
            string expected = harness.getSysId();

            string actual = harness.getSysId();
            
            Assert.AreEqual(actual.ToString(), expected.ToString());
            Assert.AreEqual(true, harness.getSysId() is string);            
        }

        [TestMethod]
        public void TestDTTM()
        {
            Blab Expected = new Blab();
            
            Blab Actual = new Blab(); //failed because Expected and Actual aren't created at the same time

            Assert.AreEqual(Expected.DTTM.ToString(), Actual.DTTM.ToString());
        }
    }
}
