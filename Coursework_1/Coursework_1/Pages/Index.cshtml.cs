using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursework_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Coursework_1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WarehouseContext _context;
        public List<Category> Categories { get; set; }

        public IndexModel(WarehouseContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            Categories = _context.Categories.AsNoTracking().ToList();
        }
    }
}
