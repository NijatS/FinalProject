using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using System.Reflection.Metadata;

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
            if (search != null)
            {
                result = await _blogService.GetAllAsync(0, 0, x => !x.IsDeleted && x.Title.Contains(search));
                Blogs = (IEnumerable<Blog>)result.items;
                TotalCount =Blogs.Count();
                ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 3);
                result = await _blogService.GetAllAsync(3, page, x => !x.IsDeleted && x.Title.Trim().ToLower().Contains(search.Trim().ToLower()));
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
                if (blogVM.Blogs is null)
                {
                    return View(null);
                }
                return View(blogVM);
            }
            if (id == null)
            {
                result = await _blogService.GetAllAsync(3,page,null);
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
         
                return View(blogVM);
            }
            else
            {
                result = await _blogService.GetAllAsync(0, 0, x => !x.IsDeleted && x.BlogCategories.Any(x => x.Category.Id == id));
                TotalCount = ((IEnumerable<Blog>)result.items).Count();
                ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 3);
                result = await _blogService.GetAllAsync(3, page, x => !x.IsDeleted && x.BlogCategories.Any(x => x.Category.Id == id));
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
                return View(blogVM);
            }
        }
        public async Task<IActionResult> Detail(int id)
        {
            var resultCategory = await _categoryService.GetAllAsync(0, 0);
            var resultTag = await _tagService.GetAllAsync(0, 0);
            var resultBlog = await _blogService.GetAllAsync(0, 0, x => !x.IsDeleted);
           
            BlogVM blogVM = new BlogVM
            {
                Categories = (IEnumerable<Category>)resultCategory.items,
                Tags = (IEnumerable<Tag>)resultTag.items,
                Blogs = (IEnumerable<Blog>)resultBlog.items,
            };
            var result = await _blogService.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            blogVM.Blog = (Blog)result.itemView;
            return View(blogVM);
        }
        public async Task<IActionResult> Search(string search, int page = 1)
        {
            var result = await _blogService.GetAllAsync(0, 0, x => !x.IsDeleted && x.Title.Trim().ToLower().Contains(search.Trim().ToLower()));
            IEnumerable<Blog> Blogs = (IEnumerable<Blog>)result.items;
            int TotalCount = Blogs.Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 3);
            ViewBag.CurrentPage = page;
            result = await _blogService.GetAllAsync(3, page, x => !x.IsDeleted && x.Title.Trim().ToLower().Contains(search.Trim().ToLower()));
            IEnumerable<Blog> blogs = (IEnumerable<Blog>)result.items;
            return Json(blogs);
        }
    }
}
