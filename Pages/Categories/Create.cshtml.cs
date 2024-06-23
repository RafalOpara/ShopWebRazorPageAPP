using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopWebRazor.Data;
using ShopWebRazor.Models;

namespace ShopWebRazor.Pages.Categories
{
    public class CreateModel : PageModel
    {

        private readonly ShopWebDbContext _dbContext;
        [BindProperty]
        public Category Category { get; set; }

        public CreateModel(ShopWebDbContext context)
        {
            _dbContext = context;
        }
        public void OnGet()
        {

        }

        public  IActionResult OnPost()
        {
            _dbContext.Categories.Add(Category);
            _dbContext.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
