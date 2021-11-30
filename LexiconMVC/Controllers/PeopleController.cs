using LexiconMVCData.Data;
using LexiconMVCData.Models;
using LexiconMVCData.Services;
using LexiconMVCData.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.Controllers
{
    public class PeopleController : Controller
    {
        private readonly LexiconMVCDbContext _context;

        public PeopleController(LexiconMVCDbContext context)
        {
            _context = context;
        }
        
        public ActionResult Index(PeopleViewModel pVM)
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.PeopleList = _context.People.ToList();
            peopleVM.SortByName = String.IsNullOrEmpty(pVM.SortOrder) ? "name_desc" : "";
            peopleVM.SortByCity = pVM.SortOrder == "city" ? "city_desc" : "city";

            if (!String.IsNullOrEmpty(pVM.SearchString))
            {
                peopleVM.PeopleList = peopleVM.PeopleList.Where(c => c.City!.Contains(pVM.SearchString) || c.Name!.Contains(pVM.SearchString)).ToList();

            }

            switch (pVM.SortOrder)
            {
                case "name_desc":
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderByDescending(p => p.Name).ToList();
                    break;
                case "city":
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderBy(p => p.City).ToList();
                    break;
                case "city_desc":
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderByDescending(p => p.City).ToList(); ;
                    break;
                default:
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderBy(p => p.Id).ToList(); ;
                    break;
            }

            return View(peopleVM);
        }

     
        [HttpPost]
        public ActionResult Create(PeopleViewModel peopleVM)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(new Person { Name = peopleVM.CreatePerson.Name, PhoneNumber = peopleVM.CreatePerson.PhoneNumber, City = peopleVM.CreatePerson.City });
                _context.SaveChanges();
            }
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var person = _context.People.Find(id);
            _context.Remove(person);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
