using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soarc.RoslynTesting
{
    public interface IRepository
    {
        IQueryable<TDocument> CreateQuery<TDocument>(string continuation = null, int maxDocumentsCount = -1) where TDocument : IDocument;

        Task<(IEnumerable<T> Collection, string Continuation)> ExecuteQuery<T>(IQueryable<T> query, int maxDocumentCount = -1);
    }
}
