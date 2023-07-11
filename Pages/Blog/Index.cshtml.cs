using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp;

namespace webapp.Pages_Blog
{
    public class IndexModel : PageModel
    {
        private readonly webapp.MyWeb _context;

        public IndexModel(webapp.MyWeb context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync( string SreachString)
        {
          //  Article = await _context.articles.ToListAsync();

            var nquery = from a in _context.articles
                        orderby a.Created descending
                        select a; 
                if(!string.IsNullOrEmpty(SreachString)){
                   
                 Article =   nquery.Where(a => a.Title.Contains(SreachString)).ToList();
                }else{
                    Article =   await nquery.ToListAsync();

                }
                
                

                 

                
              
 
            

        }
    }
}
