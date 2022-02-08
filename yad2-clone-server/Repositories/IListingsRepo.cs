using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yad2_clone_server.Models;

namespace yad2_clone_server.Repositories
{
    public interface IListingsRepo
    {
        Task<IEnumerable<Listing>> GetListings();
    }
}
