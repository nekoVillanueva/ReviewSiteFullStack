
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using System;
using Xunit;

namespace ReviewsSite.Tests
{
    public class HomeControllerTests
    {
        IReviewRepository reviewRepo;
        HomeController underTest;

        public HomeControllerTests()
        {
            reviewRepo = Substitute.For<IReviewRepository>();
            underTest = new HomeController(reviewRepo);
        }
        [Fact]
        public void Index_Returns_A_View()
        {

            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Details_Sets_Review_To_Model()
        {
            var expectedModel = new Review();
            reviewRepo.FindById(1).Returns(expectedModel);
            var result = underTest.Details(1);
            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        


        

    }
}
