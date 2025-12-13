using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Request
{
    public class ChoferesRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? IdCard { get; set; }
        public DateTime DataOfBirth { get; set; }
    }
}
