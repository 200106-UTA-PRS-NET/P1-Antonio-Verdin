using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;

namespace PizzaBox.WebUI.Controllers
{
    public class AddressingsController : Controller
    {
        private readonly PizzaBoxContext _context;

        public AddressingsController(PizzaBoxContext context)
        {
            _context = context;
        }

        // GET: Addressings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Addressing.ToListAsync());
        }

        // GET: Addressings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressing = await _context.Addressing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressing == null)
            {
                return NotFound();
            }

            return View(addressing);
        }

        // GET: Addressings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Addressings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,City,Address1,Address2,Street,PhoneNumber")] Addressing addressing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addressing);
        }

        // GET: Addressings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressing = await _context.Addressing.FindAsync(id);
            if (addressing == null)
            {
                return NotFound();
            }
            return View(addressing);
        }

        // POST: Addressings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,City,Address1,Address2,Street,PhoneNumber")] Addressing addressing)
        {
            if (id != addressing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressingExists(addressing.Id))
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
            return View(addressing);
        }

        // GET: Addressings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressing = await _context.Addressing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressing == null)
            {
                return NotFound();
            }

            return View(addressing);
        }

        // POST: Addressings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressing = await _context.Addressing.FindAsync(id);
            _context.Addressing.Remove(addressing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressingExists(int id)
        {
            return _context.Addressing.Any(e => e.Id == id);
        }
    }
}
