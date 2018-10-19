using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;

namespace ReviewsSite.Tests
{
    public class ReviewRepositoryTests
    {
        [Fact]
        public void GetAll_Returns_3_Shoes()
        {
            var underTest = new ReviewRepository();
            var result = underTest.GetAll();
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void Find_By_Id()
        {
            var underTest = new ReviewRepository();
            var result = underTest.FindById(1);
            Assert.Equal(1, result.Id);
            Assert.Equal("Nike", result.title);
        }
    }
}
