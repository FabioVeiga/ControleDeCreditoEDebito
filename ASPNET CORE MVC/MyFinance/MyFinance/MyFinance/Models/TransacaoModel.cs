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
    public class TransacaoModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a data da despesa!")]
        public string Data { get; set; }
        public string DataFinal { get; set; } //utilizada para filtros
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Informe o valor da despesa!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Informe a descricao da despesa!")]
        public string Descricao { get; set; }
        public int Conta_Id { get; set; }
        public string Nome_Conta { get; set; }
        public int Plano_Contas_Id { get; set; }
        public string Nome_Plano_Conta { get; set; }
        public int Usuario_Id { get; set; }

        //criar variavel da ContextAcessor
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        //criar um construtor para o usuariologado
        public TransacaoModel() { }
        //Rececbe o contexto para o acesso das variaveis de sessao
        public TransacaoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public string IdUsuarioLogado()
        {
            return @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        //criar lista do objeto Conta
        public List<TransacaoModel> ListaTransacao()
        {
            //cria nova instancia para todo o objeto transacao
            List<TransacaoModel> lista = new List<TransacaoModel>();
            TransacaoModel item;

            //utilizado pela View Extrato
            string filtro = " ";
            if ((Data != null) && (DataFinal != null))
            {
                filtro += $" AND T.DATA >= '{DateTime.Parse(Data).ToString("yyyy-MM-dd")}' AND T.DATA <= '{DateTime.Parse(DataFinal).ToString("yyyy-MM-dd")}' ";
            }
            if (Tipo != null)
            {
                if (Tipo != "A")
                {
                    filtro += $" AND T.TIPO = '{Tipo}' ";
                }
            }
            if (Conta_Id != 0)
            {
                filtro += $" AND T.CONTA_ID = '{Conta_Id}' ";
            }

            //fim

            //query para selecionar na base de dados
            string sql = "SELECT T.ID, T.DATA, T.TIPO, T.VALOR, T.DESCRICAO AS HISTORICO, " +
                         "C.ID AS ID_CONTA, C.NOME AS NOME_CONTA, PC.ID AS ID_PLANO_CONTAS, PC.DESCRICAO AS Nome_Plano_Conta " +
                         "FROM TRANSACAO T INNER JOIN CONTA C ON C.ID = T.conta_ID " +
                         "INNER JOIN PLANO_CONTAS PC ON PC.ID = T.PLANO_CONTAS_ID " +
                         $"WHERE T.USUARIO_ID = {IdUsuarioLogado()} {filtro}" +
                         "ORDER BY T.DATA DESC LIMIT 10;";

            //instacia o DAL para conexao do banco
            DAL objDAL = new DAL();

            //instacia um datatable para armazenar os dados
            DataTable dt = objDAL.RetDataTable(sql);

            //cria umlaco de repeticao para trazer todos dos itens da tabela
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //instacia para cada linha um objeto da conta
                item = new TransacaoModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Data = DateTime.Parse(dt.Rows[i]["DATA"].ToString()).ToString("yyyy-MM-dd");
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Valor = double.Parse(dt.Rows[i]["Valor"].ToString());
                item.Descricao = dt.Rows[i]["HISTORICO"].ToString();
                item.Conta_Id = int.Parse(dt.Rows[i]["ID_CONTA"].ToString());
                item.Nome_Conta = dt.Rows[i]["NOME_CONTA"].ToString();
                item.Plano_Contas_Id = int.Parse(dt.Rows[i]["ID_PLANO_CONTAS"].ToString());
                item.Nome_Plano_Conta = dt.Rows[i]["Nome_Plano_Conta"].ToString();

                //inserir na lista
                lista.Add(item);
            }
            return lista;
        }

        public void Insert()
        {
            string sql;
            //verifica se tem ID
            if (Id == 0)
            {
                sql = $"INSERT INTO TRANSACAO (DATA, TIPO, VALOR, DESCRICAO, Conta_id, Plano_Contas_id, usuario_id) " +
                      $"VALUES('{DateTime.Parse(Data).ToString("yyyy-MM-dd")}','{Tipo}','{Valor}','{Descricao}','{Conta_Id}','{Plano_Contas_Id}','{IdUsuarioLogado()}')";
                DAL objDAL = new DAL();
                objDAL.ExecutarComandoSQL(sql);
            }
            else
            {
                sql = $"UPDATE TRANSACAO SET " +
                      $"DATA ='{DateTime.Parse(Data).ToString("yyyy-MM-dd")}', " +
                      $"TIPO ='{Tipo}', " +
                      $"VALOR ='{Valor}', " +
                      $"DESCRICAO = '{Descricao}', " +
                      $"CONTA_ID = '{Conta_Id}', " +
                      $"PLANO_CONTAS_ID = '{Plano_Contas_Id}' " +
                      $"WHERE ID = {Id}";
                new DAL().ExecutarComandoSQL(sql);
            }

        }

        public TransacaoModel CarregarRegistro(int? id)
        {
            TransacaoModel item = new TransacaoModel();

            string sql = "SELECT T.ID, T.DATA, T.TIPO, T.VALOR, T.DESCRICAO AS HISTORICO, " +
                         "C.ID AS ID_CONTA, C.NOME AS NOME_CONTA, PC.ID AS ID_PLANO_CONTAS, PC.DESCRICAO AS Nome_Plano_Conta " +
                         "FROM TRANSACAO T INNER JOIN CONTA C ON C.ID = T.conta_ID " +
                         "INNER JOIN PLANO_CONTAS PC ON PC.ID = T.PLANO_CONTAS_ID " +
                         $"WHERE T.USUARIO_ID = {IdUsuarioLogado()} AND T.ID = {id}";

            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            item = new TransacaoModel();
            item.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Data = DateTime.Parse(dt.Rows[0]["DATA"].ToString()).ToString("yyyy-MM-dd");
            item.Tipo = dt.Rows[0]["TIPO"].ToString();
            item.Valor = double.Parse(dt.Rows[0]["Valor"].ToString());
            item.Descricao = dt.Rows[0]["HISTORICO"].ToString();
            item.Conta_Id = int.Parse(dt.Rows[0]["ID_CONTA"].ToString());
            item.Nome_Conta = dt.Rows[0]["NOME_CONTA"].ToString();
            item.Plano_Contas_Id = int.Parse(dt.Rows[0]["ID_PLANO_CONTAS"].ToString());
            item.Nome_Plano_Conta = dt.Rows[0]["Nome_Plano_Conta"].ToString();

            return item;
        }

        public void Excluir(int id)
        {
            new DAL().ExecutarComandoSQL("DELETE FROM TRANSACAO WHERE ID = " + id);
        }
    }

    //classe auxiliar para o dashboard
    public class Dashboard
    {
        public double Total { get; set; }
        public string PlanoConta { get; set; }
        public string Data { get; set; }
        public string DataFinal { get; set; } //utilizada para filtros
        public string Tipo { get; set; }

        public IHttpContextAccessor HttpContextAccessorDash { get; set; }

        //criar um construtor para o usuariologado
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        //criar um construtor para o usuariologado
        public Dashboard() { }
        //Rececbe o contexto para o acesso das variaveis de sessao
        public Dashboard(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public string IdUsuarioLogado()
        {
            return @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        public List<Dashboard> RetornarDadosGraficoPie(Dashboard formulario)
        {

            List<Dashboard> lista = new List<Dashboard>();
            Dashboard item;

            //filtros para Dashboard
            string filtro = "";
            if((formulario.Tipo == null) || (formulario.Tipo == "A"))
            {
                filtro += $"T.TIPO in ('R','D') ";
            }
            else
            {
                filtro += $"T.TIPO = '{formulario.Tipo}' ";
            }
            if ((formulario.Data != null) && (formulario.DataFinal != null))
            {
                filtro += $" AND T.DATA >= '{DateTime.Parse(Data).ToString("yyyy-MM-dd")}' AND T.DATA <= '{DateTime.Parse(DataFinal).ToString("yyyy-MM-dd")}' ";
            }

            string sql = "SELECT T.VALOR AS TOTAL, PC.DESCRICAO FROM TRANSACAO T " +
                         "INNER JOIN PLANO_CONTAS PC ON PC.ID = T.PLANO_CONTAS_ID " +
                         $"WHERE {filtro} AND T.USUARIO_ID = {IdUsuarioLogado()} " +
                         "GROUP BY PC.DESCRICAO";

            DAL objDAL = new DAL();
            DataTable dtDash = new DataTable();
            dtDash = objDAL.RetDataTable(sql);

            for (int i = 0; i < dtDash.Rows.Count; i++)
            {
                item = new Dashboard();
                item.Total = double.Parse(dtDash.Rows[i]["TOTAL"].ToString());
                item.PlanoConta = dtDash.Rows[i]["DESCRICAO"].ToString();
                lista.Add(item);
            }

            return lista;
        }
    }
}
