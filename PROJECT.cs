using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDbTask
{
    public class PROJECT
    {
        [Required]
        public string Pname { get; set; }
        [Key]
        public int Pnumber { get; set; }
        public string PLocation { get; set; }
        [ForeignKey("DNumbers")]
        public int Dnum { get; set; }
        public DEPARTMENT DNumbers { get; set; }
        public ICollection<WORKS_ON> WorksOn { get; set; }

    }
}
