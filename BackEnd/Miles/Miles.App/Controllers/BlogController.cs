using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Dtos.Comments;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;

namespace Miles.App.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        private readonly IAccountService _accountService;
        private readonly ICommentService _commentService;

        public BlogController(IBlogService blogService, ICategoryService categoryService, ITagService tagService, IAccountService accountService, ICommentService commentService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _tagService = tagService;
            _accountService = accountService;
            _commentService = commentService;
        }

        public async Task<IActionResult> Index(int? id,string? search = null, int page =1)
        {
            ViewBag.IsDataLoading = true;
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
                    ViewBag.IsDataLoading = false;
                    return View(null);
                }
                ViewBag.IsDataLoading = false;
                return View(blogVM);
            }
            if (id == null)
            {
                result = await _blogService.GetAllAsync(3,page,null);
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
            ViewBag.IsDataLoading = false;
                return View(blogVM);
            }
            else
            {
                result = await _blogService.GetAllAsync(0, 0, x => !x.IsDeleted && x.BlogCategories.Any(x => x.Category.Id == id));
                TotalCount = ((IEnumerable<Blog>)result.items).Count();
                ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 3);
                result = await _blogService.GetAllAsync(3, page, x => !x.IsDeleted && x.BlogCategories.Any(x => x.Category.Id == id));
                blogVM.Blogs = (IEnumerable<Blog>)result.items;
                ViewBag.IsDataLoading = false;
                return View(blogVM);
            }

        }
        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.IsDataLoading = true;
            var resultCategory = await _categoryService.GetAllAsync(0, 0);
            var resultTag = await _tagService.GetAllAsync(0, 0);
            var resultBlog = await _blogService.GetAllAsync(0, 0,null);
            var comments = await _commentService.GetAllAsync(0, 0, null);
            BlogVM blogVM = new BlogVM
            {
                Categories = (IEnumerable<Category>)resultCategory.items,
                Tags = (IEnumerable<Tag>)resultTag.items,
                Blogs = (IEnumerable<Blog>)resultBlog.items,
                Comments = (IEnumerable<Comment>)comments.items,
            };
            var result = await _blogService.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            blogVM.Blog = (Blog)result.itemView;
            ViewBag.IsDataLoading = false;
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
        public async Task<IActionResult> PostComment(string text,string subject,int blogId,int carId)
        {
            var result = await _accountService.GetUser();
            AppUser appUser = (AppUser)result.items;
            if(appUser is null)
            {
                return Json(new { StatusCode = 404, Desc = "User not found" });
            }
            CommentPostDto dto = new CommentPostDto {
                 AppUserId = appUser.Id,
                 AppUser = appUser,
                 Subject = subject,
                 Text  = text
              };
            if(carId == 0)
            {
                dto.CarID =  null;
                dto.BlogId = blogId;
            }
            else
            {
                dto.CarID = carId;
                dto.BlogId = null;
            }
            if (!ModelState.IsValid)
            {
                return Json(new { StatusCode = 400, Desc = "Please fill all columns" });
            }
            await _commentService.CreateAsync(dto);
            return Json(new {StatusCode=200,Comment=dto});
        }
    }
}
