using EnterpriseWebRazor_Temp.Data;
using EnterpriseWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {

        public List<Category> CategoryList { get; set; }

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
