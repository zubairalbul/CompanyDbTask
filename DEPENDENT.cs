using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDbTask
{
    public class DEPENDENT
    {
        [PrimaryKey(nameof(Essn), nameof(DependentName))]
        public class Dependent
        {
            [ForeignKey("Employees")]
            public int Essn { get; set; }
            public virtual EMPLOYEE Employees { get; set; }

            public string DependentName { get; set; }

            public string Sex { get; set; }

            public DateTime Bdate { get; set; }

            public string Relationship { get; set; }

        }
    }
}
