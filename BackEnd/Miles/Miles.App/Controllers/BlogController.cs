using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;

namespace Miles.App.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;

        public BlogController(IBlogService blogService, ICategoryService categoryService, ITagService tagService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _tagService = tagService;
        }

        public async Task<IActionResult> Index(int? id,string? search = null, int page =1)
        {
            var result = await _blogService.GetAllAsync(0, 0,null);
            IEnumerable<Blog> Blogs = (IEnumerable<Blog>)result.items;
            int TotalCount = Blogs.Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 3);
            ViewBag.CurrentPage = page;
            var resultCategory = await _categoryService.GetAllAsync(0, 0);
            var resultTag = await _tagService.GetAllAsync(0, 0);
            BlogVM blogVM = new BlogVM
            {
                Categories = (IEnumerable<Category>)resultCategory.items,
                Tags = (IEnumerable<Tag>)resultTag.items
            };
            if (id == null)
            {
                result = await _blogService.GetAllAsync(TotalCount,page,null);
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
                return View(blogVM);
            }
            else
            {
                result = await _blogService.GetAllAsync(0, 0, x => !x.IsDeleted && x.BlogCategories.Any(x => x.Category.Id == id));
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
                return View(blogVM);
            }
        }
    }
}
