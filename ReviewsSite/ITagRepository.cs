using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public interface ITagRepository
    {
        Tag FindById(int id);
        IEnumerable<Tag> GetTagsForReviewId(int reviewId);
        void Create(Tag tag);
    } //honestly EVERYTHING works :) 
}
