using System;
using MefDemo.ImportLib;

namespace MefDemo
{
    class Program
    {
        static void Main()
        {
            var importer = new Importer();
            importer.DoImport();

            foreach (var service in importer.Services)
            {
                Console.WriteLine($"{service.Description} ; {service.Opertation(10,5)}");
            }

            Console.ReadKey();
        }
    }
}
