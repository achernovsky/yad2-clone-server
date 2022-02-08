using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yad2_clone_server.Models;

namespace yad2_clone_server.Repositories
{
    public class ListingsRepo : IListingsRepo
    {
        private readonly ApplicationDbContext _context;
        public ListingsRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Listing>> GetListings()
        {
            var listings = await _context.Listings.ToListAsync();
            return listings;
        }
    }
}
