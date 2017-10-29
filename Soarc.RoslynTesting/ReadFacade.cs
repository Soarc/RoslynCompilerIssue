using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soarc.RoslynTesting
{
    public class ReadFacade : IReadFacade
    {
        readonly IRepository _repo;
        public ReadFacade(IRepository repo)
        {
            _repo = repo;
        }
        public async Task<ResultList> GetAll(string continuation, int count)
        {
            var query = _repo.CreateQuery<ResultDocument>(continuation, count)
                .Select(x => new ResultModel(x));

            var res = await _repo.ExecuteQuery(query, count);
            return new ResultList
            {
                Continuation = res.Continuation,
                Models = res.Collection.ToArray()
            };
        }
    }
}
