using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _110124.Views.Categories
{
    public class GetById : PageModel
    {
        private readonly ILogger<GetById> _logger;

        public GetById(ILogger<GetById> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}