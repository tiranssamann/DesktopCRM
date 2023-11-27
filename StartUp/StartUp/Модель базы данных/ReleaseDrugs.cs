using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Модель_базы_данных
{
    public class ReleaseDrugs
    {
        public int ID { get; set; }
        public DateTime DateOfRelease { get; set; }
        public Employee employee { get; set; }
        public Contragent contragent { get; set; }
        public List<DrugsToSale> DrugsToSale { get; set; } = new List<DrugsToSale>();
    }
}
