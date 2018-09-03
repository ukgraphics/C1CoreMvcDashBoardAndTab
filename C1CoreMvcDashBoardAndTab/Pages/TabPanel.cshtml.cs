using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C1CoreMvcDashBoardAndTab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C1CoreMvcDashBoardAndTab.Pages
{
    public class TabPanelModel : PageModel
    {
        public IEnumerable<ProductData> data;

        public void OnGet()
        {
            data = ProductDashboardData.GetProductData();
        }
    }
}