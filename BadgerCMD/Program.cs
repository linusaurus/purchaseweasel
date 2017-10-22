using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using PurchaseEntities;

using System.ComponentModel.DataAnnotations.Schema;

namespace BadgerCMD
{

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

    public partial class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "badger") { }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Job> Job { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new db_Entities())
            {
                var jobs = context.Job.ToList();
                foreach (var cust in jobs)
                {
                    Console.WriteLine(cust.job_id + " " + cust.jobnumber + " " + cust.jobname);
                }

            }
            Console.ReadLine();
        }
        
    }
}
