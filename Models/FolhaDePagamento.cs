using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payroll_api.Models
{
    public class FolhaDePagamento
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public int Horas { get; set; }
        public int ValorHora { get; set; }
        public int ano { get; set; }
        public int mes { get; set; }
    }
}