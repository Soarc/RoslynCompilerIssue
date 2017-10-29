using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soarc.RoslynTesting
{
    public class Repository : IRepository
    {
        public IQueryable<TDocument> CreateQuery<TDocument>(string continuation = null, int maxDocumentsCount = -1) where TDocument : IDocument
        {
            return Enumerable.Empty<TDocument>().AsQueryable();
        }

        public Task<(IEnumerable<T> Collection, string Continuation)> ExecuteQuery<T>(IQueryable<T> query, int maxDocumentCount = -1)
        {
            (IEnumerable<T> Collection, string Continuation) res = (Enumerable.Empty<T>(), string.Empty);
            return Task.FromResult(res);
        }
    }
}
