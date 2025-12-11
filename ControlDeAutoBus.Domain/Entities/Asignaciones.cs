using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Entities
{
    public class Asignaciones
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int BusId { get; set; }
        public int RouteId { get; set; }
        public DateTime DateAssignment { get; set; }
        public bool IsDeleted { get; set; }
    }
}
