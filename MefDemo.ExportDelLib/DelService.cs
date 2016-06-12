using System.ComponentModel.Composition;
using MefDemo.Contracts;

namespace MefDemo.ExportDelLib
{
    [Export(typeof(IService))]
    public class DelService : IService
    {
        public string Description => @"Del Service";
        public int Opertation(int a, int b)
        {
            return a - b;
        }
    }
}
