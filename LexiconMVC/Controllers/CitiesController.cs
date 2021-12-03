using LexiconMVCData.Data;
using LexiconMVCData.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LexiconMVCData.Controllers
{
    public class CitiesController : Controller
    {
        private readonly LexiconMVCDbContext _context;

        public CitiesController(LexiconMVCDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var cityList = _context.Cities.Include(c => c.People).ToList();
            List<CitiesViewModel> citiesVMList = new List<CitiesViewModel>();

            if (cityList.Count > 0)
            {
                foreach (var item in cityList)
                {
                    CitiesViewModel citiesVM = new CitiesViewModel(item);
                    citiesVMList.Add(citiesVM);
                }
            }

            return View(citiesVMList);
        }

        
    }
}
