using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
namespace StartUp.Модель_базы_данных
{
    public class CRMContext : DbContext
    {

        public CRMContext() : base("CRMSource") { }
        public DbSet<Contragent> Contragents { get; set; }
        public DbSet<ComingDrugs> ComingDrugs { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<DrugsToSale> DrugsToSale { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ReleaseDrugs> ReleaseDrugs { get; set; }
        public DbSet<Contracts> Contracts  { get; set; }
    }
}
