using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    public class ResturantCountViewComponent: ViewComponent
    {
        private readonly IResturantData resturantData;

        public ResturantCountViewComponent(IResturantData resturantData)
        {
            this.resturantData = resturantData;
        }
        public IViewComponentResult Invoke()
        {
            var count = resturantData.GetCountOfResturants();
            return View(count);
        }
        
    }
}
