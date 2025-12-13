using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Entities
{
    public class Autobuses
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? LicensePlate { get; set; }
        public string? Color { get; set; }
        public int Year { get; set; }
        public bool IsDeleted { get; set; }
        public string? MarcaModelo => Brand + " " + Model;

        public bool Activo { get;  set; }
    }
}
