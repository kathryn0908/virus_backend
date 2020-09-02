using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using virus_mvc.Models;
using System.Text.Encodings.Web;
using virus_mvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace virus_mvc.Controllers
{
    public class VirusDataController : Controller
    {
       public async Task<IActionResult> Index()
        {
            return View(await _context.VirusData.ToListAsync());
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // GET: VirusData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var virus = await _context.VirusData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (virus == null)
            {
                return NotFound();
            }

            return View(virus);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var virus = await _context.VirusData.FindAsync(id);
            if (virus == null)
            {
                return NotFound();
            }
            return View(virus);
        }

     
        // POST: Movies/Edit/5
// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] VirusData virus)
        // {
        //     if (id != virus.Id)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(virus);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!VirusDataExists(virus.Id))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction("Index");
        //     }
        //     return View(virus);
        // }
        
    private readonly virus_mvcContext _context;

        public VirusDataController(virus_mvcContext context)
        {
            _context = context;
        }
    }
}
