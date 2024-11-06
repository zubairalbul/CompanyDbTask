using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDbTask
{
    public class WORKS_ON
    {
        [ForeignKey("EMPLOYEE")]
        public int Essn { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        [ForeignKey("PROJECT")]
        public int Pno { get; set; }
        public virtual PROJECT PROJECT { get; set; }
        public float Hours { get; set; }
    }
}
