using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ua_acm_website.Data;
using ua_acm_website.Models;

namespace ua_acm_website.Views
{
    public class CodingResourcesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CodingResourcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CodingResources
        public async Task<IActionResult> Index()
        {
            return View(await _context.CodingResource.ToListAsync());
        }

        // GET: CodingResources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codingResource = await _context.CodingResource
                .FirstOrDefaultAsync(m => m.Id == id);
            if (codingResource == null)
            {
                return NotFound();
            }

            return View(codingResource);
        }

        // GET: CodingResources/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CodingResources/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Resource,TopicCovered,ApplicableClasses,ResourceLink")] CodingResource codingResource)
        {
            if (ModelState.IsValid)
            {
                _context.Add(codingResource);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(codingResource);
        }

        // GET: CodingResources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codingResource = await _context.CodingResource.FindAsync(id);
            if (codingResource == null)
            {
                return NotFound();
            }
            return View(codingResource);
        }

        // POST: CodingResources/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Resource,TopicCovered,ApplicableClasses,ResourceLink")] CodingResource codingResource)
        {
            if (id != codingResource.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(codingResource);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CodingResourceExists(codingResource.Id))
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
            return View(codingResource);
        }

        // GET: CodingResources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codingResource = await _context.CodingResource
                .FirstOrDefaultAsync(m => m.Id == id);
            if (codingResource == null)
            {
                return NotFound();
            }

            return View(codingResource);
        }

        // POST: CodingResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var codingResource = await _context.CodingResource.FindAsync(id);
            _context.CodingResource.Remove(codingResource);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CodingResourceExists(int id)
        {
            return _context.CodingResource.Any(e => e.Id == id);
        }
    }
}
