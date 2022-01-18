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
    public class IndexModel : PageModel
    {
        private readonly AdemITHome.Data.AdemITHomeContext _context;

        public IndexModel(AdemITHome.Data.AdemITHomeContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
