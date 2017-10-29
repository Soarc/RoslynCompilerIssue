using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Soarc.RoslynTesting
{
    public interface IReadFacade
    {
        Task<ResultList> GetAll(string continuation, int count);
    }
}
