using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Models
{
    public class Faculty : BaseEntity
    {
        public string? Name { get; set; }

        public List<Group>? Groups { get; set; }
    }
}
