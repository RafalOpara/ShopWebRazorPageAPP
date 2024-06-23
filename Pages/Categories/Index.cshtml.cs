using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopWebRazor.Data;
using ShopWebRazor.Models;

namespace ShopWebRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ShopWebDbContext _dbContext;
        public List<Category> CategoryList { get; set; }

        public IndexModel(ShopWebDbContext context)
        {
            _dbContext = context;
        }

        public void OnGet()
        {
            CategoryList = _dbContext.Categories.ToList();
        }
    }
}
