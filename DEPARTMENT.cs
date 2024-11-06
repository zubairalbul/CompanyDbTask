using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDbTask
{
    public class DEPARTMENT
    {
        public string Dname { get; set; }
        [Key] 
        public int Dnumber { get; set; }
        [ForeignKey("Managers")]
        public int Mgr_ssn { get; set; }
        public EMPLOYEE Managers { get; set; }
        [InverseProperty("DEPARTMENTS")]
        public ICollection<EMPLOYEE> Employees { get; set; }

        public DateTime Manager_Start { get; set; }
        public ICollection<DEPT_LOCATION> DEPTLocations { get; set; }
        public ICollection<PROJECT> PROJECTs { get; set; }  
    }
}
