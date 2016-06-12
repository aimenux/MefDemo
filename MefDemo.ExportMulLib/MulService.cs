using System.ComponentModel.Composition;
using MefDemo.Contracts;

namespace MefDemo.ExportMulLib
{
    [Export(typeof(IService))]
    public class MulService : IService
    {
        public string Description => @"Mul Service";

        public int Opertation(int a, int b)
        {
            return a*b;
        }
    }
}
