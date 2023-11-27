using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Модель_базы_данных
{
    public class Contragent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Contracts> Contract { get; set; }
        public string OKED { get; set; }
        public string OKONH { get; set; }
        public string Inn { get; set; }
        public string BankScope { get; set; }
        public List<ComingDrugs> ComingDrugs { get; set; } = new List<ComingDrugs>();
        public List<ReleaseDrugs> ReleaseDrugs { get; set; } = new List<ReleaseDrugs>();
    }
}
