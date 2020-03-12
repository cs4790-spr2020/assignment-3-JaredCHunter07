using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemory_Blab_UnitTests
    {
        private InMemory<Blab> _harness;
        public InMemory_Blab_UnitTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes")
                .Options;
            _harness = new InMemory<Blab>(new ApplicationContext(options));
        }
        [TestMethod]
        public void Add_Blab_GetByUserId_Success()
        {
            string Email = "foo@example.com";
            Blab Expected = new Blab();
            Expected.Message = "Lorem Ipsum";
            Expected.UserID = Email;
            var sysId = Expected.getSysId();
            _harness.Add(Expected);

            Blab Actual = (Blab) _harness.GetByUserId(Email);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
