using MedicalLab.RepositoryInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;
namespace MedicalLab.Service.UnitTest
{
    /// <summary>
    /// unit test for UserService
    /// </summary>
    [TestClass]
    class UserServiceUnitTest
    {
        protected IUsersRepository repo;
        [TestInitialize]
        public void InitTest()
        {
            repo = Substitute.For<IUsersRepository>();
        }
        [TestMethod]
        public void GetUsersTest()
        {
            repo.GetUsers().ReturnsForAnyArgs(new List<Entity.User>() { new Entity.User() { UserName="testUser"} });
            var service = new UserService();
            var result = service.GetUsers();
            Assert.IsTrue(result.Count == 1);
        }
    }
}
