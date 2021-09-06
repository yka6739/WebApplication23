using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication23.Shared;

namespace WebApplication23.Client.Repository
{
    public class InputData:Input
    {
        private readonly IHttpService httpService;
        private string Url = "api/person";

        public InputData(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateGenre(Person person)
        {
            var response = await httpService.post(Url, person);
            if(response.Success)
            {
                throw new ApplicationExecution(await response.GetBody());
            }
        }

        public override bool Equals(object obj)
        {
            return obj is InputData data &&
                   EqualityComparer<IHttpService>.Default.Equals(httpService, data.httpService);
        }
    }
}
