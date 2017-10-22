using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseEntities
{
    public partial class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "badger") { }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Job> Job { get; set; }
    }

    [Table("employee")]
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("employeeID")]
        public int employeeid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }

    [Table("job")]
    public class Job
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("job_id")]
        public int job_id { get; set; }
        public int jobnumber { get; set; }
        public string jobname { get; set; }
    }
}
