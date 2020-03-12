using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest {
    [TestClass]
    public class BaseEntityTest {
        private BaseEntity _harness;
        public BaseEntityTest() {
            _harness = new BaseEntity();
        }

        [TestMethod]
        public void TestSetGetSysId()
        {
            string expected = _harness.getSysId();

            string actual = _harness.getSysId();
            
            Assert.AreEqual(actual.ToString(), expected.ToString());
            Assert.AreEqual(true, _harness.getSysId() is string);            
        }

        [TestMethod]
        public void TestCreatedDTTM() {
            BaseEntity Expected = new BaseEntity();
            BaseEntity Actual = new BaseEntity();
            Assert.AreEqual(Expected.CreatedDTTM.ToString(), Actual.CreatedDTTM.ToString());
        }

        [TestMethod]
        public void TestModifiedDTTM() {
            BaseEntity Expected = new BaseEntity();
            BaseEntity Actual = new BaseEntity();
            Assert.AreEqual(Expected.ModifiedDTTM.ToString(), Actual.ModifiedDTTM.ToString());
        }
    }
}