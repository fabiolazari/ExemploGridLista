using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGridLista
{
    public class Contrato
    {
        public string NumeroContrato { get; set; }
        public int NumeroParcela { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Empresa { get; set; }
        public string Regua { get; set; }
        public string ContratoCurto { get; set; }
        public List<Erro> Erros { get; set; }
    }

    public class Erro
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"{Descricao}-";
        }
    }
}
