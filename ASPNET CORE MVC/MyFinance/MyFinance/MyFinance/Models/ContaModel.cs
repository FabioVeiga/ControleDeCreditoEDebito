using Microsoft.AspNetCore.Http;
using MyFinance.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Informe o nome da conta")]
        public string Nome { get; set; }
        [Required (ErrorMessage ="Informe o saldo da conta")]
        public double Saldo { get; set; }
        public int Usuario_Id { get; set; }
        //criar variavel da ContextAcessor
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        //criar um construtor para o usuariologado
        public ContaModel()
        {

        }

        private string IdUsuarioLogado()
        {
            return @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        //Rececbe o contexto para o acesso das variaveis de sessao
        public ContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        //criar lista do objeto Conta
        public List<ContaModel> ListaConta()
        {
            //cria nova instancia para todo o objeto Conta
            List<ContaModel> lista = new List<ContaModel>();
            ContaModel item;

            //

            //query para selecionar na base de dados
            string sql = $"SELECT ID, NOME, SALDO, USUARIO_ID FROM CONTA WHERE USUARIO_ID = {IdUsuarioLogado()}";

            //instacia o DAL para conexao do banco
            DAL objDAL = new DAL();

            //instacia um datatable para armazenar os dados
            DataTable dt = objDAL.RetDataTable(sql);

            //cria umlaco de repeticao para trazer todos dos itens da tabela
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //instacia para cada linha um objeto da conta
                item = new ContaModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Nome = dt.Rows[i]["NOME"].ToString();
                item.Saldo = double.Parse(dt.Rows[i]["SALDO"].ToString());
                item.Usuario_Id = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());

                //inserir na lista
                lista.Add(item);
            }
            return lista;
        }
        //criar o metodo para inserir
        public void Insert()
        {
            string sql = $"INSERT INTO CONTA (NOME, SALDO, USUARIO_ID) VALUES('{Nome}','{Saldo}','{IdUsuarioLogado()}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }
        public void Excluir(int id_conta)
        {
            new DAL().ExecutarComandoSQL("DELETE FROM CONTA WHERE ID = " + id_conta);
        }
    }
}
