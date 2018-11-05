using NSubstitute;
using ReviewsSite.Controllers.Api;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewsSite.Tests
{
    public class CommentControllerTest
    {
        [Fact]
        public void GetAll_Returns_All_Comments_For_Given_Todo()
        {
            var reviewId = 42;
            var expectedModel = new List<Comment>();
            var commentRepo = Substitute.For<ICommentRepository>();
            commentRepo.GetCommentsForReviewId(reviewId).Returns(expectedModel);
            var underTest = new CommentController(commentRepo);

            var model = underTest.Get(reviewId);

            Assert.Same(expectedModel, model);
        }

        [Fact]
        public void Post_And_Saves()
        {
            var comment = new Comment();
            var commentRepo = Substitute.For<ICommentRepository>();
            var underTest = new CommentController(commentRepo);

            underTest.Post(comment);

            commentRepo.Received().Create(comment);
        }
    }
}

