using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LexiconMVCData.Data;
using LexiconMVCData.Models;
using LexiconMVCData.ViewModels;

namespace LexiconMVCData.Controllers
{
    public class CountriesController : Controller
    {
        private readonly LexiconMVCDbContext _context;

        public CountriesController(LexiconMVCDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var countryList = _context.Countries.Include(c => c.Cities).ToList();
            List<CountriesViewModel> countriesVMList = new List<CountriesViewModel>();

            if (countryList.Count > 0)
            {
                foreach (var item in countryList)
                {
                    CountriesViewModel countriesVM = new CountriesViewModel(item);
                    countriesVMList.Add(countriesVM);
                }
            }
            
            return View(countriesVMList);
        }

       
    }
}
