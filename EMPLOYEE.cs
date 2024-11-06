using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDbTask
{
    public class EMPLOYEE
    {
        public string Fname { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ssn { get; set; }
        public DateTime Bdate { get; set; }
        public string Address { get; set; }
        public enum Gennder { male, female, other } 
        public decimal Salary { get; set; }
        [ForeignKey("SuperVisor")]
        public int Super_ssn { get; set; }
        public virtual EMPLOYEE SuperVisor { get; set; }
        [InverseProperty("SuperVisor")]
        public ICollection<EMPLOYEE> Employees { get; set; }
        [ForeignKey("DEPARTMENTS")]
        public int Dnumber { get; set; }
        public  DEPARTMENT DEPARTMENTS { get; set; }
        public ICollection<WORKS_ON> Works { get; set; }

    }
}
