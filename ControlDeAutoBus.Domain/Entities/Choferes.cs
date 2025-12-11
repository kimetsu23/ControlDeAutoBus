using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Entities
{
    public class Choferes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? IdCard { get; set; }
        public DateTime DataOfBirth { get; set; }

        public bool IsDeleted { get; set; }
    }
}
