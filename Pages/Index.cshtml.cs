using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyWeb myWeb;

        public IndexModel(ILogger<IndexModel> logger, MyWeb _myWeb )
        {
            _logger = logger;
            myWeb = _myWeb;
           
        
        }

        public void OnGet()
        {
            var post = (from a in myWeb.articles
                        orderby a.Created descending
                        select a).ToList();

                 ViewData["post"] = post;       

        }
    }
}
