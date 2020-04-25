using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class PlanoContaModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Informar a descricao da despesa!")]
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Usuario_Id { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public PlanoContaModel() { }
        public PlanoContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<PlanoContaModel> ListaPlanoConta()
        {
            //cria nova instancia para todo o objeto Conta
            List<PlanoContaModel> lista = new List<PlanoContaModel>();
            PlanoContaModel item;

            //Busca o usuario logado na sessao
            string idUsuarioLogadoSessao = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            //query para selecionar na base de dados
            string sql = $"SELECT ID, DESCRICAO, TIPO, USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = {idUsuarioLogadoSessao}";

            //instacia o DAL para conexao do banco
            DAL objDAL = new DAL();

            //instacia um datatable para armazenar os dados
            DataTable dt = objDAL.RetDataTable(sql);

            //cria umlaco de repeticao para trazer todos dos itens da tabela
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //instacia para cada linha um objeto da Plano de contas
                item = new PlanoContaModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Usuario_Id = dt.Rows[i]["USUARIO_ID"].ToString();

                //inserir na lista
                lista.Add(item);
            }
            return lista;
        }


        public void Insert()
        {
            string idUsuarioLogadoSessao = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql;
            //verifica se tem ID
            if (Id == 0)
            {
                sql = $"INSERT INTO PLANO_CONTAS (DESCRICAO, TIPO, USUARIO_ID) VALUES('{Descricao}','{Tipo}','{idUsuarioLogadoSessao}')";
                DAL objDAL = new DAL();
                objDAL.ExecutarComandoSQL(sql);
            }
            else
            {
                sql = $"UPDATE PLANO_CONTAS SET DESCRICAO='{Descricao}', TIPO='{Tipo}' WHERE ID = {Id}";
                new DAL().ExecutarComandoSQL(sql);
            }
            
        }
        public void Excluir(int id_conta)
        {
            new DAL().ExecutarComandoSQL("DELETE FROM PLANO_CONTAS WHERE ID = " + id_conta);
        }

        //metodo para carregar os dados do registrto
        public PlanoContaModel CarregarRegistro(int? id)
        {
            PlanoContaModel item = new PlanoContaModel();
            string idUsuarioLogadoSessao = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = $"SELECT ID, DESCRICAO, TIPO, USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = '{idUsuarioLogadoSessao}' AND ID = {id}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            item.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Descricao = dt.Rows[0]["DESCRICAO"].ToString();
            item.Tipo = dt.Rows[0]["TIPO"].ToString();
            item.Usuario_Id = dt.Rows[0]["USUARIO_ID"].ToString();

            return item;
        }

    }
}
