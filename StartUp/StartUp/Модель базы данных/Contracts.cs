using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Модель_базы_данных
{
    public class Contracts
    {
        public int ID { get; set; }
        public string NameContract { get; set; }
        public string DateContract { get; set; }
        public Contragent Contragent { get; set; }
    }
}
