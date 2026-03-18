using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureUserApp;

namespace SecureUserApp.Tests
{
    [TestClass]
    public class UserTests
    {
        private User user;

        [TestInitialize]
        public void Setup()
        {
            user = new User();
        }

        [TestMethod]
        public void Register_ShouldHashPassword()
        {
            user.Register("ganesh", "1234");

            Assert.AreNotEqual("1234", user.HashedPassword);
        }

        [TestMethod]
        public void Authenticate_ShouldReturnTrue()
        {
            user.Register("ganesh", "1234");

            bool result = user.Authenticate("ganesh", "1234");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Authenticate_ShouldReturnFalse()
        {
            user.Register("ganesh", "1234");

            bool result = user.Authenticate("ganesh", "wrong");

            Assert.IsFalse(result);
        }
    }
}