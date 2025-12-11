using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Entities
{
    public class Ruta
    {
        public int Id { get; set; }
        public string? NameRoute { get; set; }
        public bool IsDeleted { get; set; }
    }
}
