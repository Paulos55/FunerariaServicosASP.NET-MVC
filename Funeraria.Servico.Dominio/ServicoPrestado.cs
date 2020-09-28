using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria.Servico.Dominio
{
    public class ServicoPrestado
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Data { get; set; }
        public int Valor { get; set; }
        public string Desc { get; set; }

    }
}
