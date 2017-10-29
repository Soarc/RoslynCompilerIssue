using System;
using System.Threading.Tasks;

namespace Soarc.RoslynTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = RunTest().GetAwaiter().GetResult();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static async Task<ResultList> RunTest()
        {
            IReadFacade facade = new ReadFacade(new Repository());
            return await facade.GetAll("cont", 10);
        }
    }
}
