using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Модель_базы_данных
{
    public class ComingDrugs
    {
        public int ID { get; set; }
        public string NameOfComing { get; set; }
        public Contragent Contragent { get; set; }
        public DateTime DateOfComing { get; set; }
        public List<Drugs> Drugss { get; set; } = new List<Drugs>();
    }
}
