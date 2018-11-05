using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Controllers
{
    public class TagController : Controller
    {
        private ITagRepository tagsRepo;
        public TagController(ITagRepository tagsRepo)
        {
            this.tagsRepo = tagsRepo;
        }

        public ViewResult Details(int id)
        {
            var model = tagsRepo.FindById(id);
            return View(model);

        }
    }
}