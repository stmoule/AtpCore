using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtpCore.Pages
{
    public class PlayerInfoModel : PageModel
    {
        public int MyProperty { get; set; }

        public void OnGet()
        {
            
        }
    }
}
