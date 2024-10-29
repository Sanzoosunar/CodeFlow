using CodeFlowCore.DTO;
using CodeFlowCore.Models;
using CodeFlowCore.Repos;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCL.RepoLayer
{
    [TestFixture]
    public class AuthRepoTesting
    {
        private AuthRepo _authRepo;

        [SetUp]
        public void Init()
        {
            _authRepo=new AuthRepo();
        }

        [Test]
        public void Login_ValidLogin_ReturnAuthUser()
        {
            //Arranage
            LoginDto login = new LoginDto() {UserName="admin2",Password="admin" };

            var expected = new AuthUser() { UserName = "admin" };

            //Act
            var result = _authRepo.Login(login);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Login_InvalidCredentials_ThowsInvalidDataException()
        {
            //Arranage
            LoginDto login = new LoginDto() { UserName = "user", Password = "user" };

            //Assert & Act
            Assert.Throws<ArgumentNullException>(() =>
            {
                _authRepo.Login(login);
            });
        }

        [Test]
        public void Login_NullCred_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()=> _authRepo.Login(null));
        }
    }
}
