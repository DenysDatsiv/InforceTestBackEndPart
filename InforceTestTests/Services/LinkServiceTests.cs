using Microsoft.VisualStudio.TestTools.UnitTesting;
using InforceTest.Services;
using InforceTest.Models;
using System.Collections.Generic;

namespace InforceTest.Services.Tests
{
    [TestClass]
    public class LinkServiceTests
    {
        [TestMethod]
        public void Create_ValidLink_ReturnsLink()
        {
            var linkService = new LinkService();
            var link = new Link { };

            var result = linkService.Create(link);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_ValidId_ReturnsLink()
        {
            var linkService = new LinkService();
            var link = new Link { Id = 1};

            var result = linkService.Get(link.Id);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_InvalidId_ReturnsNull()
        {
            var linkService = new LinkService();

            var result = linkService.Get(-1);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void List_ReturnsListOfLinks()
        {
            var linkService = new LinkService();

            var result = linkService.List();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<Link>));
        }


        [TestMethod]
        public void Delete_ValidId_ReturnsTrue()
        {
            var linkService = new LinkService();
            var linkIdToDelete = 1;

            var result = linkService.Delete(linkIdToDelete);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete_InvalidId_ReturnsFalse()
        {
            var linkService = new LinkService();
            var linkIdToDelete = -1;

            var result = linkService.Delete(linkIdToDelete);

            Assert.IsFalse(result);
        }
    }
}
