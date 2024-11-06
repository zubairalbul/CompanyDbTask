using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDbTask
{
    [PrimaryKey(nameof(Dnumber), nameof(DLocation))]
    public class DEPT_LOCATION
    {
        [ForeignKey("DEPARTMENT")]
        public int Dnumber { get; set; }
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        
        public string DLocation { get; set; }
    }
}
