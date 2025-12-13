using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Request
{
    public class AsignacionRequest
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int BusId { get; set; }
        public int RouteId { get; set; }
        public string? DriverNombre { get; set; }
        public string? BusNombre { get; set; }
        public string? RutaNombre { get; set; }
        public bool Activa { get; set; }
        public DateTime DateAssignment { get; set; }
    }
}
