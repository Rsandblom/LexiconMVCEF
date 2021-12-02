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
    public class LanguagesController : Controller
    {
        private readonly LexiconMVCDbContext _context;

        public LanguagesController(LexiconMVCDbContext context)
        {
            _context = context;
        }

        // GET: Languages
        public async Task<IActionResult> Index()
        {
            var languagesWithPersons = await _context.Languages.Include(pl => pl.PersonLanguages)
                .ThenInclude(p => p.Person).ToListAsync();

            LanguagesViewModel languagesVM = new LanguagesViewModel();
            List<LanguagesWithPersons> languagesWithPersonsList = new List<LanguagesWithPersons>();

            foreach (var item in languagesWithPersons)
            {
                var languagesPerson = item.PersonLanguages.Select(l => l.Person).ToList();
                languagesWithPersonsList.Add(new LanguagesWithPersons(item.Id, item.Name,languagesPerson));
            }

            languagesVM.LanguagesWithPersonsList = languagesWithPersonsList;

            return View(languagesVM);
        }

        [HttpPost]
        public ActionResult Create(LanguagesViewModel languagesVM)
        {
            var person = _context.People.Where(p => p.Name == languagesVM.PersonName).FirstOrDefault();
            var language = _context.Languages.Where(l => l.Name == languagesVM.LanguageName).Include(pl => pl.PersonLanguages).FirstOrDefault();

            if (person != null && language != null)
            {
                language.PersonLanguages.Add(new PersonLanguage { PersonId = person.Id });
                _context.SaveChanges();

            }

            return RedirectToAction(nameof(Index));
        }


        /* Scaffolded unsued IActionResults
        // GET: Languages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var language = await _context.Languages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // GET: Languages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Languages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Language language)
        {
            if (ModelState.IsValid)
            {
                _context.Add(language);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(language);
        }

        // GET: Languages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var language = await _context.Languages.FindAsync(id);
            if (language == null)
            {
                return NotFound();
            }
            return View(language);
        }

        // POST: Languages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Language language)
        {
            if (id != language.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(language);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanguageExists(language.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(language);
        }

        // GET: Languages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var language = await _context.Languages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // POST: Languages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var language = await _context.Languages.FindAsync(id);
            _context.Languages.Remove(language);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LanguageExists(int id)
        {
            return _context.Languages.Any(e => e.Id == id);
        }

        */
    }
}
