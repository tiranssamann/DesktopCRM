using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Модель_базы_данных
{
    public class Drugs
    {
        public int ID { get; set; }
        public string NameOfDrug { get; set; }
        public int Counts { get; set; }
        public string FormCreations { get; set; }
        public double ComingPrice { get; set; }
        public double ComingProcent { get; set; }
        public double Price { get; set; }
        public double Procent { get; set; }
        public DateTime DateOfExplotation { get; set; }
        public string Creator { get; set; }
        public string SNumber { get; set; }
        public ComingDrugs ComingDrug { get; set; }
    }
}
