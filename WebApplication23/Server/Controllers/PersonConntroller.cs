using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication23.Shared;

namespace WebApplication23.Server.Controllers
{
    public class PersonConntroller:ControllerBase
    {
        private readonly ApplicationDBContext context;
        public PersonConntroller(ApplicationDBContext context)
            {
            this.context=context;
        }

        public async Task<ActionResult<int>>Post(Person person)
        {
            context.Add(person);
            await context.SaveChangesAsync();
            return person.Id;
        }

    }
}
