using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtpCore.Pages.Components.PlayerExpanded
{
    public class PlayerBiosModel : PageModel
    {

        public PlayerBiosData PlayerData { get; set; }

        public void OnGet()
        {
        }
    }
}
