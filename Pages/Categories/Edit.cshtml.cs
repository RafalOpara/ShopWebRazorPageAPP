using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopWebRazor.Data;
using ShopWebRazor.Models;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ShopWebDbContext _db;

        public Category Category { get; set; }
        public EditModel(ShopWebDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                TempData["success"] = "Category updated successfully";
                _db.SaveChanges();
                //TempData["success"] = "Category updated successfully";

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}