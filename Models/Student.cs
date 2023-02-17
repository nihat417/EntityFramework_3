using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Models
{
    public class Student : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Id_Group { get; set; }

        public Group? Group { get; set; }
        public List<S_Card>? S_Cards { get; set; }
    }
}
