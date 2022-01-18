using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdemITHome.Data;
using AdemITHome.Models;

namespace AdemITHome.Pages_Articles
{
    public class DetailsModel : PageModel
    {
        private readonly AdemITHome.Data.AdemITHomeContext _context;

        public DetailsModel(AdemITHome.Data.AdemITHomeContext context)
        {
            _context = context;
        }

        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Article.FirstOrDefaultAsync(m => m.ID == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
