using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;

namespace ReviewsSite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private ITagRepository tagsRepo;

        public TagController(ITagRepository tagsRepo)
        {
            this.tagsRepo = tagsRepo;
        }

        [HttpGet("{reviewId}")]
        public IEnumerable<Tag> Get(int reviewId)
        {
            return tagsRepo.GetTagsForReviewId(reviewId);
        }

        [HttpPost]
        public bool Post([FromBody] Tag newTag, int reviewId)
        {
            newTag.ReviewTags = new List<ReviewTag>()
            {
                new ReviewTag() { ReviewId = reviewId}
            };
            tagsRepo.Create(newTag);
            return true;
        }
    }
}