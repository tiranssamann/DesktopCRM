using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Модель_базы_данных
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Number { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool FirstLvl { get; set; }
        public bool SecondLvl { get; set; }
        public bool Administrator { get; set; }
        public List<ReleaseDrugs> ReleaseDrugs { get; set; } = new List<ReleaseDrugs>();
    }
}
