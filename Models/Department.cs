using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Models
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }

        public List<Teacher>? Teachers { get; set; }
    }
}
