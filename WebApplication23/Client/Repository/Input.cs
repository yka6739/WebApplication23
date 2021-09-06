using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication23.Shared;

namespace WebApplication23.Client.Repository
{
    public interface Input
    {
        Task CreateGenre(Person person);
    }
}
