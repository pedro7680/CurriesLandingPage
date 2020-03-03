using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingPageRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LandingPageRazor
{
    public class IndexModel : PageModel
    {
        // page for
        // retrieve all of the contacts from the database

        private readonly ApplicationDbContext _db;

        // get instance of the db with dependancy injection
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Contact> Contacts { get; set; }

        public async Task OnGet()
        {
            Contacts = await _db.Contact.ToListAsync();
        }
    }
}