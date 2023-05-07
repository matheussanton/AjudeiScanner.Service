using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjudeiScanner.Infra.Dependencies
{
    public class AppSettings
    {
        public string PostgreSQLConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string ApplicationName { get; set; }
    }
}
