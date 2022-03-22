using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploGridLista
{
    public partial class FrmPopula : Form
    {
        private List<Contrato> _contrato;

        public FrmPopula()
        {
            InitializeComponent();
            InitializeList();
            //this.DgvContrato.AutoGenerateColumns = false;
        }
      
        public void InitializeList()
        {
            _contrato = new List<Contrato>() {
                new Contrato()
                {
                    NumeroContrato = "123456789",
                    NumeroParcela = 20,
                    NomeCliente = "Fulano de Tal",
                    Cpf = "11111111111",
                    Cidade = "Bauru",
                    Uf = "SP",
                    Empresa = "Empresa da casa do Seu locha",
                    Regua = "1",
                    ContratoCurto = "123",
                    Erros = new List<Erro>() {
                        new Erro() {  Codigo = 1, Descricao = "Erro 1 Contrato 1" },
                        new Erro() {  Codigo = 2, Descricao = "Erro 2 Contrato 1" }
                    }
                },
                new Contrato()
                {
                    NumeroContrato = "245457224",
                    NumeroParcela = 15,
                    NomeCliente = "Ciclano de Abreu",
                    Cpf = "22222222222",
                    Cidade = "Agudos",
                    Uf = "SP",
                    Empresa = "Empresa dunha ltda.",
                    Regua = "1",
                    ContratoCurto = "245",
                    Erros = new List<Erro>() {
                        new Erro() {  Codigo = 1, Descricao = "Erro 1 Contrato 2" },
                        new Erro() {  Codigo = 2, Descricao = "Erro 2 Contrato 2" }
                    }
                },
                new Contrato()
                {
                    NumeroContrato = "548752145",
                    NumeroParcela = 2,
                    NomeCliente = "Eu Mesmo de Oliveira",
                    Cpf = "33333333333",
                    Cidade = "Caconde",
                    Uf = "SP",
                    Empresa = "Empresa fucking good",
                    Regua = "1",
                    ContratoCurto = "548",
                    Erros = new List<Erro>() {
                        new Erro() {  Codigo = 1, Descricao = "Erro 1 Contrato 3" },
                        new Erro() {  Codigo = 2, Descricao = "Erro 2 Contrato 3" }
                    }
                }
            };
        }

        private void btnPopula_Click(object sender, EventArgs e)
        {
            //Essa linha somente para ilustrar o override do ToString na classe Erro
            var teste = _contrato.Select(r => r.Erros).ToList();

            var novoContratoLinq = new List<object>();

           /* var novoContrato = new List<object>();

            foreach (var contrato in _contrato)
            {
                novoContratoLinq.Add(new
                {
                    NumeroContrato = contrato.NumeroContrato,
                    NumeroParcela = contrato.NumeroParcela,
                    NomeCliente = contrato.NomeCliente,
                    Cpf = contrato.Cpf,
                    Cidade = contrato.Cidade,
                    Uf = contrato.Uf,
                    Empresa = contrato.Empresa,
                    Regua = contrato.Regua,
                    ContratoCurto = contrato.ContratoCurto,
                    Erros = string.Join("-", contrato.Erros.Select(err => err.Descricao).ToList())
                });
            }*/

            _contrato.ForEach(contrato => {
                novoContratoLinq.Add(new
                {
                    NumeroContrato = contrato.NumeroContrato,
                    NumeroParcela = contrato.NumeroParcela,
                    NomeCliente = contrato.NomeCliente,
                    Cpf = contrato.Cpf,
                    Cidade = contrato.Cidade,
                    Uf = contrato.Uf,
                    Empresa = contrato.Empresa,
                    Regua = contrato.Regua,
                    ContratoCurto = contrato.ContratoCurto,
                    Erros = string.Join("-", contrato.Erros.Select(err => err.Descricao).ToList())
                });
            });
          
            this.DgvContrato.DataSource = null;
            this.DgvContrato.DataSource = novoContratoLinq;
            this.DgvContrato.Refresh();
        }
    }
}
