using System;
using MefDemo.Contracts;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace MefDemo.ImportLib
{
    public class Importer
    {
        [ImportMany(typeof(IService))]
        public IEnumerable<IService> Services { get; set; }

        public void DoImport()
        {
            var aggregate = new AggregateCatalog();
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (directory == null) throw new ApplicationException();
            using (var catalog = new DirectoryCatalog(directory))
            using (var container = new CompositionContainer(aggregate))
            {
                aggregate.Catalogs.Add(catalog);
                container.ComposeParts(this);
            }
        }
    }
}
