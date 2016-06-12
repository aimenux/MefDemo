using MefDemo.Contracts;
using System.ComponentModel.Composition;

namespace MefDemo.ExportSumLib
{
    [Export(typeof(IService))]
    public class SumService : IService
    {
        public string Description => @"Sum Service";

        public int Opertation(int a, int b)
        {
            return a + b;
        }
    }
}
