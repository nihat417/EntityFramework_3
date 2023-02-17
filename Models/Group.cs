using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Models
{
    public class Group : BaseEntity
    {
        public string? Name { get; set; }
        public int Id_Faculty { get; set; }

        public Faculty? Faculty { get; set; }
        public List<Student>? Students { get; set; }
    }
}
